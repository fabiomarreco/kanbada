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
    public partial class UTarefa : UserControl
    {
        public UTarefa(Tarefa tarefa, UEstadoTarefa uEstado, Action notificacao)
            : this()
        {
            Setup(tarefa, uEstado);

            this.NotificaAlteracao = notificacao;
            uEditorQuem.NotificaAlteracao += notificacao;
            uEditorVerificador.NotificaAlteracao += notificacao;
            uEditorHoras.NotificaAlteracao += notificacao;
            AjustaTamanho();
        }



        public UTarefa()
        {
            InitializeComponent();
            this.lblNome.MouseDown += new MouseEventHandler(UTarefa_MouseDown);

        }

        public void AjustaTamanho()
        {
            cbDetalhes_CheckedChanged(null, null);
        }

        public UEstadoTarefa UEstado { get; set; }

        void UTarefa_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(this, DragDropEffects.Move);
        }

        public Tarefa Tarefa { get; set; }
        public void Setup(Tarefa tarefa, UEstadoTarefa uEstado)
        {
            this.UEstado = uEstado;
            this.Tarefa = tarefa;
            
            uEditorQuem.Setup("Quem", tarefa);
            uEditorVerificador.Setup("Verificador", tarefa);
            uEditorHoras.Setup("HorasAlocadas", tarefa);
            lblHistoria.Text =  tarefa.Historia.Nome;
            lblNome.Text = tarefa.Historia.Codigo + ", " + tarefa.Nome;
        }

        public event Action NotificaAlteracao;

        private void cbDetalhes_CheckedChanged(object sender, EventArgs e)
        {
            pnBottom.Visible = pnTopo.Visible = cbDetalhes.Checked;
            SizeF sz = CreateGraphics().MeasureString(lblNome.Text, lblNome.Font, lblNome.Width);
            int altura = (int)sz.Height + 10;
            pnTarefa.Height = altura;

            if (pnBottom.Visible)
                altura += pnBottom.Height;

            if (pnTopo.Visible)
                altura += pnTopo.Height;

            this.Height = altura;
        }
    }
}
