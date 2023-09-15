namespace PanGamesGuessNumber
{
    partial class MainForm
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
            GamesCountLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            StatisticsLabel = new Label();
            guessNumberTextBox = new TextBox();
            GuessLabel = new Label();
            startLabel = new Label();
            panel1 = new Panel();
            ResultLabel = new Label();
            nameLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // GamesCountLabel
            // 
            GamesCountLabel.AutoSize = true;
            GamesCountLabel.Font = new Font("Bad Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            GamesCountLabel.ForeColor = SystemColors.ButtonHighlight;
            GamesCountLabel.Location = new Point(164, 370);
            GamesCountLabel.Name = "GamesCountLabel";
            GamesCountLabel.Size = new Size(0, 45);
            GamesCountLabel.TabIndex = 16;
            GamesCountLabel.Text = user.GamesCount.ToString();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bad Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(6, 370);
            label2.Name = "label2";
            label2.Size = new Size(170, 45);
            label2.TabIndex = 15;
            label2.Text = "Количество игр:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bad Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(8, 334);
            label1.Name = "label1";
            label1.Size = new Size(111, 45);
            label1.TabIndex = 13;
            label1.Text = "Никнейм:";
            // 
            // StatisticsLabel
            // 
            StatisticsLabel.AutoSize = true;
            StatisticsLabel.Font = new Font("Bad Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            StatisticsLabel.ForeColor = SystemColors.ButtonHighlight;
            StatisticsLabel.Location = new Point(6, 289);
            StatisticsLabel.Name = "StatisticsLabel";
            StatisticsLabel.Size = new Size(125, 45);
            StatisticsLabel.TabIndex = 12;
            StatisticsLabel.Text = "Статистика";
            // 
            // guessNumberTextBox
            // 
            guessNumberTextBox.Visible = false;
            guessNumberTextBox.Location = new Point(164, 155);
            guessNumberTextBox.Name = "guessNumberTextBox";
            guessNumberTextBox.Size = new Size(227, 27);
            guessNumberTextBox.TabIndex = 11;
            // 
            // GuessLabel
            // 
            GuessLabel.Visible = false;
            GuessLabel.AutoSize = true;
            GuessLabel.Font = new Font("Bad Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            GuessLabel.ForeColor = SystemColors.ButtonFace;
            GuessLabel.Location = new Point(299, 198);
            GuessLabel.Name = "GuessLabel";
            GuessLabel.Size = new Size(92, 45);
            GuessLabel.TabIndex = 10;
            GuessLabel.Text = "Угадать";
            GuessLabel.Click += GuessLabel_Click;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Bad Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            startLabel.ForeColor = SystemColors.ButtonHighlight;
            startLabel.Location = new Point(164, 198);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(129, 45);
            startLabel.TabIndex = 9;
            startLabel.Text = "Новая игра";
            startLabel.Click += startLabel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(ResultLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 110);
            panel1.TabIndex = 17;
            // 
            // ResultLabel
            // 
            ResultLabel.Dock = DockStyle.Fill;
            ResultLabel.Font = new Font("Bad Script", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ResultLabel.ForeColor = SystemColors.ButtonFace;
            ResultLabel.Location = new Point(0, 0);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(582, 110);
            ResultLabel.TabIndex = 0;
            ResultLabel.Text = "Угадай число";
            ResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Bad Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nameLabel.ForeColor = SystemColors.ButtonHighlight;
            nameLabel.Location = new Point(116, 334);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(0, 45);
            nameLabel.TabIndex = 19;
            nameLabel.Text = user.Login;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(582, 453);
            Controls.Add(nameLabel);
            Controls.Add(panel1);
            Controls.Add(GamesCountLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StatisticsLabel);
            Controls.Add(guessNumberTextBox);
            Controls.Add(GuessLabel);
            Controls.Add(startLabel);
            Name = "MainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GamesCountLabel;
        private Label label2;
        private Label label1;
        private Label StatisticsLabel;
        private TextBox guessNumberTextBox;
        private Label GuessLabel;
        private Label startLabel;
        private Panel panel1;
        private Label ResultLabel;
        private Label nameLabel;
    }
}