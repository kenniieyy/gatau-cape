namespace UAS_PEMVIS
{
    partial class FormLogin
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
            panelKiri = new Panel();
            pictureBoxLogin = new PictureBox();
            panelLogin = new Panel();
            labelUsername = new Label();
            label1 = new Label();
            buttonLogin = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            panelKiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelKiri
            // 
            panelKiri.BackColor = Color.CadetBlue;
            panelKiri.Controls.Add(pictureBoxLogin);
            panelKiri.Location = new Point(-2, 0);
            panelKiri.Name = "panelKiri";
            panelKiri.Size = new Size(229, 451);
            panelKiri.TabIndex = 0;
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = Properties.Resources.gambar_login;
            pictureBoxLogin.Location = new Point(44, 156);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(124, 127);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogin.TabIndex = 0;
            pictureBoxLogin.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.CadetBlue;
            panelLogin.Controls.Add(textBoxPassword);
            panelLogin.Controls.Add(textBoxUsername);
            panelLogin.Controls.Add(buttonLogin);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(labelUsername);
            panelLogin.Location = new Point(349, 156);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(272, 198);
            panelLogin.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(17, 35);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(67, 17);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 88);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 1;
            label1.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Image = Properties.Resources.icon_login;
            buttonLogin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogin.Location = new Point(91, 137);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(92, 36);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "LOGIN";
            buttonLogin.TextAlign = ContentAlignment.MiddleRight;
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(104, 34);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "your username";
            textBoxUsername.Size = new Size(146, 23);
            textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(104, 82);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "your password";
            textBoxPassword.Size = new Size(146, 23);
            textBoxPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(409, 21);
            label2.Name = "label2";
            label2.Size = new Size(153, 27);
            label2.TabIndex = 2;
            label2.Text = "FORM LOGIN";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(panelLogin);
            Controls.Add(panelKiri);
            Name = "FormLogin";
            Text = "Login";
            panelKiri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelKiri;
        private PictureBox pictureBoxLogin;
        private Panel panelLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button buttonLogin;
        private Label label1;
        private Label labelUsername;
        private Label label2;
    }
}
