namespace KursDBWinForms
{
    partial class AffairsForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            textBoxId = new TextBox();
            textBoxDocksId = new TextBox();
            label2 = new Label();
            textBoxCrime = new TextBox();
            label3 = new Label();
            textBoxResponsible = new TextBox();
            label4 = new Label();
            OutAffairsButton = new Button();
            panel1 = new Panel();
            BackToMenuButton = new Button();
            dataGridAffairs = new DataGridView();
            IdAffairs = new DataGridViewTextBoxColumn();
            NameAffairs = new DataGridViewTextBoxColumn();
            CategoryAffairs = new DataGridViewTextBoxColumn();
            ByWhoAffairs = new DataGridViewTextBoxColumn();
            CrimeOrNotAffairs = new DataGridViewTextBoxColumn();
            ResponsibleAffairs = new DataGridViewTextBoxColumn();
            buttonDownloadFiles = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridAffairs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(37, 42, 52);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(38, 6);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(35, 23);
            textBoxId.TabIndex = 1;
            // 
            // textBoxDocksId
            // 
            textBoxDocksId.Location = new Point(143, 6);
            textBoxDocksId.Name = "textBoxDocksId";
            textBoxDocksId.Size = new Size(35, 23);
            textBoxDocksId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(37, 42, 52);
            label2.Location = new Point(80, 9);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Docks_Id:";
            // 
            // textBoxCrime
            // 
            textBoxCrime.Location = new Point(292, 6);
            textBoxCrime.Name = "textBoxCrime";
            textBoxCrime.Size = new Size(21, 23);
            textBoxCrime.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(37, 42, 52);
            label3.Location = new Point(184, 9);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "crime_or_not(0, 1)";
            // 
            // textBoxResponsible
            // 
            textBoxResponsible.Location = new Point(400, 6);
            textBoxResponsible.Name = "textBoxResponsible";
            textBoxResponsible.Size = new Size(117, 23);
            textBoxResponsible.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(37, 42, 52);
            label4.Location = new Point(321, 9);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 6;
            label4.Text = "Responsible:";
            // 
            // OutAffairsButton
            // 
            OutAffairsButton.Location = new Point(523, 6);
            OutAffairsButton.Name = "OutAffairsButton";
            OutAffairsButton.Size = new Size(75, 23);
            OutAffairsButton.TabIndex = 8;
            OutAffairsButton.Text = "Показать";
            OutAffairsButton.UseVisualStyleBackColor = true;
            OutAffairsButton.Click += OutAffairsButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(37, 42, 52);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 10);
            panel1.TabIndex = 9;
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BackToMenuButton.Location = new Point(753, 6);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(71, 23);
            BackToMenuButton.TabIndex = 15;
            BackToMenuButton.Text = "Назад";
            BackToMenuButton.UseVisualStyleBackColor = true;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // dataGridAffairs
            // 
            dataGridAffairs.AllowUserToAddRows = false;
            dataGridAffairs.AllowUserToDeleteRows = false;
            dataGridAffairs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridAffairs.BackgroundColor = Color.FromArgb(37, 42, 52);
            dataGridAffairs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAffairs.Columns.AddRange(new DataGridViewColumn[] { IdAffairs, NameAffairs, CategoryAffairs, ByWhoAffairs, CrimeOrNotAffairs, ResponsibleAffairs });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridAffairs.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridAffairs.Location = new Point(12, 51);
            dataGridAffairs.Name = "dataGridAffairs";
            dataGridAffairs.ReadOnly = true;
            dataGridAffairs.RowTemplate.Height = 50;
            dataGridAffairs.Size = new Size(812, 318);
            dataGridAffairs.TabIndex = 16;
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
            // buttonDownloadFiles
            // 
            buttonDownloadFiles.Location = new Point(604, 6);
            buttonDownloadFiles.Name = "buttonDownloadFiles";
            buttonDownloadFiles.Size = new Size(143, 23);
            buttonDownloadFiles.TabIndex = 17;
            buttonDownloadFiles.Text = "Скачать файлы";
            buttonDownloadFiles.UseVisualStyleBackColor = true;
            buttonDownloadFiles.Click += buttonDownloadFiles_Click;
            // 
            // AffairsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(836, 381);
            Controls.Add(buttonDownloadFiles);
            Controls.Add(dataGridAffairs);
            Controls.Add(BackToMenuButton);
            Controls.Add(panel1);
            Controls.Add(OutAffairsButton);
            Controls.Add(textBoxResponsible);
            Controls.Add(label4);
            Controls.Add(textBoxCrime);
            Controls.Add(label3);
            Controls.Add(textBoxDocksId);
            Controls.Add(label2);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Name = "AffairsForm";
            Text = "AffairsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridAffairs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxId;
        private TextBox textBoxDocksId;
        private Label label2;
        private TextBox textBoxCrime;
        private Label label3;
        private TextBox textBoxResponsible;
        private Label label4;
        private Button OutAffairsButton;
        private Panel panel1;
        private Button BackToMenuButton;
        private DataGridView dataGridAffairs;
        private DataGridViewTextBoxColumn IdAffairs;
        private DataGridViewTextBoxColumn NameAffairs;
        private DataGridViewTextBoxColumn CategoryAffairs;
        private DataGridViewTextBoxColumn ByWhoAffairs;
        private DataGridViewTextBoxColumn CrimeOrNotAffairs;
        private DataGridViewTextBoxColumn ResponsibleAffairs;
        private Button buttonDownloadFiles;
    }
}