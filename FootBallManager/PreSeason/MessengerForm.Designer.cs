namespace FootBallManager
{
    partial class MessengerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessengerForm));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            flowLayoutPanelComments = new FlowLayoutPanel();
            textBoxComment = new TextBox();
            button1 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(553, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 62);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(277, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 62);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(381, 52);
            label4.Name = "label4";
            label4.Size = new Size(127, 38);
            label4.TabIndex = 15;
            label4.Text = "Kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(481, 2);
            label3.Name = "label3";
            label3.Size = new Size(43, 50);
            label3.TabIndex = 14;
            label3.Text = "3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(364, 2);
            label2.Name = "label2";
            label2.Size = new Size(43, 50);
            label2.TabIndex = 13;
            label2.Text = "3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(427, 2);
            label1.Name = "label1";
            label1.Size = new Size(37, 50);
            label1.TabIndex = 12;
            label1.Text = "-";
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(22, 159);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(502, 292);
            axWindowsMediaPlayer1.TabIndex = 18;
            // 
            // flowLayoutPanelComments
            // 
            flowLayoutPanelComments.Location = new Point(553, 109);
            flowLayoutPanelComments.Name = "flowLayoutPanelComments";
            flowLayoutPanelComments.Size = new Size(349, 435);
            flowLayoutPanelComments.TabIndex = 19;
            // 
            // textBoxComment
            // 
            textBoxComment.Location = new Point(553, 559);
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(287, 27);
            textBoxComment.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(846, 550);
            button1.Name = "button1";
            button1.Size = new Size(56, 44);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonSubmit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 454);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 22;
            label5.Text = "Official Highlight";
            // 
            // MessengerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBoxComment);
            Controls.Add(flowLayoutPanelComments);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MessengerForm";
            Text = "MessengerForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private FlowLayoutPanel flowLayoutPanelComments;
        private TextBox textBoxComment;
        private Button button1;
        private Label label5;
    }
}