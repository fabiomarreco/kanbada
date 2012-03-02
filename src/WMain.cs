using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;
using System.Threading;
using System.Runtime.InteropServices;

namespace kanbada
{
    public partial class WMain : Form
    {
        public WMain(string nomeArquivo)
            : this()
        {
            this.NomeArquivo = nomeArquivo;
            uKanbanBoard.NotificaAlteracao += new Action(NotificaAlteracao);
            uKanbanBoard.SetupNotificacao();
            fw = new FileSystemWatcher(Path.GetDirectoryName(nomeArquivo), Path.GetFileName(nomeArquivo));
            fw.EnableRaisingEvents = true;
            fw.Changed += new FileSystemEventHandler(fw_Changed);
            CarregaSprint();
            this.FormClosing += new FormClosingEventHandler(WMain_FormClosing);
        }

        void WMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            fw.EnableRaisingEvents = false;
        }

        public WMain()
        {
            InitializeComponent();
        }

        private string PegaArquivo()
        {
            return NomeArquivo;
        }

        FileSystemWatcher fw;
        void fw_Changed(object sender, FileSystemEventArgs e)
        {
            this.SuspendLayout();
            if (InvokeRequired)
                Invoke (new Action(() => { uKanbanBoard.Visible = false; }));

            fw.EnableRaisingEvents = false;
            try
            {
                TentaCarregar(0);
            }
            catch (Exception ex)
            {
                if (InvokeRequired)
                {
                    this.Invoke( new Action(() =>
                    {
                        this.Hide();
                        if (MessageBox.Show(string.Format("Ocorreu um erro e o programa deve ser reinicializado! \r\n\n ERRO: {0}\r\n\n {1}", ex.Message, ex.ToString()), "ERRO",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                            Application.Restart();
                        else
                            Application.Exit();
                    }));
                        
                }
            }
            finally
            {
                this.ResumeLayout();
                if (InvokeRequired)
                    Invoke(new Action(() => { uKanbanBoard.Visible = true; }));
                fw.EnableRaisingEvents = true;
            }
        }

        private void TentaCarregar(int tentativa)
        {
            Thread.Sleep(600);
            try
            {
                if (InvokeRequired)
                    Invoke(new Action(CarregaSprint));
                else
                    CarregaSprint();
            }
            catch (IOException)
            {
                if (tentativa >= 5)
                    throw;

                TentaCarregar(tentativa + 1);
            }
        }

        void NotificaAlteracao()
        {
            SalvaSprint();
        }

        private void SalvaSprint()
        {
            string nomeARquivo = PegaArquivo();
            XmlSerializer serializer = new XmlSerializer(typeof(Sprint));
            fw.EnableRaisingEvents = false;
            using (StreamWriter sw = new StreamWriter(nomeARquivo, false, Encoding.Default))
            {
                serializer.Serialize(sw, uKanbanBoard.Sprint);
            }

            fw.EnableRaisingEvents = true;
        }

        private void CarregaSprint()
        {
            uKanbanBoard.SuspendLayout();
            try
            {

                string nomeARquivo = PegaArquivo();
                XmlSerializer serializer = new XmlSerializer(typeof(Sprint));
                using (StreamReader sr = new StreamReader(nomeARquivo, Encoding.Default))
                {
                    Sprint sprint = (Sprint)serializer.Deserialize(sr);
                    uKanbanBoard.Sprint = sprint;
                    uKanbanBoard.AtualizaSprint();
                }

                if (InvokeRequired)
                    Invoke(new Action(DoFlash));
                else
                    DoFlash();
            }
            finally
            {
                uKanbanBoard.ResumeLayout();
            }
        }

     

        private void tbOrganiza_Click(object sender, EventArgs e)
        {
            uKanbanBoard.AjustaColunas();
        }


        public string NomeArquivo { get; set; }

        private void WMain_ResizeEnd(object sender, EventArgs e)
        {
            tbOrganiza_Click(sender, e);
        }


        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FlashWindowEx(ref FLASHWINFO pwfi);

        [StructLayout(LayoutKind.Sequential)]
        public struct FLASHWINFO
        {
            public UInt32 cbSize;
            public IntPtr hwnd;
            public UInt32 dwFlags;
            public UInt32 uCount;
            public UInt32 dwTimeout;
        }

      

        public void DoFlash()
        {
            FLASHWINFO fInfo = new FLASHWINFO();
            fInfo.cbSize = Convert.ToUInt32(Marshal.SizeOf(fInfo));
            fInfo.hwnd = this.Handle;
            fInfo.dwFlags = (uint)(FlashWindowFlags.FLASHW_TRAY | FlashWindowFlags.FLASHW_TIMERNOFG);
            fInfo.uCount = 0;
            fInfo.dwTimeout = 0;

            FlashWindowEx(ref fInfo);
        }
    }

    public enum FlashWindowFlags : uint
    {
        /// <summary>
        /// Stop flashing. The system restores the window to its original state.
        /// </summary>
        FLASHW_STOP = 0,

        /// <summary>
        /// Flash the window caption.
        /// </summary>
        FLASHW_CAPTION = 1,

        /// <summary>
        /// Flash the taskbar button.
        /// </summary>
        FLASHW_TRAY = 2,

        /// <summary>
        /// Flash both the window caption and taskbar button.
        /// This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags.
        /// </summary>
        FLASHW_ALL = 3,

        /// <summary>
        /// Flash continuously, until the FLASHW_STOP flag is set.
        /// </summary>
        FLASHW_TIMER = 4,

        /// <summary>
        /// Flash continuously until the window comes to the foreground.
        /// </summary>
        FLASHW_TIMERNOFG = 12
    }
}
