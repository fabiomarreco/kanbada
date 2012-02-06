using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kanbada
{
    public partial class UEstadoTarefa : UserControl
    {
        public UEstadoTarefa()
        {
            InitializeComponent();
            flowLayoutPanel.AllowDrop = true;
        }


        private EstadoTarefa _estado;
        public EstadoTarefa Estado
        {
            get { return _estado; }
            set { _estado = value; lblEstado.Text = value.ToString(); }
        }

        internal UTarefa AdicionaTarefa(Tarefa tarefa)
        {
            var utarefa = new UTarefa(tarefa, this, NotificaAlteracao);
            utarefa.NotificaAlteracao += NotificaAlteracao;
            this.flowLayoutPanel.Controls.Add(utarefa);
            return utarefa;
        }

        private void flowLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            //target control will accept data here 
            //Panel destination = (Panel)sender;
            UTarefa uTarefa = e.Data.GetData(typeof(UTarefa)) as UTarefa;
            if (uTarefa == null)
                return;

            if (uTarefa.UEstado == this)
                return;

            if (uTarefa.UEstado != null)
            {
                uTarefa.UEstado.flowLayoutPanel.Controls.Remove(uTarefa);
            }
            
            uTarefa.Tarefa.Estado = this.Estado;
            AdicionaTarefa(uTarefa.Tarefa).BackColor = uTarefa.BackColor ;

            if (NotificaAlteracao != null)
                NotificaAlteracao();
        }

        public event Action NotificaAlteracao;

        private void flowLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            //As we are interested in Image data only we will check this as follows
            if (e.Data.GetDataPresent(typeof(UTarefa)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }


        public void Limpa()
        {
            flowLayoutPanel.Controls.Clear();
        }
    }
}
