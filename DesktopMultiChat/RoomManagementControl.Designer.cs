namespace DesktopMultiChat
{
    partial class RoomManagementControl
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewRoom = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.viewAccount = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.roomRadio = new System.Windows.Forms.RadioButton();
            this.accountRadio = new System.Windows.Forms.RadioButton();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewRoom)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAccount)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.66793F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.33207F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(795, 497);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewRoom);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 242);
            this.panel1.TabIndex = 2;
            // 
            // viewRoom
            // 
            this.viewRoom.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewRoom.Location = new System.Drawing.Point(0, 0);
            this.viewRoom.Name = "viewRoom";
            this.viewRoom.RowHeadersWidth = 51;
            this.viewRoom.RowTemplate.Height = 24;
            this.viewRoom.Size = new System.Drawing.Size(595, 242);
            this.viewRoom.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(595, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 242);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.restoreBtn);
            this.panel5.Controls.Add(this.deleteBtn);
            this.panel5.Controls.Add(this.editBtn);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 242);
            this.panel5.TabIndex = 1;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteBtn.Location = new System.Drawing.Point(55, 96);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(91, 27);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.editBtn.ForeColor = System.Drawing.Color.MediumPurple;
            this.editBtn.Location = new System.Drawing.Point(55, 63);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(91, 27);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Sửa";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(55, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.addBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.addBtn.Location = new System.Drawing.Point(55, 17);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(91, 27);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.viewAccount);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 243);
            this.panel3.TabIndex = 3;
            // 
            // viewAccount
            // 
            this.viewAccount.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.viewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAccount.Location = new System.Drawing.Point(383, 0);
            this.viewAccount.Name = "viewAccount";
            this.viewAccount.RowHeadersWidth = 51;
            this.viewAccount.RowTemplate.Height = 24;
            this.viewAccount.Size = new System.Drawing.Size(406, 243);
            this.viewAccount.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.roomRadio);
            this.panel4.Controls.Add(this.accountRadio);
            this.panel4.Controls.Add(this.searchBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(383, 243);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lưu ý: nhấp vào ô để chỉnh sửa phòng";
            // 
            // roomRadio
            // 
            this.roomRadio.AutoSize = true;
            this.roomRadio.Location = new System.Drawing.Point(21, 98);
            this.roomRadio.Name = "roomRadio";
            this.roomRadio.Size = new System.Drawing.Size(66, 20);
            this.roomRadio.TabIndex = 3;
            this.roomRadio.TabStop = true;
            this.roomRadio.Text = "phòng";
            this.roomRadio.UseVisualStyleBackColor = true;
            // 
            // accountRadio
            // 
            this.accountRadio.AutoSize = true;
            this.accountRadio.Location = new System.Drawing.Point(21, 71);
            this.accountRadio.Name = "accountRadio";
            this.accountRadio.Size = new System.Drawing.Size(82, 20);
            this.accountRadio.TabIndex = 2;
            this.accountRadio.TabStop = true;
            this.accountRadio.Text = "tài khoản";
            this.accountRadio.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.searchBox.Location = new System.Drawing.Point(94, 28);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(259, 24);
            this.searchBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "tìm kiếm:";
            // 
            // restoreBtn
            // 
            this.restoreBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.restoreBtn.ForeColor = System.Drawing.Color.Blue;
            this.restoreBtn.Location = new System.Drawing.Point(55, 129);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(91, 27);
            this.restoreBtn.TabIndex = 3;
            this.restoreBtn.Text = "Đặt lại";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // RoomManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "RoomManagementControl";
            this.Size = new System.Drawing.Size(795, 497);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewRoom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewAccount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView viewRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView viewAccount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton roomRadio;
        private System.Windows.Forms.RadioButton accountRadio;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button restoreBtn;
    }
}
