using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace kanbada
{
    public partial class UEditorPropriedade : UserControl
    {
        public UEditorPropriedade()
        {
            InitializeComponent();
        }

        string _proprieade = string.Empty;
        private string Propriedade 
        { 
            get { return _proprieade; }
            set { _proprieade = value; lbNomePropriedade.Text = _proprieade + ":"; } 
        }

        public void Setup(string nome, object objeto)
        {
            this.Propriedade = nome;
            this.Objeto = objeto;

            Type tipo = objeto.GetType();
            PropertyInfo propriedade = tipo.GetProperty(nome);
            tbValor.Text = propriedade.GetValue(objeto, new object[] { }).ToString();
        }

        private object Objeto { get; set; }
        private void tbValor_TextChanged(object sender, EventArgs e)
        {
            Type tipo = Objeto.GetType();
            PropertyInfo propriedade = tipo.GetProperty(_proprieade);
            string valorAntigo  = propriedade.GetValue(Objeto, new object[] { }).ToString();
            string valorNovo = tbValor.Text.Trim();

            if (string.Compare(valorAntigo, valorNovo) != 0)
            {
                propriedade.SetValue(Objeto, valorNovo, new object[] { });
                if (NotificaAlteracao != null)
                    NotificaAlteracao();
            }
        }


        public event Action NotificaAlteracao;
    }
}
