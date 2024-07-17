namespace KursDBWinForms
{
    partial class PeopleForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleForm));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            textBoxAffairsId = new TextBox();
            label1 = new Label();
            textBoxFullname = new TextBox();
            label2 = new Label();
            textBoxBirthday = new TextBox();
            label3 = new Label();
            textBoxAlias = new TextBox();
            label4 = new Label();
            PeopleOutButton = new Button();
            panel1 = new Panel();
            BackToMenuButton = new Button();
            dataGridPeople = new DataGridView();
            IdPeople = new DataGridViewTextBoxColumn();
            FullnamePeople = new DataGridViewTextBoxColumn();
            BirthdayPeople = new DataGridViewTextBoxColumn();
            BiographyPeople = new DataGridViewTextBoxColumn();
            PhotoPeople = new DataGridViewImageColumn();
            PrintsPeople = new DataGridViewImageColumn();
            AliasPeople = new DataGridViewTextBoxColumn();
            CriminalRecordsPeople = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridPeople).BeginInit();
            SuspendLayout();
            // 
            // textBoxAffairsId
            // 
            textBoxAffairsId.Location = new Point(69, 12);
            textBoxAffairsId.Name = "textBoxAffairsId";
            textBoxAffairsId.Size = new Size(23, 23);
            textBoxAffairsId.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(37, 42, 52);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Affairs_Id:";
            // 
            // textBoxFullname
            // 
            textBoxFullname.Location = new Point(163, 12);
            textBoxFullname.Name = "textBoxFullname";
            textBoxFullname.Size = new Size(114, 23);
            textBoxFullname.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(37, 42, 52);
            label2.Location = new Point(98, 15);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Fullname:";
            // 
            // textBoxBirthday
            // 
            textBoxBirthday.Location = new Point(343, 12);
            textBoxBirthday.Name = "textBoxBirthday";
            textBoxBirthday.Size = new Size(86, 23);
            textBoxBirthday.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(37, 42, 52);
            label3.Location = new Point(283, 15);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Birthday:";
            // 
            // textBoxAlias
            // 
            textBoxAlias.Location = new Point(476, 12);
            textBoxAlias.Name = "textBoxAlias";
            textBoxAlias.Size = new Size(59, 23);
            textBoxAlias.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(37, 42, 52);
            label4.Location = new Point(435, 15);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 8;
            label4.Text = "Alias:";
            // 
            // PeopleOutButton
            // 
            PeopleOutButton.Location = new Point(555, 12);
            PeopleOutButton.Name = "PeopleOutButton";
            PeopleOutButton.Size = new Size(75, 23);
            PeopleOutButton.TabIndex = 10;
            PeopleOutButton.Text = "Показать";
            PeopleOutButton.UseVisualStyleBackColor = true;
            PeopleOutButton.Click += PeopleOutButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(37, 42, 52);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 10);
            panel1.TabIndex = 11;
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BackToMenuButton.Location = new Point(676, 12);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(75, 23);
            BackToMenuButton.TabIndex = 17;
            BackToMenuButton.Text = "Назад";
            BackToMenuButton.UseVisualStyleBackColor = true;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // dataGridPeople
            // 
            dataGridPeople.AllowUserToAddRows = false;
            dataGridPeople.AllowUserToDeleteRows = false;
            dataGridPeople.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPeople.BackgroundColor = Color.FromArgb(37, 42, 52);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(234, 234, 234);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(37, 42, 52);
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(234, 234, 234);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPeople.Columns.AddRange(new DataGridViewColumn[] { IdPeople, FullnamePeople, BirthdayPeople, BiographyPeople, PhotoPeople, PrintsPeople, AliasPeople, CriminalRecordsPeople });
            dataGridPeople.GridColor = Color.FromArgb(37, 42, 52);
            dataGridPeople.Location = new Point(12, 57);
            dataGridPeople.Name = "dataGridPeople";
            dataGridPeople.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(37, 42, 52);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(234, 234, 234);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(234, 234, 234);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(37, 42, 52);
            dataGridPeople.RowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridPeople.RowTemplate.Height = 75;
            dataGridPeople.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridPeople.ShowEditingIcon = false;
            dataGridPeople.Size = new Size(739, 332);
            dataGridPeople.TabIndex = 18;
            // 
            // IdPeople
            // 
            IdPeople.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(234, 234, 234);
            IdPeople.DefaultCellStyle = dataGridViewCellStyle2;
            IdPeople.HeaderText = "Id";
            IdPeople.Name = "IdPeople";
            IdPeople.ReadOnly = true;
            IdPeople.Resizable = DataGridViewTriState.True;
            IdPeople.Width = 42;
            // 
            // FullnamePeople
            // 
            FullnamePeople.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(234, 234, 234);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            FullnamePeople.DefaultCellStyle = dataGridViewCellStyle3;
            FullnamePeople.HeaderText = "Fullname";
            FullnamePeople.Name = "FullnamePeople";
            FullnamePeople.ReadOnly = true;
            FullnamePeople.Width = 81;
            // 
            // BirthdayPeople
            // 
            BirthdayPeople.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(234, 234, 234);
            BirthdayPeople.DefaultCellStyle = dataGridViewCellStyle4;
            BirthdayPeople.HeaderText = "Birthday";
            BirthdayPeople.Name = "BirthdayPeople";
            BirthdayPeople.ReadOnly = true;
            BirthdayPeople.Width = 76;
            // 
            // BiographyPeople
            // 
            BiographyPeople.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(234, 234, 234);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            BiographyPeople.DefaultCellStyle = dataGridViewCellStyle5;
            BiographyPeople.HeaderText = "Biography";
            BiographyPeople.Name = "BiographyPeople";
            BiographyPeople.ReadOnly = true;
            // 
            // PhotoPeople
            // 
            PhotoPeople.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(234, 234, 234);
            dataGridViewCellStyle6.NullValue = null;
            PhotoPeople.DefaultCellStyle = dataGridViewCellStyle6;
            PhotoPeople.HeaderText = "Photo";
            PhotoPeople.ImageLayout = DataGridViewImageCellLayout.Zoom;
            PhotoPeople.Name = "PhotoPeople";
            PhotoPeople.ReadOnly = true;
            PhotoPeople.Resizable = DataGridViewTriState.True;
            PhotoPeople.Width = 45;
            // 
            // PrintsPeople
            // 
            PrintsPeople.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(234, 234, 234);
            dataGridViewCellStyle7.NullValue = null;
            PrintsPeople.DefaultCellStyle = dataGridViewCellStyle7;
            PrintsPeople.HeaderText = "Prints";
            PrintsPeople.ImageLayout = DataGridViewImageCellLayout.Zoom;
            PrintsPeople.Name = "PrintsPeople";
            PrintsPeople.ReadOnly = true;
            PrintsPeople.Width = 43;
            // 
            // AliasPeople
            // 
            AliasPeople.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(234, 234, 234);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            AliasPeople.DefaultCellStyle = dataGridViewCellStyle8;
            AliasPeople.HeaderText = "Alias";
            AliasPeople.Name = "AliasPeople";
            AliasPeople.ReadOnly = true;
            AliasPeople.Resizable = DataGridViewTriState.True;
            AliasPeople.SortMode = DataGridViewColumnSortMode.NotSortable;
            AliasPeople.Width = 38;
            // 
            // CriminalRecordsPeople
            // 
            CriminalRecordsPeople.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(234, 234, 234);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            CriminalRecordsPeople.DefaultCellStyle = dataGridViewCellStyle9;
            CriminalRecordsPeople.HeaderText = "CriminalRecords";
            CriminalRecordsPeople.Name = "CriminalRecordsPeople";
            CriminalRecordsPeople.ReadOnly = true;
            CriminalRecordsPeople.Resizable = DataGridViewTriState.True;
            CriminalRecordsPeople.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PeopleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(763, 401);
            Controls.Add(dataGridPeople);
            Controls.Add(BackToMenuButton);
            Controls.Add(panel1);
            Controls.Add(PeopleOutButton);
            Controls.Add(textBoxAlias);
            Controls.Add(label4);
            Controls.Add(textBoxBirthday);
            Controls.Add(label3);
            Controls.Add(textBoxFullname);
            Controls.Add(label2);
            Controls.Add(textBoxAffairsId);
            Controls.Add(label1);
            Name = "PeopleForm";
            Text = "PeopleForm";
            ((System.ComponentModel.ISupportInitialize)dataGridPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAffairsId;
        private Label label1;
        private TextBox textBoxFullname;
        private Label label2;
        private TextBox textBoxBirthday;
        private Label label3;
        private TextBox textBoxAlias;
        private Label label4;
        private Button PeopleOutButton;
        private Panel panel1;
        private Button BackToMenuButton;
        private DataGridView dataGridPeople;
        private DataGridViewTextBoxColumn IdPeople;
        private DataGridViewTextBoxColumn FullnamePeople;
        private DataGridViewTextBoxColumn BirthdayPeople;
        private DataGridViewTextBoxColumn BiographyPeople;
        private DataGridViewImageColumn PhotoPeople;
        private DataGridViewImageColumn PrintsPeople;
        private DataGridViewTextBoxColumn AliasPeople;
        private DataGridViewTextBoxColumn CriminalRecordsPeople;
    }
}