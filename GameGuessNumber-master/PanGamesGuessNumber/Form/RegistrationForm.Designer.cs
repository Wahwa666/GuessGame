namespace PanGamesGuessNumber
{
    partial class RegistrationForm
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
            regostrationLabel = new Label();
            pictureBox3 = new PictureBox();
            passwordRepeatTextBox = new TextBox();
            repeatLabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            passwordTxtBox = new TextBox();
            loginTxtBox = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // regostrationLabel
            // 
            regostrationLabel.Font = new Font("Bad Script", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            regostrationLabel.ForeColor = SystemColors.ButtonFace;
            regostrationLabel.Location = new Point(215, 350);
            regostrationLabel.Name = "regostrationLabel";
            regostrationLabel.Size = new Size(158, 25);
            regostrationLabel.TabIndex = 23;
            regostrationLabel.Text = "РЕГИСТРАЦИЯ";
            regostrationLabel.Click += regostrationLabel_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user_icon;
            pictureBox3.Location = new Point(132, 281);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // passwordRepeatTextBox
            // 
            passwordRepeatTextBox.Location = new Point(190, 306);
            passwordRepeatTextBox.Name = "passwordRepeatTextBox";
            passwordRepeatTextBox.Size = new Size(232, 27);
            passwordRepeatTextBox.TabIndex = 21;
            passwordRepeatTextBox.UseSystemPasswordChar = true;
            // 
            // repeatLabel
            // 
            repeatLabel.Font = new Font("Bad Script", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            repeatLabel.ForeColor = SystemColors.ButtonFace;
            repeatLabel.Location = new Point(215, 278);
            repeatLabel.Name = "repeatLabel";
            repeatLabel.Size = new Size(183, 25);
            repeatLabel.TabIndex = 20;
            repeatLabel.Text = "Введите пароль повторно";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_icon;
            pictureBox2.Location = new Point(132, 215);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.password_icon;
            pictureBox1.Location = new Point(132, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Location = new Point(190, 240);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(232, 27);
            passwordTxtBox.TabIndex = 17;
            passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // loginTxtBox
            // 
            loginTxtBox.Location = new Point(190, 164);
            loginTxtBox.Name = "loginTxtBox";
            loginTxtBox.Size = new Size(232, 27);
            loginTxtBox.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 125);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Bad Script", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(582, 125);
            label1.TabIndex = 0;
            label1.Text = "УГАДАЙ ЧИСЛО";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(582, 453);
            Controls.Add(regostrationLabel);
            Controls.Add(pictureBox3);
            Controls.Add(passwordRepeatTextBox);
            Controls.Add(repeatLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(passwordTxtBox);
            Controls.Add(loginTxtBox);
            Controls.Add(panel1);
            Name = "RegistrationForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label regostrationLabel;
        private PictureBox pictureBox3;
        private TextBox passwordRepeatTextBox;
        private Label repeatLabel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox passwordTxtBox;
        private TextBox loginTxtBox;
        private Panel panel1;
        private Label label1;
    }
}