namespace DesktopMultiChat
{
    partial class AddRoomForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.memberBox = new System.Windows.Forms.RichTextBox();
            this.roomNameBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thành Viên (Copy ID rồi dán vào dây)";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.saveBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.saveBtn.Location = new System.Drawing.Point(52, 154);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(106, 30);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // memberBox
            // 
            this.memberBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.memberBox.Location = new System.Drawing.Point(52, 100);
            this.memberBox.Multiline = false;
            this.memberBox.Name = "memberBox";
            this.memberBox.Size = new System.Drawing.Size(345, 31);
            this.memberBox.TabIndex = 5;
            this.memberBox.Text = "";
            this.memberBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MemberBox_KeyDown);
            // 
            // roomNameBox
            // 
            this.roomNameBox.Location = new System.Drawing.Point(52, 42);
            this.roomNameBox.Name = "roomNameBox";
            this.roomNameBox.Size = new System.Drawing.Size(345, 28);
            this.roomNameBox.TabIndex = 6;
            this.roomNameBox.Text = "";
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 235);
            this.Controls.Add(this.roomNameBox);
            this.Controls.Add(this.memberBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRoomForm";
            this.Text = "AddRoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RichTextBox memberBox;
        private System.Windows.Forms.RichTextBox roomNameBox;
    }
}