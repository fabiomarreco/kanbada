namespace kanbada
{
    partial class UEditorPropriedade
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
            this.lbNomePropriedade = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNomePropriedade
            // 
            this.lbNomePropriedade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomePropriedade.Location = new System.Drawing.Point(3, 1);
            this.lbNomePropriedade.Name = "lbNomePropriedade";
            this.lbNomePropriedade.Size = new System.Drawing.Size(60, 13);
            this.lbNomePropriedade.TabIndex = 2;
            this.lbNomePropriedade.Text = "Verificador:";
            this.lbNomePropriedade.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbValor
            // 
            this.tbValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValor.Location = new System.Drawing.Point(62, 0);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(87, 18);
            this.tbValor.TabIndex = 3;
            this.tbValor.Text = "marreco";
            this.tbValor.Leave += new System.EventHandler(this.tbValor_TextChanged);
            // 
            // UEditorPropriedade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.lbNomePropriedade);
            this.Name = "UEditorPropriedade";
            this.Size = new System.Drawing.Size(150, 17);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomePropriedade;
        private System.Windows.Forms.TextBox tbValor;

    }
}
