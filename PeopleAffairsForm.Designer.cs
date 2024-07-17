namespace KursDBWinForms
{
    partial class PeopleAffairsForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            buttonBackToMenu = new Button();
            buttonDocksWithoutAffairs = new Button();
            buttonDeleteAffairs = new Button();
            buttonAddAffairs = new Button();
            buttonDeletePeople = new Button();
            buttonAddPeople = new Button();
            textBoxIdDocks = new TextBox();
            labelIdDocks = new Label();
            textBoxCriminal = new TextBox();
            labelCriminal = new Label();
            textBoxResponsible = new TextBox();
            labelResponsible = new Label();
            labelDocksFile = new Label();
            textBoxFullname = new TextBox();
            labelFullname = new Label();
            textBoxBirhtday = new TextBox();
            labelBirthday = new Label();
            textBoxBiography = new TextBox();
            labelBiography = new Label();
            labelPrints = new Label();
            textBoxIdAffairs = new TextBox();
            labelIdAffairs = new Label();
            textBoxIdPeople = new TextBox();
            labelIdPeople = new Label();
            textBoxCriminalRecord = new TextBox();
            labelCriminalRecord = new Label();
            textBoxAlias = new TextBox();
            labelAlias = new Label();
            buttonAddCriminalRecordAlias = new Button();
            buttonDeleteCriminalRecordAlias = new Button();
            panel3 = new Panel();
            dataGridPeople = new DataGridView();
            IdPeople = new DataGridViewTextBoxColumn();
            FullnamePeople = new DataGridViewTextBoxColumn();
            BirthdayPeople = new DataGridViewTextBoxColumn();
            BiographyPeople = new DataGridViewTextBoxColumn();
            PhotoPeople = new DataGridViewImageColumn();
            PrintsPeople = new DataGridViewImageColumn();
            AliasPeople = new DataGridViewTextBoxColumn();
            CriminalRecordsPeople = new DataGridViewTextBoxColumn();
            dataGridAffairs = new DataGridView();
            IdAffairs = new DataGridViewTextBoxColumn();
            NameAffairs = new DataGridViewTextBoxColumn();
            CategoryAffairs = new DataGridViewTextBoxColumn();
            ByWhoAffairs = new DataGridViewTextBoxColumn();
            CrimeOrNotAffairs = new DataGridViewTextBoxColumn();
            ResponsibleAffairs = new DataGridViewTextBoxColumn();
            dataGridDocks = new DataGridView();
            IdDate = new DataGridViewTextBoxColumn();
            HeaderDate = new DataGridViewTextBoxColumn();
            CategoryDate = new DataGridViewTextBoxColumn();
            ByWhoDate = new DataGridViewTextBoxColumn();
            labelPhoto = new Label();
            checkBoxPrints = new CheckBox();
            checkBoxPhoto = new CheckBox();
            checkBoxDockFile = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridPeople).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridAffairs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDocks).BeginInit();
            SuspendLayout();
            // 
            // buttonBackToMenu
            // 
            buttonBackToMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBackToMenu.Location = new Point(923, 8);
            buttonBackToMenu.Name = "buttonBackToMenu";
            buttonBackToMenu.Size = new Size(75, 23);
            buttonBackToMenu.TabIndex = 0;
            buttonBackToMenu.Text = "Назад";
            buttonBackToMenu.UseVisualStyleBackColor = true;
            buttonBackToMenu.Click += buttonBackToMenu_Click;
            // 
            // buttonDocksWithoutAffairs
            // 
            buttonDocksWithoutAffairs.Location = new Point(712, 8);
            buttonDocksWithoutAffairs.Name = "buttonDocksWithoutAffairs";
            buttonDocksWithoutAffairs.Size = new Size(75, 23);
            buttonDocksWithoutAffairs.TabIndex = 1;
            buttonDocksWithoutAffairs.Text = "Без дел";
            buttonDocksWithoutAffairs.UseVisualStyleBackColor = true;
            buttonDocksWithoutAffairs.Click += buttonDocksWithoutAffairs_Click;
            // 
            // buttonDeleteAffairs
            // 
            buttonDeleteAffairs.Location = new Point(319, 8);
            buttonDeleteAffairs.Name = "buttonDeleteAffairs";
            buttonDeleteAffairs.Size = new Size(89, 23);
            buttonDeleteAffairs.TabIndex = 2;
            buttonDeleteAffairs.Text = "Удалить дело";
            buttonDeleteAffairs.UseVisualStyleBackColor = true;
            buttonDeleteAffairs.Click += buttonDeleteAffairs_Click;
            // 
            // buttonAddAffairs
            // 
            buttonAddAffairs.Location = new Point(213, 8);
            buttonAddAffairs.Name = "buttonAddAffairs";
            buttonAddAffairs.Size = new Size(100, 23);
            buttonAddAffairs.TabIndex = 3;
            buttonAddAffairs.Text = "Добавить дело";
            buttonAddAffairs.UseVisualStyleBackColor = true;
            buttonAddAffairs.Click += buttonAddAffairs_Click;
            // 
            // buttonDeletePeople
            // 
            buttonDeletePeople.Location = new Point(557, 8);
            buttonDeletePeople.Name = "buttonDeletePeople";
            buttonDeletePeople.Size = new Size(149, 23);
            buttonDeletePeople.TabIndex = 16;
            buttonDeletePeople.Text = "Удалить гражданина";
            buttonDeletePeople.UseVisualStyleBackColor = true;
            buttonDeletePeople.Click += buttonDeletePeople_Click;
            // 
            // buttonAddPeople
            // 
            buttonAddPeople.Location = new Point(414, 8);
            buttonAddPeople.Name = "buttonAddPeople";
            buttonAddPeople.Size = new Size(137, 23);
            buttonAddPeople.TabIndex = 17;
            buttonAddPeople.Text = "Добавить гражданина";
            buttonAddPeople.UseVisualStyleBackColor = true;
            buttonAddPeople.Click += buttonAddPeople_Click;
            // 
            // textBoxIdDocks
            // 
            textBoxIdDocks.Location = new Point(81, 36);
            textBoxIdDocks.Name = "textBoxIdDocks";
            textBoxIdDocks.Size = new Size(27, 23);
            textBoxIdDocks.TabIndex = 20;
            // 
            // labelIdDocks
            // 
            labelIdDocks.AutoSize = true;
            labelIdDocks.ForeColor = Color.FromArgb(37, 42, 52);
            labelIdDocks.Location = new Point(17, 40);
            labelIdDocks.Name = "labelIdDocks";
            labelIdDocks.Size = new Size(57, 15);
            labelIdDocks.TabIndex = 19;
            labelIdDocks.Text = "Id_Docks:";
            // 
            // textBoxCriminal
            // 
            textBoxCriminal.Location = new Point(181, 37);
            textBoxCriminal.Name = "textBoxCriminal";
            textBoxCriminal.Size = new Size(30, 23);
            textBoxCriminal.TabIndex = 22;
            // 
            // labelCriminal
            // 
            labelCriminal.AutoSize = true;
            labelCriminal.ForeColor = Color.FromArgb(37, 42, 52);
            labelCriminal.Location = new Point(118, 40);
            labelCriminal.Name = "labelCriminal";
            labelCriminal.Size = new Size(57, 15);
            labelCriminal.TabIndex = 21;
            labelCriminal.Text = "Criminal?";
            // 
            // textBoxResponsible
            // 
            textBoxResponsible.Location = new Point(296, 37);
            textBoxResponsible.Name = "textBoxResponsible";
            textBoxResponsible.Size = new Size(102, 23);
            textBoxResponsible.TabIndex = 24;
            // 
            // labelResponsible
            // 
            labelResponsible.AutoSize = true;
            labelResponsible.ForeColor = Color.FromArgb(37, 42, 52);
            labelResponsible.Location = new Point(217, 40);
            labelResponsible.Name = "labelResponsible";
            labelResponsible.Size = new Size(73, 15);
            labelResponsible.TabIndex = 23;
            labelResponsible.Text = "Responsible:";
            // 
            // labelDocksFile
            // 
            labelDocksFile.AutoSize = true;
            labelDocksFile.ForeColor = Color.FromArgb(37, 42, 52);
            labelDocksFile.Location = new Point(414, 40);
            labelDocksFile.Name = "labelDocksFile";
            labelDocksFile.Size = new Size(60, 15);
            labelDocksFile.TabIndex = 25;
            labelDocksFile.Text = "DocksFile:";
            // 
            // textBoxFullname
            // 
            textBoxFullname.Location = new Point(181, 37);
            textBoxFullname.Name = "textBoxFullname";
            textBoxFullname.Size = new Size(102, 23);
            textBoxFullname.TabIndex = 27;
            // 
            // labelFullname
            // 
            labelFullname.AutoSize = true;
            labelFullname.ForeColor = Color.FromArgb(37, 42, 52);
            labelFullname.Location = new Point(116, 40);
            labelFullname.Name = "labelFullname";
            labelFullname.Size = new Size(59, 15);
            labelFullname.TabIndex = 26;
            labelFullname.Text = "Fullname:";
            // 
            // textBoxBirhtday
            // 
            textBoxBirhtday.Location = new Point(346, 37);
            textBoxBirhtday.Name = "textBoxBirhtday";
            textBoxBirhtday.Size = new Size(102, 23);
            textBoxBirhtday.TabIndex = 29;
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.ForeColor = Color.FromArgb(37, 42, 52);
            labelBirthday.Location = new Point(289, 40);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(54, 15);
            labelBirthday.TabIndex = 28;
            labelBirthday.Text = "Birthday:";
            // 
            // textBoxBiography
            // 
            textBoxBiography.Location = new Point(524, 37);
            textBoxBiography.Name = "textBoxBiography";
            textBoxBiography.Size = new Size(102, 23);
            textBoxBiography.TabIndex = 31;
            // 
            // labelBiography
            // 
            labelBiography.AutoSize = true;
            labelBiography.ForeColor = Color.FromArgb(37, 42, 52);
            labelBiography.Location = new Point(454, 40);
            labelBiography.Name = "labelBiography";
            labelBiography.Size = new Size(64, 15);
            labelBiography.TabIndex = 30;
            labelBiography.Text = "Biography:";
            // 
            // labelPrints
            // 
            labelPrints.AutoSize = true;
            labelPrints.ForeColor = Color.FromArgb(37, 42, 52);
            labelPrints.Location = new Point(632, 40);
            labelPrints.Name = "labelPrints";
            labelPrints.Size = new Size(40, 15);
            labelPrints.TabIndex = 33;
            labelPrints.Text = "Prints:";
            // 
            // textBoxIdAffairs
            // 
            textBoxIdAffairs.Location = new Point(81, 36);
            textBoxIdAffairs.Name = "textBoxIdAffairs";
            textBoxIdAffairs.Size = new Size(27, 23);
            textBoxIdAffairs.TabIndex = 35;
            // 
            // labelIdAffairs
            // 
            labelIdAffairs.AutoSize = true;
            labelIdAffairs.ForeColor = Color.FromArgb(37, 42, 52);
            labelIdAffairs.Location = new Point(17, 40);
            labelIdAffairs.Name = "labelIdAffairs";
            labelIdAffairs.Size = new Size(59, 15);
            labelIdAffairs.TabIndex = 34;
            labelIdAffairs.Text = "Id_Affairs:";
            // 
            // textBoxIdPeople
            // 
            textBoxIdPeople.Location = new Point(81, 36);
            textBoxIdPeople.Name = "textBoxIdPeople";
            textBoxIdPeople.Size = new Size(27, 23);
            textBoxIdPeople.TabIndex = 37;
            // 
            // labelIdPeople
            // 
            labelIdPeople.AutoSize = true;
            labelIdPeople.ForeColor = Color.FromArgb(37, 42, 52);
            labelIdPeople.Location = new Point(14, 39);
            labelIdPeople.Name = "labelIdPeople";
            labelIdPeople.Size = new Size(61, 15);
            labelIdPeople.TabIndex = 36;
            labelIdPeople.Text = "Id_People:";
            // 
            // textBoxCriminalRecord
            // 
            textBoxCriminalRecord.Location = new Point(213, 37);
            textBoxCriminalRecord.Name = "textBoxCriminalRecord";
            textBoxCriminalRecord.Size = new Size(195, 23);
            textBoxCriminalRecord.TabIndex = 39;
            // 
            // labelCriminalRecord
            // 
            labelCriminalRecord.AutoSize = true;
            labelCriminalRecord.ForeColor = Color.FromArgb(37, 42, 52);
            labelCriminalRecord.Location = new Point(116, 40);
            labelCriminalRecord.Name = "labelCriminalRecord";
            labelCriminalRecord.Size = new Size(92, 15);
            labelCriminalRecord.TabIndex = 38;
            labelCriminalRecord.Text = "CriminalRecord:";
            // 
            // textBoxAlias
            // 
            textBoxAlias.Location = new Point(454, 37);
            textBoxAlias.Name = "textBoxAlias";
            textBoxAlias.Size = new Size(96, 23);
            textBoxAlias.TabIndex = 41;
            // 
            // labelAlias
            // 
            labelAlias.AutoSize = true;
            labelAlias.ForeColor = Color.FromArgb(37, 42, 52);
            labelAlias.Location = new Point(414, 39);
            labelAlias.Name = "labelAlias";
            labelAlias.Size = new Size(35, 15);
            labelAlias.TabIndex = 40;
            labelAlias.Text = "Alias:";
            // 
            // buttonAddCriminalRecordAlias
            // 
            buttonAddCriminalRecordAlias.Location = new Point(12, 8);
            buttonAddCriminalRecordAlias.Name = "buttonAddCriminalRecordAlias";
            buttonAddCriminalRecordAlias.Size = new Size(98, 23);
            buttonAddCriminalRecordAlias.TabIndex = 42;
            buttonAddCriminalRecordAlias.Text = "Добавить П/К";
            buttonAddCriminalRecordAlias.UseVisualStyleBackColor = true;
            buttonAddCriminalRecordAlias.Click += buttonAddCriminalRecordAlias_Click;
            // 
            // buttonDeleteCriminalRecordAlias
            // 
            buttonDeleteCriminalRecordAlias.Location = new Point(116, 8);
            buttonDeleteCriminalRecordAlias.Name = "buttonDeleteCriminalRecordAlias";
            buttonDeleteCriminalRecordAlias.Size = new Size(91, 23);
            buttonDeleteCriminalRecordAlias.TabIndex = 43;
            buttonDeleteCriminalRecordAlias.Text = "Удалить П/К";
            buttonDeleteCriminalRecordAlias.UseVisualStyleBackColor = true;
            buttonDeleteCriminalRecordAlias.Click += buttonDeleteCriminalRecordAlias_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(37, 42, 52);
            panel3.ForeColor = SystemColors.ControlText;
            panel3.Location = new Point(12, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(985, 10);
            panel3.TabIndex = 44;
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
            dataGridPeople.Location = new Point(12, 80);
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
            dataGridPeople.Size = new Size(985, 267);
            dataGridPeople.TabIndex = 45;
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
            // dataGridAffairs
            // 
            dataGridAffairs.AllowUserToAddRows = false;
            dataGridAffairs.AllowUserToDeleteRows = false;
            dataGridAffairs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridAffairs.BackgroundColor = Color.FromArgb(37, 42, 52);
            dataGridAffairs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAffairs.Columns.AddRange(new DataGridViewColumn[] { IdAffairs, NameAffairs, CategoryAffairs, ByWhoAffairs, CrimeOrNotAffairs, ResponsibleAffairs });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridAffairs.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridAffairs.Location = new Point(12, 80);
            dataGridAffairs.Name = "dataGridAffairs";
            dataGridAffairs.ReadOnly = true;
            dataGridAffairs.RowTemplate.Height = 50;
            dataGridAffairs.Size = new Size(985, 267);
            dataGridAffairs.TabIndex = 46;
            // 
            // IdAffairs
            // 
            IdAffairs.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IdAffairs.HeaderText = "Id";
            IdAffairs.Name = "IdAffairs";
            IdAffairs.ReadOnly = true;
            IdAffairs.Width = 42;
            // 
            // NameAffairs
            // 
            NameAffairs.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NameAffairs.HeaderText = "Name";
            NameAffairs.Name = "NameAffairs";
            NameAffairs.ReadOnly = true;
            // 
            // CategoryAffairs
            // 
            CategoryAffairs.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryAffairs.HeaderText = "Category";
            CategoryAffairs.Name = "CategoryAffairs";
            CategoryAffairs.ReadOnly = true;
            // 
            // ByWhoAffairs
            // 
            ByWhoAffairs.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ByWhoAffairs.HeaderText = "ByWho";
            ByWhoAffairs.Name = "ByWhoAffairs";
            ByWhoAffairs.ReadOnly = true;
            // 
            // CrimeOrNotAffairs
            // 
            CrimeOrNotAffairs.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CrimeOrNotAffairs.HeaderText = "Crime?";
            CrimeOrNotAffairs.Name = "CrimeOrNotAffairs";
            CrimeOrNotAffairs.ReadOnly = true;
            CrimeOrNotAffairs.Width = 69;
            // 
            // ResponsibleAffairs
            // 
            ResponsibleAffairs.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ResponsibleAffairs.HeaderText = "Responsible";
            ResponsibleAffairs.Name = "ResponsibleAffairs";
            ResponsibleAffairs.ReadOnly = true;
            // 
            // dataGridDocks
            // 
            dataGridDocks.AllowUserToAddRows = false;
            dataGridDocks.AllowUserToDeleteRows = false;
            dataGridDocks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridDocks.BackgroundColor = Color.FromArgb(37, 42, 52);
            dataGridDocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDocks.Columns.AddRange(new DataGridViewColumn[] { IdDate, HeaderDate, CategoryDate, ByWhoDate });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridDocks.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridDocks.Location = new Point(12, 80);
            dataGridDocks.Name = "dataGridDocks";
            dataGridDocks.ReadOnly = true;
            dataGridDocks.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridDocks.RowTemplate.Height = 50;
            dataGridDocks.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridDocks.Size = new Size(985, 269);
            dataGridDocks.TabIndex = 47;
            // 
            // IdDate
            // 
            IdDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IdDate.HeaderText = "Id";
            IdDate.Name = "IdDate";
            IdDate.ReadOnly = true;
            // 
            // HeaderDate
            // 
            HeaderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HeaderDate.HeaderText = "Header";
            HeaderDate.Name = "HeaderDate";
            HeaderDate.ReadOnly = true;
            // 
            // CategoryDate
            // 
            CategoryDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryDate.HeaderText = "Category";
            CategoryDate.Name = "CategoryDate";
            CategoryDate.ReadOnly = true;
            // 
            // ByWhoDate
            // 
            ByWhoDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ByWhoDate.HeaderText = "ByWho";
            ByWhoDate.Name = "ByWhoDate";
            ByWhoDate.ReadOnly = true;
            // 
            // labelPhoto
            // 
            labelPhoto.AutoSize = true;
            labelPhoto.ForeColor = Color.FromArgb(37, 42, 52);
            labelPhoto.Location = new Point(712, 40);
            labelPhoto.Name = "labelPhoto";
            labelPhoto.Size = new Size(42, 15);
            labelPhoto.TabIndex = 48;
            labelPhoto.Text = "Photo:";
            // 
            // checkBoxPrints
            // 
            checkBoxPrints.AutoSize = true;
            checkBoxPrints.Location = new Point(678, 41);
            checkBoxPrints.Name = "checkBoxPrints";
            checkBoxPrints.Size = new Size(15, 14);
            checkBoxPrints.TabIndex = 49;
            checkBoxPrints.UseVisualStyleBackColor = true;
            // 
            // checkBoxPhoto
            // 
            checkBoxPhoto.AutoSize = true;
            checkBoxPhoto.Location = new Point(760, 41);
            checkBoxPhoto.Name = "checkBoxPhoto";
            checkBoxPhoto.Size = new Size(15, 14);
            checkBoxPhoto.TabIndex = 50;
            checkBoxPhoto.UseVisualStyleBackColor = true;
            // 
            // checkBoxDockFile
            // 
            checkBoxDockFile.AutoSize = true;
            checkBoxDockFile.Location = new Point(480, 41);
            checkBoxDockFile.Name = "checkBoxDockFile";
            checkBoxDockFile.Size = new Size(15, 14);
            checkBoxDockFile.TabIndex = 51;
            checkBoxDockFile.UseVisualStyleBackColor = true;
            // 
            // PeopleAffairsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 359);
            Controls.Add(checkBoxDockFile);
            Controls.Add(checkBoxPhoto);
            Controls.Add(checkBoxPrints);
            Controls.Add(labelPhoto);
            Controls.Add(labelPrints);
            Controls.Add(labelDocksFile);
            Controls.Add(textBoxResponsible);
            Controls.Add(labelResponsible);
            Controls.Add(textBoxCriminal);
            Controls.Add(labelCriminal);
            Controls.Add(textBoxIdDocks);
            Controls.Add(labelIdDocks);
            Controls.Add(textBoxBiography);
            Controls.Add(labelBiography);
            Controls.Add(textBoxBirhtday);
            Controls.Add(labelBirthday);
            Controls.Add(textBoxFullname);
            Controls.Add(labelFullname);
            Controls.Add(textBoxIdAffairs);
            Controls.Add(labelIdAffairs);
            Controls.Add(panel3);
            Controls.Add(buttonDeleteCriminalRecordAlias);
            Controls.Add(buttonAddCriminalRecordAlias);
            Controls.Add(textBoxAlias);
            Controls.Add(labelAlias);
            Controls.Add(textBoxCriminalRecord);
            Controls.Add(labelCriminalRecord);
            Controls.Add(textBoxIdPeople);
            Controls.Add(labelIdPeople);
            Controls.Add(buttonAddPeople);
            Controls.Add(buttonDeletePeople);
            Controls.Add(buttonAddAffairs);
            Controls.Add(buttonDeleteAffairs);
            Controls.Add(buttonDocksWithoutAffairs);
            Controls.Add(buttonBackToMenu);
            Controls.Add(dataGridPeople);
            Controls.Add(dataGridDocks);
            Controls.Add(dataGridAffairs);
            Name = "PeopleAffairsForm";
            Text = "PeopleAffairsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridPeople).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridAffairs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDocks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBackToMenu;
        private Button buttonDocksWithoutAffairs;
        private Button buttonDeleteAffairs;
        private Button buttonAddAffairs;
        private Button buttonDeletePeople;
        private Button buttonAddPeople;
        private TextBox textBoxIdDocks;
        private Label labelIdDocks;
        private TextBox textBoxCriminal;
        private Label labelCriminal;
        private TextBox textBoxResponsible;
        private Label labelResponsible;
        private Label labelDocksFile;
        private TextBox textBoxFullname;
        private Label labelFullname;
        private TextBox textBoxBirhtday;
        private Label labelBirthday;
        private TextBox textBoxBiography;
        private Label labelBiography;
        private Label labelPrints;
        private TextBox textBoxIdAffairs;
        private Label labelIdAffairs;
        private TextBox textBoxIdPeople;
        private Label labelIdPeople;
        private TextBox textBoxCriminalRecord;
        private Label labelCriminalRecord;
        private TextBox textBoxAlias;
        private Label labelAlias;
        private Button buttonAddCriminalRecordAlias;
        private Button buttonDeleteCriminalRecordAlias;
        private Panel panel3;
        private DataGridView dataGridPeople;
        private DataGridViewTextBoxColumn IdPeople;
        private DataGridViewTextBoxColumn FullnamePeople;
        private DataGridViewTextBoxColumn BirthdayPeople;
        private DataGridViewTextBoxColumn BiographyPeople;
        private DataGridViewImageColumn PhotoPeople;
        private DataGridViewImageColumn PrintsPeople;
        private DataGridViewTextBoxColumn AliasPeople;
        private DataGridViewTextBoxColumn CriminalRecordsPeople;
        private DataGridView dataGridAffairs;
        private DataGridViewTextBoxColumn IdAffairs;
        private DataGridViewTextBoxColumn NameAffairs;
        private DataGridViewTextBoxColumn CategoryAffairs;
        private DataGridViewTextBoxColumn ByWhoAffairs;
        private DataGridViewTextBoxColumn CrimeOrNotAffairs;
        private DataGridViewTextBoxColumn ResponsibleAffairs;
        private DataGridView dataGridDocks;
        private DataGridViewTextBoxColumn IdDate;
        private DataGridViewTextBoxColumn HeaderDate;
        private DataGridViewTextBoxColumn CategoryDate;
        private DataGridViewTextBoxColumn ByWhoDate;
        private Label labelPhoto;
        private CheckBox checkBoxPrints;
        private CheckBox checkBoxPhoto;
        private CheckBox checkBoxDockFile;
    }
}