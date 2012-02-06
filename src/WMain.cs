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

namespace kanbada
{
    public partial class WMain : Form
    {
        public WMain()
        {
            InitializeComponent();
            uKanbanBoard.NotificaAlteracao +=new Action(NotificaAlteracao);
            uKanbanBoard.SetupNotificacao();
            string nomeArquivo = PegaArquivo();
            fw = new FileSystemWatcher(Path.GetDirectoryName(nomeArquivo), Path.GetFileName(nomeArquivo));
            fw.EnableRaisingEvents = true;
            fw.Changed += new FileSystemEventHandler(fw_Changed);
            CarregaSprint();
        }

        FileSystemWatcher fw;
        void fw_Changed(object sender, FileSystemEventArgs e)
        {
            TentaCarregar(0);
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
            }
            finally
            {
                uKanbanBoard.ResumeLayout();
            }
        }

        public string PegaArquivo()
        {
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            return Path.Combine(path, "sprint.xml");
        }

        private void tbOrganiza_Click(object sender, EventArgs e)
        {
            uKanbanBoard.AjustaColunas();
        }

    }
}
