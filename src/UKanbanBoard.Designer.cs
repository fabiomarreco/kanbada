namespace kanbada
{
    partial class UKanbanBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uEstadoTarefaBackLog = new kanbada.UEstadoTarefa();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uEstadoTarefaDone = new kanbada.UEstadoTarefa();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uEstadoTarefaVerifying = new kanbada.UEstadoTarefa();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uEstadoTarefaDoing = new kanbada.UEstadoTarefa();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.uEstadoTarefaToVerify = new kanbada.UEstadoTarefa();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uEstadoTarefaBackLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 328);
            this.panel1.TabIndex = 0;
            // 
            // uEstadoTarefaBackLog
            // 
            this.uEstadoTarefaBackLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uEstadoTarefaBackLog.Estado = kanbada.EstadoTarefa.Backlog;
            this.uEstadoTarefaBackLog.Location = new System.Drawing.Point(0, 0);
            this.uEstadoTarefaBackLog.Name = "uEstadoTarefaBackLog";
            this.uEstadoTarefaBackLog.Size = new System.Drawing.Size(110, 328);
            this.uEstadoTarefaBackLog.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(110, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 328);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uEstadoTarefaDone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(430, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 328);
            this.panel2.TabIndex = 2;
            // 
            // uEstadoTarefaDone
            // 
            this.uEstadoTarefaDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uEstadoTarefaDone.Estado = kanbada.EstadoTarefa.Done;
            this.uEstadoTarefaDone.Location = new System.Drawing.Point(0, 0);
            this.uEstadoTarefaDone.Name = "uEstadoTarefaDone";
            this.uEstadoTarefaDone.Size = new System.Drawing.Size(115, 328);
            this.uEstadoTarefaDone.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(425, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 328);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uEstadoTarefaVerifying);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(320, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 328);
            this.panel3.TabIndex = 4;
            // 
            // uEstadoTarefaVerifying
            // 
            this.uEstadoTarefaVerifying.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uEstadoTarefaVerifying.Estado = kanbada.EstadoTarefa.Verifying;
            this.uEstadoTarefaVerifying.Location = new System.Drawing.Point(0, 0);
            this.uEstadoTarefaVerifying.Name = "uEstadoTarefaVerifying";
            this.uEstadoTarefaVerifying.Size = new System.Drawing.Size(105, 328);
            this.uEstadoTarefaVerifying.TabIndex = 0;
            // 
            // splitter3
            // 
            this.splitter3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter3.Location = new System.Drawing.Point(315, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(5, 328);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.uEstadoTarefaDoing);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(115, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(101, 328);
            this.panel4.TabIndex = 6;
            // 
            // uEstadoTarefaDoing
            // 
            this.uEstadoTarefaDoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uEstadoTarefaDoing.Estado = kanbada.EstadoTarefa.Doing;
            this.uEstadoTarefaDoing.Location = new System.Drawing.Point(0, 0);
            this.uEstadoTarefaDoing.Name = "uEstadoTarefaDoing";
            this.uEstadoTarefaDoing.Size = new System.Drawing.Size(101, 328);
            this.uEstadoTarefaDoing.TabIndex = 0;
            // 
            // splitter4
            // 
            this.splitter4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter4.Location = new System.Drawing.Point(216, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(5, 328);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.uEstadoTarefaToVerify);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(221, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(94, 328);
            this.panel5.TabIndex = 8;
            // 
            // uEstadoTarefaToVerify
            // 
            this.uEstadoTarefaToVerify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uEstadoTarefaToVerify.Estado = kanbada.EstadoTarefa.ToVerify;
            this.uEstadoTarefaToVerify.Location = new System.Drawing.Point(0, 0);
            this.uEstadoTarefaToVerify.Name = "uEstadoTarefaToVerify";
            this.uEstadoTarefaToVerify.Size = new System.Drawing.Size(94, 328);
            this.uEstadoTarefaToVerify.TabIndex = 0;
            // 
            // UKanbanBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "UKanbanBoard";
            this.Size = new System.Drawing.Size(545, 328);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter2;
        private UEstadoTarefa uEstadoTarefaBackLog;
        private UEstadoTarefa uEstadoTarefaDone;
        private System.Windows.Forms.Panel panel3;
        private UEstadoTarefa uEstadoTarefaVerifying;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel panel4;
        private UEstadoTarefa uEstadoTarefaDoing;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Panel panel5;
        private UEstadoTarefa uEstadoTarefaToVerify;


    }
}
