namespace KursDBWinForms
{
    partial class DocksStatusForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textBoxExecutor = new TextBox();
            label1 = new Label();
            textBoxDeadline = new TextBox();
            label2 = new Label();
            textBoxResponsible = new TextBox();
            label3 = new Label();
            textBoxComplete = new TextBox();
            label4 = new Label();
            buttonAddDocksStatus = new Button();
            buttonBackToMenu = new Button();
            textBoxIdDocks = new TextBox();
            label5 = new Label();
            buttonDelete = new Button();
            panel1 = new Panel();
            dataGridDocksStatuses = new DataGridView();
            IdDocksStatus = new DataGridViewTextBoxColumn();
            ExecutorDocksStatus = new DataGridViewTextBoxColumn();
            DeadlineDocksStatus = new DataGridViewTextBoxColumn();
            ResponsibleDocksStatus = new DataGridViewTextBoxColumn();
            CompleteDocksStatus = new DataGridViewTextBoxColumn();
            dataGridDocks = new DataGridView();
            IdDate = new DataGridViewTextBoxColumn();
            HeaderDate = new DataGridViewTextBoxColumn();
            CategoryDate = new DataGridViewTextBoxColumn();
            ByWhoDate = new DataGridViewTextBoxColumn();
            buttonWithoutStatuses = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridDocksStatuses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDocks).BeginInit();
            SuspendLayout();
            // 
            // textBoxExecutor
            // 
            textBoxExecutor.Location = new Point(74, 6);
            textBoxExecutor.Name = "textBoxExecutor";
            textBoxExecutor.Size = new Size(102, 23);
            textBoxExecutor.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(37, 42, 52);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 8;
            label1.Text = "Executor:";
            // 
            // textBoxDeadline
            // 
            textBoxDeadline.Location = new Point(244, 6);
            textBoxDeadline.Name = "textBoxDeadline";
            textBoxDeadline.Size = new Size(102, 23);
            textBoxDeadline.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(37, 42, 52);
            label2.Location = new Point(182, 9);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 10;
            label2.Text = "Deadline:";
            // 
            // textBoxResponsible
            // 
            textBoxResponsible.Location = new Point(431, 6);
            textBoxResponsible.Name = "textBoxResponsible";
            textBoxResponsible.Size = new Size(102, 23);
            textBoxResponsible.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(37, 42, 52);
            label3.Location = new Point(352, 9);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 12;
            label3.Text = "Responsible:";
            // 
            // textBoxComplete
            // 
            textBoxComplete.Location = new Point(609, 6);
            textBoxComplete.Name = "textBoxComplete";
            textBoxComplete.Size = new Size(25, 23);
            textBoxComplete.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(37, 42, 52);
            label4.Location = new Point(539, 9);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 14;
            label4.Text = "Complete?";
            // 
            // buttonAddDocksStatus
            // 
            buttonAddDocksStatus.Location = new Point(735, 6);
            buttonAddDocksStatus.Name = "buttonAddDocksStatus";
            buttonAddDocksStatus.Size = new Size(75, 23);
            buttonAddDocksStatus.TabIndex = 16;
            buttonAddDocksStatus.Text = "Добавить";
            buttonAddDocksStatus.UseVisualStyleBackColor = true;
            buttonAddDocksStatus.Click += buttonAddDocksStatus_Click;
            // 
            // buttonBackToMenu
            // 
            buttonBackToMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBackToMenu.Location = new Point(1019, 6);
            buttonBackToMenu.Name = "buttonBackToMenu";
            buttonBackToMenu.Size = new Size(75, 23);
            buttonBackToMenu.TabIndex = 17;
            buttonBackToMenu.Text = "Назад";
            buttonBackToMenu.UseVisualStyleBackColor = true;
            buttonBackToMenu.Click += buttonBackToMenu_Click;
            // 
            // textBoxIdDocks
            // 
            textBoxIdDocks.Location = new Point(698, 6);
            textBoxIdDocks.Name = "textBoxIdDocks";
            textBoxIdDocks.Size = new Size(31, 23);
            textBoxIdDocks.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(37, 42, 52);
            label5.Location = new Point(640, 10);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 18;
            label5.Text = "Id_Dock:";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(816, 6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 20;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(37, 42, 52);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 10);
            panel1.TabIndex = 21;
            // 
            // dataGridDocksStatuses
            // 
            dataGridDocksStatuses.AllowUserToAddRows = false;
            dataGridDocksStatuses.AllowUserToDeleteRows = false;
            dataGridDocksStatuses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridDocksStatuses.BackgroundColor = Color.FromArgb(37, 42, 52);
            dataGridDocksStatuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDocksStatuses.Columns.AddRange(new DataGridViewColumn[] { IdDocksStatus, ExecutorDocksStatus, DeadlineDocksStatus, ResponsibleDocksStatus, CompleteDocksStatus });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridDocksStatuses.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridDocksStatuses.Location = new Point(12, 51);
            dataGridDocksStatuses.Name = "dataGridDocksStatuses";
            dataGridDocksStatuses.ReadOnly = true;
            dataGridDocksStatuses.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridDocksStatuses.RowTemplate.Height = 50;
            dataGridDocksStatuses.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridDocksStatuses.Size = new Size(1082, 316);
            dataGridDocksStatuses.TabIndex = 26;
            // 
            // IdDocksStatus
            // 
            IdDocksStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IdDocksStatus.HeaderText = "IdDocks";
            IdDocksStatus.Name = "IdDocksStatus";
            IdDocksStatus.ReadOnly = true;
            IdDocksStatus.Width = 74;
            // 
            // ExecutorDocksStatus
            // 
            ExecutorDocksStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ExecutorDocksStatus.HeaderText = "Executor";
            ExecutorDocksStatus.Name = "ExecutorDocksStatus";
            ExecutorDocksStatus.ReadOnly = true;
            // 
            // DeadlineDocksStatus
            // 
            DeadlineDocksStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeadlineDocksStatus.HeaderText = "Deadline";
            DeadlineDocksStatus.Name = "DeadlineDocksStatus";
            DeadlineDocksStatus.ReadOnly = true;
            // 
            // ResponsibleDocksStatus
            // 
            ResponsibleDocksStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ResponsibleDocksStatus.HeaderText = "Responsible";
            ResponsibleDocksStatus.Name = "ResponsibleDocksStatus";
            ResponsibleDocksStatus.ReadOnly = true;
            // 
            // CompleteDocksStatus
            // 
            CompleteDocksStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CompleteDocksStatus.HeaderText = "Complete?";
            CompleteDocksStatus.Name = "CompleteDocksStatus";
            CompleteDocksStatus.ReadOnly = true;
            CompleteDocksStatus.Width = 89;
            // 
            // dataGridDocks
            // 
            dataGridDocks.AllowUserToAddRows = false;
            dataGridDocks.AllowUserToDeleteRows = false;
            dataGridDocks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridDocks.BackgroundColor = Color.FromArgb(37, 42, 52);
            dataGridDocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDocks.Columns.AddRange(new DataGridViewColumn[] { IdDate, HeaderDate, CategoryDate, ByWhoDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridDocks.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridDocks.Location = new Point(12, 51);
            dataGridDocks.Name = "dataGridDocks";
            dataGridDocks.ReadOnly = true;
            dataGridDocks.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridDocks.RowTemplate.Height = 50;
            dataGridDocks.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridDocks.Size = new Size(1082, 316);
            dataGridDocks.TabIndex = 27;
            dataGridDocks.Visible = false;
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
            // buttonWithoutStatuses
            // 
            buttonWithoutStatuses.Location = new Point(897, 6);
            buttonWithoutStatuses.Name = "buttonWithoutStatuses";
            buttonWithoutStatuses.Size = new Size(116, 23);
            buttonWithoutStatuses.TabIndex = 28;
            buttonWithoutStatuses.Text = "Без статусов";
            buttonWithoutStatuses.UseVisualStyleBackColor = true;
            buttonWithoutStatuses.Click += buttonWithoutStatuses_Click;
            // 
            // DocksStatusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(1106, 379);
            Controls.Add(buttonWithoutStatuses);
            Controls.Add(panel1);
            Controls.Add(buttonDelete);
            Controls.Add(textBoxIdDocks);
            Controls.Add(label5);
            Controls.Add(buttonBackToMenu);
            Controls.Add(buttonAddDocksStatus);
            Controls.Add(textBoxComplete);
            Controls.Add(label4);
            Controls.Add(textBoxResponsible);
            Controls.Add(label3);
            Controls.Add(textBoxDeadline);
            Controls.Add(label2);
            Controls.Add(textBoxExecutor);
            Controls.Add(label1);
            Controls.Add(dataGridDocksStatuses);
            Controls.Add(dataGridDocks);
            Name = "DocksStatusForm";
            Text = "DocksStatusForm";
            ((System.ComponentModel.ISupportInitialize)dataGridDocksStatuses).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDocks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxExecutor;
        private Label label1;
        private TextBox textBoxDeadline;
        private Label label2;
        private TextBox textBoxResponsible;
        private Label label3;
        private TextBox textBoxComplete;
        private Label label4;
        private Button buttonAddDocksStatus;
        private Button buttonBackToMenu;
        private TextBox textBoxIdDocks;
        private Label label5;
        private Button buttonDelete;
        private Panel panel1;
        private DataGridView dataGridDocksStatuses;
        private DataGridViewTextBoxColumn IdDocksStatus;
        private DataGridViewTextBoxColumn ExecutorDocksStatus;
        private DataGridViewTextBoxColumn DeadlineDocksStatus;
        private DataGridViewTextBoxColumn ResponsibleDocksStatus;
        private DataGridViewTextBoxColumn CompleteDocksStatus;
        private DataGridView dataGridDocks;
        private DataGridViewTextBoxColumn IdDate;
        private DataGridViewTextBoxColumn HeaderDate;
        private DataGridViewTextBoxColumn CategoryDate;
        private DataGridViewTextBoxColumn ByWhoDate;
        private Button buttonWithoutStatuses;
    }
}