namespace kanbada
{
    partial class WMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbOrganiza = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uKanbanBoard = new kanbada.UKanbanBoard();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbOrganiza});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(627, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbOrganiza
            // 
            this.tbOrganiza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOrganiza.Image = ((System.Drawing.Image)(resources.GetObject("tbOrganiza.Image")));
            this.tbOrganiza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOrganiza.Name = "tbOrganiza";
            this.tbOrganiza.Size = new System.Drawing.Size(23, 22);
            this.tbOrganiza.Text = "toolStripButton1";
            this.tbOrganiza.Click += new System.EventHandler(this.tbOrganiza_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 35);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uKanbanBoard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 245);
            this.panel2.TabIndex = 3;
            // 
            // uKanbanBoard
            // 
            this.uKanbanBoard.BackColor = System.Drawing.SystemColors.Window;
            this.uKanbanBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uKanbanBoard.Enoding = false;
            this.uKanbanBoard.Location = new System.Drawing.Point(0, 0);
            this.uKanbanBoard.Name = "uKanbanBoard";
            this.uKanbanBoard.Size = new System.Drawing.Size(627, 245);
            this.uKanbanBoard.Sprint = null;
            this.uKanbanBoard.TabIndex = 0;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // WMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 305);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WMain";
            this.Text = "Kanbada!";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbOrganiza;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UKanbanBoard uKanbanBoard;
        private System.Windows.Forms.NotifyIcon notifyIcon;

    }
}