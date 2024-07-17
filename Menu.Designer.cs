namespace KursDBWinForms
{
    partial class Menu
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
            MenuText = new Label();
            AddDocksButton = new Button();
            AddDocksStatus = new Button();
            AddAffairsPeople = new Button();
            OutDateButton = new Button();
            OutPeopleButton = new Button();
            OutAffairsButton = new Button();
            panel2 = new Panel();
            BackToLoginButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 42, 52);
            panel1.Controls.Add(MenuText);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 51);
            panel1.TabIndex = 0;
            // 
            // MenuText
            // 
            MenuText.Dock = DockStyle.Fill;
            MenuText.Font = new Font("Cascadia Code", 24F, FontStyle.Regular, GraphicsUnit.Point);
            MenuText.ForeColor = Color.FromArgb(234, 234, 234);
            MenuText.Location = new Point(0, 0);
            MenuText.Name = "MenuText";
            MenuText.Size = new Size(283, 51);
            MenuText.TabIndex = 0;
            MenuText.Text = "Меню";
            MenuText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddDocksButton
            // 
            AddDocksButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddDocksButton.Location = new Point(12, 57);
            AddDocksButton.Name = "AddDocksButton";
            AddDocksButton.Size = new Size(259, 23);
            AddDocksButton.TabIndex = 1;
            AddDocksButton.Text = "DOCKS";
            AddDocksButton.UseVisualStyleBackColor = true;
            AddDocksButton.Click += AddDocksButton_Click;
            // 
            // AddDocksStatus
            // 
            AddDocksStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddDocksStatus.Location = new Point(12, 86);
            AddDocksStatus.Name = "AddDocksStatus";
            AddDocksStatus.Size = new Size(259, 23);
            AddDocksStatus.TabIndex = 2;
            AddDocksStatus.Text = "DOCKS - DOCKSSTATUS";
            AddDocksStatus.UseVisualStyleBackColor = true;
            AddDocksStatus.Click += AddDocksStatus_Click;
            // 
            // AddAffairsPeople
            // 
            AddAffairsPeople.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddAffairsPeople.Location = new Point(12, 115);
            AddAffairsPeople.Name = "AddAffairsPeople";
            AddAffairsPeople.Size = new Size(259, 23);
            AddAffairsPeople.TabIndex = 3;
            AddAffairsPeople.Text = "AFFAIRS-PEOPLE";
            AddAffairsPeople.UseVisualStyleBackColor = true;
            AddAffairsPeople.Click += AddAffairsPeople_Click;
            // 
            // OutDateButton
            // 
            OutDateButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OutDateButton.Location = new Point(12, 144);
            OutDateButton.Name = "OutDateButton";
            OutDateButton.Size = new Size(259, 23);
            OutDateButton.TabIndex = 4;
            OutDateButton.Text = "DATE";
            OutDateButton.UseVisualStyleBackColor = true;
            OutDateButton.Click += OutDateButton_Click;
            // 
            // OutPeopleButton
            // 
            OutPeopleButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OutPeopleButton.Location = new Point(12, 173);
            OutPeopleButton.Name = "OutPeopleButton";
            OutPeopleButton.Size = new Size(259, 23);
            OutPeopleButton.TabIndex = 5;
            OutPeopleButton.Text = "PEOPLE";
            OutPeopleButton.UseVisualStyleBackColor = true;
            OutPeopleButton.Click += OutPeopleButton_Click;
            // 
            // OutAffairsButton
            // 
            OutAffairsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OutAffairsButton.Location = new Point(12, 202);
            OutAffairsButton.Name = "OutAffairsButton";
            OutAffairsButton.Size = new Size(259, 23);
            OutAffairsButton.TabIndex = 6;
            OutAffairsButton.Text = "AFFAIRS";
            OutAffairsButton.UseVisualStyleBackColor = true;
            OutAffairsButton.Click += OutAffairsButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(37, 42, 52);
            panel2.Location = new Point(0, 231);
            panel2.Name = "panel2";
            panel2.Size = new Size(283, 10);
            panel2.TabIndex = 7;
            // 
            // BackToLoginButton
            // 
            BackToLoginButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BackToLoginButton.Location = new Point(12, 247);
            BackToLoginButton.Name = "BackToLoginButton";
            BackToLoginButton.Size = new Size(259, 23);
            BackToLoginButton.TabIndex = 8;
            BackToLoginButton.Text = "Назад";
            BackToLoginButton.UseVisualStyleBackColor = true;
            BackToLoginButton.Click += BackToLoginButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(283, 276);
            Controls.Add(BackToLoginButton);
            Controls.Add(panel2);
            Controls.Add(OutAffairsButton);
            Controls.Add(OutPeopleButton);
            Controls.Add(OutDateButton);
            Controls.Add(AddAffairsPeople);
            Controls.Add(AddDocksStatus);
            Controls.Add(AddDocksButton);
            Controls.Add(panel1);
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label MenuText;
        private Button AddDocksButton;
        private Button AddDocksStatus;
        private Button AddAffairsPeople;
        private Button OutDateButton;
        private Button OutPeopleButton;
        private Button OutAffairsButton;
        private Panel panel2;
        private Button BackToLoginButton;
    }
}