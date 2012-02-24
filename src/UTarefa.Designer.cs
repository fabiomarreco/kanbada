namespace kanbada
{
    partial class UTarefa
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnTopo = new System.Windows.Forms.Panel();
            this.lblHistoria = new System.Windows.Forms.Label();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.uEditorHoras = new kanbada.UEditorPropriedade();
            this.uEditorVerificador = new kanbada.UEditorPropriedade();
            this.uEditorQuem = new kanbada.UEditorPropriedade();
            this.pnTarefa = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.cbDetalhes = new System.Windows.Forms.CheckBox();
            this.pnTopo.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.pnTarefa.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopo
            // 
            this.pnTopo.Controls.Add(this.lblHistoria);
            this.pnTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopo.Location = new System.Drawing.Point(0, 0);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(119, 29);
            this.pnTopo.TabIndex = 0;
            // 
            // lblHistoria
            // 
            this.lblHistoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHistoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoria.Location = new System.Drawing.Point(0, 0);
            this.lblHistoria.Name = "lblHistoria";
            this.lblHistoria.Size = new System.Drawing.Size(119, 29);
            this.lblHistoria.TabIndex = 0;
            this.lblHistoria.Text = "Regra exposição à crédito (nominal ou percentual)";
            this.lblHistoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.uEditorHoras);
            this.pnBottom.Controls.Add(this.uEditorVerificador);
            this.pnBottom.Controls.Add(this.uEditorQuem);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 91);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(119, 51);
            this.pnBottom.TabIndex = 3;
            // 
            // uEditorHoras
            // 
            this.uEditorHoras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uEditorHoras.Location = new System.Drawing.Point(0, 34);
            this.uEditorHoras.Name = "uEditorHoras";
            this.uEditorHoras.Size = new System.Drawing.Size(119, 17);
            this.uEditorHoras.TabIndex = 2;
            // 
            // uEditorVerificador
            // 
            this.uEditorVerificador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uEditorVerificador.Location = new System.Drawing.Point(0, 17);
            this.uEditorVerificador.Name = "uEditorVerificador";
            this.uEditorVerificador.Size = new System.Drawing.Size(119, 17);
            this.uEditorVerificador.TabIndex = 1;
            // 
            // uEditorQuem
            // 
            this.uEditorQuem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uEditorQuem.Location = new System.Drawing.Point(0, 0);
            this.uEditorQuem.Name = "uEditorQuem";
            this.uEditorQuem.Size = new System.Drawing.Size(119, 17);
            this.uEditorQuem.TabIndex = 0;
            // 
            // pnTarefa
            // 
            this.pnTarefa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTarefa.Controls.Add(this.panel1);
            this.pnTarefa.Controls.Add(this.cbDetalhes);
            this.pnTarefa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTarefa.Location = new System.Drawing.Point(0, 29);
            this.pnTarefa.Name = "pnTarefa";
            this.pnTarefa.Size = new System.Drawing.Size(119, 62);
            this.pnTarefa.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 60);
            this.panel1.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(0, 0);
            this.lblNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(105, 60);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Prepara demonstracao (Por Contraparte)";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDetalhes
            // 
            this.cbDetalhes.AutoSize = true;
            this.cbDetalhes.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbDetalhes.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDetalhes.Location = new System.Drawing.Point(0, 0);
            this.cbDetalhes.Name = "cbDetalhes";
            this.cbDetalhes.Size = new System.Drawing.Size(12, 60);
            this.cbDetalhes.TabIndex = 2;
            this.cbDetalhes.UseVisualStyleBackColor = true;
            this.cbDetalhes.CheckedChanged += new System.EventHandler(this.cbDetalhes_CheckedChanged);
            // 
            // UTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pnTarefa);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnTopo);
            this.Name = "UTarefa";
            this.Size = new System.Drawing.Size(119, 142);
            this.pnTopo.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.pnTarefa.ResumeLayout(false);
            this.pnTarefa.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopo;
        private System.Windows.Forms.Label lblHistoria;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Panel pnTarefa;
        private UEditorPropriedade uEditorHoras;
        private UEditorPropriedade uEditorVerificador;
        private UEditorPropriedade uEditorQuem;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.CheckBox cbDetalhes;
        private System.Windows.Forms.Panel panel1;
    }
}
