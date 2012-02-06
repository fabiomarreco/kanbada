using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;

namespace kanbada
{
    public partial class UKanbanBoard : UserControl
    {
        Color[] coresPossiveis = new[] { 
            Color.LightYellow, Color.LightSalmon, Color.LightSkyBlue, Color.LightBlue, Color.LightGreen, Color.Fuchsia,
            Color.Aqua, Color.LightCoral, Color.Purple, Color.LightPink };

        public UKanbanBoard()
        {
            InitializeComponent();
        }

        public void SetupNotificacao()
        {
            this.uEstadoTarefaBackLog.NotificaAlteracao += new Action(NotificaAlteracao);
            this.uEstadoTarefaDoing.NotificaAlteracao += new Action(NotificaAlteracao);
            this.uEstadoTarefaDone.NotificaAlteracao += new Action(NotificaAlteracao);
            this.uEstadoTarefaToVerify.NotificaAlteracao += new Action(NotificaAlteracao);
            this.uEstadoTarefaVerifying.NotificaAlteracao += new Action(NotificaAlteracao);
        }


        public event Action NotificaAlteracao;
        public Sprint Sprint { get; set; }

        public void AtualizaSprint()
        {
            var estados = new[] { uEstadoTarefaBackLog, uEstadoTarefaDoing, uEstadoTarefaToVerify, uEstadoTarefaVerifying, uEstadoTarefaDone }.ToDictionary(s => s.Estado);
            foreach (var est in estados.Values)
                est.Limpa();

            int i = 0;
            foreach (var historia in Sprint.Historias.OrderBy (s=> s.Disabled).ThenBy (s=> s.Codigo))
            {
                Color cor = (historia.Disabled)? Color.Gray : coresPossiveis[i++];
                    
                foreach (var tarefa in historia.Tarefas)
                {
                    estados[tarefa.Estado].AdicionaTarefa(tarefa).BackColor = cor ;
                }
            }
        }

        internal void AjustaColunas()
        {
            var paineis = new[] { panel1, panel2, panel3, panel4, panel5 };
            var tamanho = paineis.Select (s=> s.Width).Average();

            foreach (var p in paineis)
                p.Width = (int)tamanho;

            panel1.Width = (int)((double)tamanho * 1.1);
            panel2.Width = (int)((double)tamanho * 1.1);

        }

        public bool Enoding { get; set; }
    }
}
