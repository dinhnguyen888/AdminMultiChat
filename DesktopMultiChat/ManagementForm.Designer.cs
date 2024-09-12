namespace DesktopMultiChat
{
    partial class ManagementForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuTinhNang = new System.Windows.Forms.MenuStrip();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuTinhNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuTinhNang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 33);
            this.panel1.TabIndex = 0;
            // 
            // menuTinhNang
            // 
            this.menuTinhNang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTinhNang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.quảnLýPhòngToolStripMenuItem});
            this.menuTinhNang.Location = new System.Drawing.Point(0, 0);
            this.menuTinhNang.Name = "menuTinhNang";
            this.menuTinhNang.Size = new System.Drawing.Size(777, 28);
            this.menuTinhNang.TabIndex = 1;
            this.menuTinhNang.Text = "menuStrip1";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem_Click);
          
            // 
            // quảnLýPhòngToolStripMenuItem
            // 
            this.quảnLýPhòngToolStripMenuItem.Name = "quảnLýPhòngToolStripMenuItem";
            this.quảnLýPhòngToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.quảnLýPhòngToolStripMenuItem.Text = "Quản lý nhóm";
            this.quảnLýPhòngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhòngToolStripMenuItem_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.Location = new System.Drawing.Point(0, 33);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(777, 417);
            this.viewPanel.TabIndex = 1;

            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ManagementForm";
            this.Text = "ManagementForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuTinhNang.ResumeLayout(false);
            this.menuTinhNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuTinhNang;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngToolStripMenuItem;
        private System.Windows.Forms.Panel viewPanel;
    }
}