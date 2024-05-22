namespace FootBallManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            map1 = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            imgTeam1 = new PictureBox();
            Team1 = new ComboBox();
            panel2 = new Panel();
            panel4 = new Panel();
            map2 = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            imgTeam2 = new PictureBox();
            Team2 = new ComboBox();
            Start = new Button();
            btnPredict = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgTeam1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgTeam2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(map1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(imgTeam1);
            panel1.Controls.Add(Team1);
            panel1.Location = new Point(14, 2);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 597);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(7, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(383, 458);
            panel3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 566);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 5;
            label5.Text = "HLV Erik Ten hag";
            // 
            // map1
            // 
            map1.FormattingEnabled = true;
            map1.Location = new Point(126, 65);
            map1.Margin = new Padding(3, 4, 3, 4);
            map1.Name = "map1";
            map1.Size = new Size(209, 28);
            map1.TabIndex = 4;
            map1.SelectedIndexChanged += map1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 65);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 3;
            label3.Text = "Chọn sơ đồ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 8);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Chọn đội 1";
            // 
            // imgTeam1
            // 
            imgTeam1.BackgroundImage = (Image)resources.GetObject("imgTeam1.BackgroundImage");
            imgTeam1.BackgroundImageLayout = ImageLayout.Stretch;
            imgTeam1.Location = new Point(342, 4);
            imgTeam1.Margin = new Padding(3, 4, 3, 4);
            imgTeam1.Name = "imgTeam1";
            imgTeam1.Size = new Size(49, 52);
            imgTeam1.TabIndex = 1;
            imgTeam1.TabStop = false;
            // 
            // Team1
            // 
            Team1.FormattingEnabled = true;
            Team1.Location = new Point(126, 4);
            Team1.Margin = new Padding(3, 4, 3, 4);
            Team1.Name = "Team1";
            Team1.Size = new Size(209, 28);
            Team1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(map2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(imgTeam2);
            panel2.Controls.Add(Team2);
            panel2.Location = new Point(506, 2);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 597);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(8, 105);
            panel4.Name = "panel4";
            panel4.Size = new Size(383, 458);
            panel4.TabIndex = 7;
            // 
            // map2
            // 
            map2.FormattingEnabled = true;
            map2.Location = new Point(58, 65);
            map2.Margin = new Padding(3, 4, 3, 4);
            map2.Name = "map2";
            map2.Size = new Size(203, 28);
            map2.TabIndex = 39;
            map2.SelectedIndexChanged += map2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 566);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 6;
            label6.Text = "HLV Pep Guardiola";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 65);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 4;
            label4.Text = "Chọn sơ đồ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 12);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Chọn đội 2";
            // 
            // imgTeam2
            // 
            imgTeam2.BackgroundImage = (Image)resources.GetObject("imgTeam2.BackgroundImage");
            imgTeam2.BackgroundImageLayout = ImageLayout.Stretch;
            imgTeam2.Location = new Point(3, 4);
            imgTeam2.Margin = new Padding(3, 4, 3, 4);
            imgTeam2.Name = "imgTeam2";
            imgTeam2.Size = new Size(49, 52);
            imgTeam2.TabIndex = 2;
            imgTeam2.TabStop = false;
            // 
            // Team2
            // 
            Team2.FormattingEnabled = true;
            Team2.Location = new Point(58, 4);
            Team2.Margin = new Padding(3, 4, 3, 4);
            Team2.Name = "Team2";
            Team2.Size = new Size(203, 28);
            Team2.TabIndex = 1;
            // 
            // Start
            // 
            Start.Location = new Point(414, 258);
            Start.Margin = new Padding(3, 4, 3, 4);
            Start.Name = "Start";
            Start.Size = new Size(86, 31);
            Start.TabIndex = 2;
            Start.Text = "Đấu";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // btnPredict
            // 
            btnPredict.Location = new Point(414, 311);
            btnPredict.Margin = new Padding(3, 4, 3, 4);
            btnPredict.Name = "btnPredict";
            btnPredict.Size = new Size(86, 31);
            btnPredict.TabIndex = 3;
            btnPredict.Text = "Dự đoán";
            btnPredict.UseVisualStyleBackColor = true;
            btnPredict.Click += Predict_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnPredict);
            Controls.Add(Start);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgTeam1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgTeam2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox imgTeam1;
        private ComboBox Team1;
        private PictureBox imgTeam2;
        private ComboBox Team2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox map1;
        private Label label6;
        private ComboBox Map2;
        private Button Start;
        private ComboBox map2;
        private Panel panel3;
        private Panel panel4;
        private Button btnPredict;
    }
}
