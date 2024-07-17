namespace KursDBWinForms
{
    partial class DateForm
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
            textBoxExecutor = new TextBox();
            label1 = new Label();
            textBoxDateFirst = new TextBox();
            label2 = new Label();
            textBoxResponsible = new TextBox();
            label3 = new Label();
            textBoxComplete = new TextBox();
            label4 = new Label();
            DateOutButton = new Button();
            BackToMenuButton = new Button();
            panel1 = new Panel();
            textBoxDateSecond = new TextBox();
            label5 = new Label();
            dataGridDate = new DataGridView();
            IdDate = new DataGridViewTextBoxColumn();
            HeaderDate = new DataGridViewTextBoxColumn();
            CategoryDate = new DataGridViewTextBoxColumn();
            ByWhoDate = new DataGridViewTextBoxColumn();
            ExecutorDate = new DataGridViewTextBoxColumn();
            DeadlineDate = new DataGridViewTextBoxColumn();
            ResponsibleDate = new DataGridViewTextBoxColumn();
            CompleteDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridDate).BeginInit();
            SuspendLayout();
            // 
            // textBoxExecutor
            // 
            textBoxExecutor.Location = new Point(69, 6);
            textBoxExecutor.Name = "textBoxExecutor";
            textBoxExecutor.Size = new Size(102, 23);
            textBoxExecutor.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(37, 42, 52);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 4;
            label1.Text = "Executor:";
            // 
            // textBoxDateFirst
            // 
            textBoxDateFirst.Location = new Point(250, 6);
            textBoxDateFirst.Name = "textBoxDateFirst";
            textBoxDateFirst.Size = new Size(85, 23);
            textBoxDateFirst.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(37, 42, 52);
            label2.Location = new Point(177, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "RangeDate:";
            // 
            // textBoxResponsible
            // 
            textBoxResponsible.Location = new Point(519, 7);
            textBoxResponsible.Name = "textBoxResponsible";
            textBoxResponsible.Size = new Size(116, 23);
            textBoxResponsible.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(37, 42, 52);
            label3.Location = new Point(440, 9);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 8;
            label3.Text = "Responsible:";
            // 
            // textBoxComplete
            // 
            textBoxComplete.Location = new Point(711, 7);
            textBoxComplete.Name = "textBoxComplete";
            textBoxComplete.Size = new Size(23, 23);
            textBoxComplete.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(37, 42, 52);
            label4.Location = new Point(641, 9);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 10;
            label4.Text = "Complete?";
            // 
            // DateOutButton
            // 
            DateOutButton.Location = new Point(740, 6);
            DateOutButton.Name = "DateOutButton";
            DateOutButton.Size = new Size(75, 23);
            DateOutButton.TabIndex = 12;
            DateOutButton.Text = "Показать";
            DateOutButton.UseVisualStyleBackColor = true;
            DateOutButton.Click += DateOutButton_Click;
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BackToMenuButton.Location = new Point(821, 5);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(79, 23);
            BackToMenuButton.TabIndex = 13;
            BackToMenuButton.Text = "Назад";
            BackToMenuButton.UseVisualStyleBackColor = true;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(37, 42, 52);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 10);
            panel1.TabIndex = 14;
            // 
            // textBoxDateSecond
            // 
            textBoxDateSecond.Location = new Point(349, 6);
            textBoxDateSecond.Name = "textBoxDateSecond";
            textBoxDateSecond.Size = new Size(85, 23);
            textBoxDateSecond.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 10);
            label5.Name = "label5";
            label5.Size = new Size(10, 15);
            label5.TabIndex = 23;
            label5.Text = ":";
            // 
            // dataGridDate
            // 
            dataGridDate.AllowUserToAddRows = false;
            dataGridDate.AllowUserToDeleteRows = false;
            dataGridDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridDate.BackgroundColor = Color.FromArgb(37, 42, 52);
            dataGridDate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDate.Columns.AddRange(new DataGridViewColumn[] { IdDate, HeaderDate, CategoryDate, ByWhoDate, ExecutorDate, DeadlineDate, ResponsibleDate, CompleteDate });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridDate.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridDate.Location = new Point(12, 51);
            dataGridDate.Name = "dataGridDate";
            dataGridDate.ReadOnly = true;
            dataGridDate.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridDate.RowTemplate.Height = 50;
            dataGridDate.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridDate.Size = new Size(888, 331);
            dataGridDate.TabIndex = 24;
            // 
            // IdDate
            // 
            IdDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IdDate.HeaderText = "Id";
            IdDate.Name = "IdDate";
            IdDate.ReadOnly = true;
            IdDate.Width = 42;
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
            CategoryDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CategoryDate.HeaderText = "Category";
            CategoryDate.Name = "CategoryDate";
            CategoryDate.ReadOnly = true;
            CategoryDate.Width = 80;
            // 
            // ByWhoDate
            // 
            ByWhoDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ByWhoDate.HeaderText = "ByWho";
            ByWhoDate.Name = "ByWhoDate";
            ByWhoDate.ReadOnly = true;
            ByWhoDate.Width = 70;
            // 
            // ExecutorDate
            // 
            ExecutorDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ExecutorDate.HeaderText = "Executor";
            ExecutorDate.Name = "ExecutorDate";
            ExecutorDate.ReadOnly = true;
            ExecutorDate.Width = 78;
            // 
            // DeadlineDate
            // 
            DeadlineDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DeadlineDate.HeaderText = "Deadline";
            DeadlineDate.Name = "DeadlineDate";
            DeadlineDate.ReadOnly = true;
            DeadlineDate.Width = 78;
            // 
            // ResponsibleDate
            // 
            ResponsibleDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ResponsibleDate.HeaderText = "Responsible";
            ResponsibleDate.Name = "ResponsibleDate";
            ResponsibleDate.ReadOnly = true;
            // 
            // CompleteDate
            // 
            CompleteDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CompleteDate.HeaderText = "Complete?";
            CompleteDate.Name = "CompleteDate";
            CompleteDate.ReadOnly = true;
            CompleteDate.Width = 89;
            // 
            // DateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(912, 394);
            Controls.Add(dataGridDate);
            Controls.Add(label5);
            Controls.Add(textBoxDateSecond);
            Controls.Add(panel1);
            Controls.Add(BackToMenuButton);
            Controls.Add(DateOutButton);
            Controls.Add(textBoxComplete);
            Controls.Add(label4);
            Controls.Add(textBoxResponsible);
            Controls.Add(label3);
            Controls.Add(textBoxDateFirst);
            Controls.Add(label2);
            Controls.Add(textBoxExecutor);
            Controls.Add(label1);
            Name = "DateForm";
            Text = "DateForm";
            ((System.ComponentModel.ISupportInitialize)dataGridDate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxExecutor;
        private Label label1;
        private TextBox textBoxDateFirst;
        private Label label2;
        private TextBox textBoxResponsible;
        private Label label3;
        private TextBox textBoxComplete;
        private Label label4;
        private Button DateOutButton;
        private Button BackToMenuButton;
        private Panel panel1;
        private TextBox textBoxDateSecond;
        private Label label5;
        private DataGridView dataGridDate;
        private DataGridViewTextBoxColumn IdDate;
        private DataGridViewTextBoxColumn HeaderDate;
        private DataGridViewTextBoxColumn CategoryDate;
        private DataGridViewTextBoxColumn ByWhoDate;
        private DataGridViewTextBoxColumn ExecutorDate;
        private DataGridViewTextBoxColumn DeadlineDate;
        private DataGridViewTextBoxColumn ResponsibleDate;
        private DataGridViewTextBoxColumn CompleteDate;
    }
}