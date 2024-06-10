namespace FootBallManager
{
    partial class Form3
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            btnOpenChat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(387, 59);
            label4.Name = "label4";
            label4.Size = new Size(127, 38);
            label4.TabIndex = 9;
            label4.Text = "Kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(487, 9);
            label3.Name = "label3";
            label3.Size = new Size(43, 50);
            label3.TabIndex = 8;
            label3.Text = "3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(370, 9);
            label2.Name = "label2";
            label2.Size = new Size(43, 50);
            label2.TabIndex = 7;
            label2.Text = "3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(433, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 50);
            label1.TabIndex = 6;
            label1.Text = "-";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(283, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 62);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(559, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 62);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(2, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 416);
            panel1.TabIndex = 12;
            // 
            // btnOpenChat
            // 
            btnOpenChat.Location = new Point(393, 112);
            btnOpenChat.Name = "btnOpenChat";
            btnOpenChat.Size = new Size(114, 29);
            btnOpenChat.TabIndex = 15;
            btnOpenChat.Text = "Truyền thông";
            btnOpenChat.UseVisualStyleBackColor = true;
            btnOpenChat.Click += BtnOpenChat_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnOpenChat);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button btnOpenChat;
    }
}