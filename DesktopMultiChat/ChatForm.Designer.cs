namespace DesktopMultiChat
{
    partial class ChatForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.showList = new System.Windows.Forms.ListBox();
            this.search = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.roomBtn = new System.Windows.Forms.Button();
            this.accountBtn = new System.Windows.Forms.Button();
            this.conversationBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendImgBtn = new System.Windows.Forms.Button();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.sendFileBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.showMess = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 623);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.showList);
            this.panel4.Controls.Add(this.search);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 530);
            this.panel4.TabIndex = 2;
            // 
            // showList
            // 
            this.showList.Dock = System.Windows.Forms.DockStyle.Top;
            this.showList.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showList.FormattingEnabled = true;
            this.showList.ItemHeight = 27;
            this.showList.Location = new System.Drawing.Point(0, 0);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(269, 490);
            this.showList.TabIndex = 2;
            this.showList.SelectedIndexChanged += new System.EventHandler(this.showList_SelectedIndexChanged_1);
            // 
            // search
            // 
            this.search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.search.Location = new System.Drawing.Point(0, 503);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(269, 27);
            this.search.TabIndex = 0;
            this.search.TabStop = false;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.roomBtn);
            this.panel3.Controls.Add(this.accountBtn);
            this.panel3.Controls.Add(this.conversationBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 93);
            this.panel3.TabIndex = 0;
            // 
            // roomBtn
            // 
            this.roomBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.roomBtn.Location = new System.Drawing.Point(0, 60);
            this.roomBtn.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.roomBtn.Name = "roomBtn";
            this.roomBtn.Size = new System.Drawing.Size(269, 30);
            this.roomBtn.TabIndex = 2;
            this.roomBtn.Text = "Nhóm";
            this.roomBtn.UseVisualStyleBackColor = true;
            this.roomBtn.Click += new System.EventHandler(this.roomBtn_Click);
            // 
            // accountBtn
            // 
            this.accountBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.accountBtn.Location = new System.Drawing.Point(0, 30);
            this.accountBtn.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(269, 30);
            this.accountBtn.TabIndex = 1;
            this.accountBtn.Text = "Thành viên";
            this.accountBtn.UseVisualStyleBackColor = true;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // conversationBtn
            // 
            this.conversationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.conversationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.conversationBtn.Location = new System.Drawing.Point(0, 0);
            this.conversationBtn.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.conversationBtn.Name = "conversationBtn";
            this.conversationBtn.Size = new System.Drawing.Size(269, 30);
            this.conversationBtn.TabIndex = 0;
            this.conversationBtn.Text = "Trò chuyện gần đây";
            this.conversationBtn.UseVisualStyleBackColor = true;
            this.conversationBtn.Click += new System.EventHandler(this.conversationBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.showMess);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(362, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 623);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.Controls.Add(this.nameLabel);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.sendImgBtn);
            this.panel6.Controls.Add(this.inputTextbox);
            this.panel6.Controls.Add(this.sendFileBtn);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(924, 121);
            this.panel6.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nameLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.nameLabel.Location = new System.Drawing.Point(169, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 25);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "none";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đang nhắn tin với: ";
            // 
            // sendImgBtn
            // 
            this.sendImgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sendImgBtn.Location = new System.Drawing.Point(603, 73);
            this.sendImgBtn.Name = "sendImgBtn";
            this.sendImgBtn.Size = new System.Drawing.Size(123, 27);
            this.sendImgBtn.TabIndex = 7;
            this.sendImgBtn.Text = "Gửi hình...";
            this.sendImgBtn.UseVisualStyleBackColor = true;
            this.sendImgBtn.Click += new System.EventHandler(this.sendImgBtn_Click);
            // 
            // inputTextbox
            // 
            this.inputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.inputTextbox.Location = new System.Drawing.Point(146, 73);
            this.inputTextbox.Multiline = true;
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(303, 27);
            this.inputTextbox.TabIndex = 6;
            this.inputTextbox.TextChanged += new System.EventHandler(this.inputTextbox_TextChanged);
            this.inputTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextbox_KeyDown);
            // 
            // sendFileBtn
            // 
            this.sendFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sendFileBtn.Location = new System.Drawing.Point(468, 73);
            this.sendFileBtn.Name = "sendFileBtn";
            this.sendFileBtn.Size = new System.Drawing.Size(116, 27);
            this.sendFileBtn.TabIndex = 4;
            this.sendFileBtn.Text = "Gửi File...";
            this.sendFileBtn.UseVisualStyleBackColor = true;
            this.sendFileBtn.Click += new System.EventHandler(this.sendFileBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập tin nhắn: ";
            // 
            // showMess
            // 
            this.showMess.BackColor = System.Drawing.SystemColors.Window;
            this.showMess.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.showMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.showMess.ForeColor = System.Drawing.SystemColors.WindowText;
            this.showMess.Location = new System.Drawing.Point(0, 119);
            this.showMess.MaximumSize = new System.Drawing.Size(1000, 616);
            this.showMess.Name = "showMess";
            this.showMess.ReadOnly = true;
            this.showMess.Size = new System.Drawing.Size(882, 464);
            this.showMess.TabIndex = 0;
            this.showMess.Text = "";
            this.showMess.TextChanged += new System.EventHandler(this.showMess_TextChanged);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button roomBtn;
        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.Button conversationBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ListBox showList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendImgBtn;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Button sendFileBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox showMess;
        private System.Windows.Forms.Label nameLabel;
    }
}