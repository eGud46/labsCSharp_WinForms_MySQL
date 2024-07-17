namespace KursDBWinForms
{
    partial class LoginForm
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
            panel1 = new Panel();
            ExitButton = new Button();
            LoginButton = new Button();
            PasswordTextBox = new TextBox();
            LoginTextBox = new TextBox();
            PasswordText = new Label();
            LoginText = new Label();
            panel2 = new Panel();
            AuthText = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 42, 52);
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Controls.Add(LoginTextBox);
            panel1.Controls.Add(PasswordText);
            panel1.Controls.Add(LoginText);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 235);
            panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitButton.Location = new Point(148, 177);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(111, 23);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.ForeColor = Color.FromArgb(37, 42, 52);
            LoginButton.Location = new Point(31, 177);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(111, 23);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Cursor = Cursors.IBeam;
            PasswordTextBox.Location = new Point(31, 148);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(228, 23);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LoginTextBox.Cursor = Cursors.IBeam;
            LoginTextBox.Location = new Point(31, 87);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(228, 23);
            LoginTextBox.TabIndex = 3;
            // 
            // PasswordText
            // 
            PasswordText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordText.ForeColor = Color.FromArgb(234, 234, 234);
            PasswordText.Location = new Point(95, 113);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(96, 32);
            PasswordText.TabIndex = 2;
            PasswordText.Text = "Пароль";
            PasswordText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginText
            // 
            LoginText.Dock = DockStyle.Top;
            LoginText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LoginText.ForeColor = Color.FromArgb(234, 234, 234);
            LoginText.Location = new Point(0, 48);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(293, 32);
            LoginText.TabIndex = 1;
            LoginText.Text = "Логин";
            LoginText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(234, 234, 234);
            panel2.Controls.Add(AuthText);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 48);
            panel2.TabIndex = 0;
            // 
            // AuthText
            // 
            AuthText.Anchor = AnchorStyles.None;
            AuthText.Font = new Font("Cascadia Code", 24F, FontStyle.Regular, GraphicsUnit.Point);
            AuthText.ForeColor = Color.FromArgb(37, 42, 52);
            AuthText.Location = new Point(31, 1);
            AuthText.Name = "AuthText";
            AuthText.Size = new Size(228, 43);
            AuthText.TabIndex = 0;
            AuthText.Text = "Авторизация";
            AuthText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 235);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label AuthText;
        private TextBox PasswordTextBox;
        private TextBox LoginTextBox;
        private Label PasswordText;
        private Label LoginText;
        private Button LoginButton;
        private Button ExitButton;
    }
}