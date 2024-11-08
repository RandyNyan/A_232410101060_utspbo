namespace UTS_PBO_Praktikum
{
    partial class Login
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
            Label_Username = new Label();
            Label_Password = new Label();
            TextBoxUsername = new TextBox();
            TextBoxPassword = new TextBox();
            Button_Login = new Button();
            ButtonExit = new Button();
            SuspendLayout();
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.BackColor = Color.Transparent;
            Label_Username.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Label_Username.ForeColor = Color.FromArgb(249, 249, 249);
            Label_Username.Location = new Point(511, 174);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(104, 28);
            Label_Username.TabIndex = 0;
            Label_Username.Text = "Username";
            // 
            // Label_Password
            // 
            Label_Password.AutoSize = true;
            Label_Password.BackColor = Color.Transparent;
            Label_Password.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Label_Password.ForeColor = Color.FromArgb(249, 249, 249);
            Label_Password.Location = new Point(511, 257);
            Label_Password.Name = "Label_Password";
            Label_Password.Size = new Size(97, 28);
            Label_Password.TabIndex = 1;
            Label_Password.Text = "Password";
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.BackColor = Color.FromArgb(109, 106, 117);
            TextBoxUsername.BorderStyle = BorderStyle.None;
            TextBoxUsername.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            TextBoxUsername.ForeColor = Color.FromArgb(249, 249, 249);
            TextBoxUsername.Location = new Point(518, 207);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(250, 24);
            TextBoxUsername.TabIndex = 2;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.BackColor = Color.FromArgb(109, 106, 117);
            TextBoxPassword.BorderStyle = BorderStyle.None;
            TextBoxPassword.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            TextBoxPassword.ForeColor = Color.FromArgb(249, 249, 249);
            TextBoxPassword.Location = new Point(518, 288);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(250, 24);
            TextBoxPassword.TabIndex = 3;
            // 
            // Button_Login
            // 
            Button_Login.BackColor = Color.FromArgb(127, 200, 248);
            Button_Login.FlatAppearance.BorderSize = 0;
            Button_Login.FlatStyle = FlatStyle.Flat;
            Button_Login.Font = new Font("Anton", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Login.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Login.Location = new Point(691, 359);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new Size(77, 40);
            Button_Login.TabIndex = 4;
            Button_Login.Text = "Login";
            Button_Login.UseVisualStyleBackColor = true;
            Button_Login.Click += this.Button_Login_Click;
            // 
            // ButtonExit
            // 
            ButtonExit.BackColor = Color.FromArgb(127, 200, 248);
            ButtonExit.FlatAppearance.BorderSize = 0;
            ButtonExit.FlatStyle = FlatStyle.Flat;
            ButtonExit.Font = new Font("Anton", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonExit.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonExit.Location = new Point(597, 359);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(77, 42);
            ButtonExit.TabIndex = 5;
            ButtonExit.Text = "Exit";
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += this.ButtonExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonExit);
            Controls.Add(Button_Login);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxUsername);
            Controls.Add(Label_Password);
            Controls.Add(Label_Username);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Username;
        private Label Label_Password;
        private TextBox TextBoxUsername;
        private TextBox TextBoxPassword;
        private Button Button_Login;
        private Button ButtonExit;
    }
}
