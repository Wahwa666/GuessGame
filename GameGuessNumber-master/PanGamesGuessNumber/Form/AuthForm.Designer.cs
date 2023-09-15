namespace PanGamesGuessNumber
{
    partial class AuthForm
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
            panel1 = new Panel();
            label1 = new Label();
            loginTxtBox = new TextBox();
            passwordTxtBox = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            authorizationLabel = new Label();
            registrationLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 125);
            panel1.TabIndex = 0;
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
            // loginTxtBox
            // 
            loginTxtBox.Location = new Point(195, 163);
            loginTxtBox.Name = "loginTxtBox";
            loginTxtBox.Size = new Size(232, 27);
            loginTxtBox.TabIndex = 2;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Location = new Point(195, 239);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(232, 27);
            passwordTxtBox.TabIndex = 3;
            passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.password_icon;
            pictureBox1.Location = new Point(137, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_icon;
            pictureBox2.Location = new Point(137, 214);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 93);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Bad Script", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(193, 0);
            label2.Name = "label2";
            label2.Size = new Size(389, 93);
            label2.TabIndex = 9;
            label2.Text = "Если вы тут впервые, введите логин и пароль, а затем нажмите кнопку регистрация";
            label2.TextAlign = ContentAlignment.BottomRight;
            // 
            // authorizationLabel
            // 
            authorizationLabel.Font = new Font("Bad Script", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            authorizationLabel.ForeColor = SystemColors.ButtonFace;
            authorizationLabel.Location = new Point(181, 291);
            authorizationLabel.Name = "authorizationLabel";
            authorizationLabel.Size = new Size(82, 25);
            authorizationLabel.TabIndex = 9;
            authorizationLabel.Text = "ВОЙТИ";
            authorizationLabel.Click += authorizationLabel_Click;
            // 
            // registrationLabel
            // 
            registrationLabel.Font = new Font("Bad Script", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            registrationLabel.ForeColor = SystemColors.ButtonFace;
            registrationLabel.Location = new Point(269, 291);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(158, 25);
            registrationLabel.TabIndex = 10;
            registrationLabel.Text = "РЕГИСТРАЦИЯ";
            registrationLabel.Click += registrationLabel_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(582, 453);
            Controls.Add(registrationLabel);
            Controls.Add(authorizationLabel);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(passwordTxtBox);
            Controls.Add(loginTxtBox);
            Controls.Add(panel1);
            Name = "AuthForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox loginTxtBox;
        private TextBox passwordTxtBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label2;
        private Label authorizationLabel;
        private Label registrationLabel;
    }
}