namespace KursDBWinForms
{
    partial class DocksForm
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
            textBoxHeader = new TextBox();
            label1 = new Label();
            textBoxCategory = new TextBox();
            label2 = new Label();
            textBoxByWho = new TextBox();
            label3 = new Label();
            buttonAddDock = new Button();
            buttonBackToMenu = new Button();
            panel1 = new Panel();
            dataGridDocks = new DataGridView();
            IdDate = new DataGridViewTextBoxColumn();
            HeaderDate = new DataGridViewTextBoxColumn();
            CategoryDate = new DataGridViewTextBoxColumn();
            ByWhoDate = new DataGridViewTextBoxColumn();
            buttonDeleteFromDocks = new Button();
            textBoxIdDocks = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridDocks).BeginInit();
            SuspendLayout();
            // 
            // textBoxHeader
            // 
            textBoxHeader.Location = new Point(64, 12);
            textBoxHeader.Name = "textBoxHeader";
            textBoxHeader.Size = new Size(102, 23);
            textBoxHeader.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(37, 42, 52);
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 6;
            label1.Text = "Header:";
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(236, 12);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(102, 23);
            textBoxCategory.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(37, 42, 52);
            label2.Location = new Point(172, 15);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 8;
            label2.Text = "Category:";
            // 
            // textBoxByWho
            // 
            textBoxByWho.Location = new Point(398, 12);
            textBoxByWho.Name = "textBoxByWho";
            textBoxByWho.Size = new Size(102, 23);
            textBoxByWho.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(37, 42, 52);
            label3.Location = new Point(344, 15);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 10;
            label3.Text = "ByWho:";
            // 
            // buttonAddDock
            // 
            buttonAddDock.ForeColor = Color.FromArgb(37, 42, 52);
            buttonAddDock.Location = new Point(522, 12);
            buttonAddDock.Name = "buttonAddDock";
            buttonAddDock.Size = new Size(75, 23);
            buttonAddDock.TabIndex = 12;
            buttonAddDock.Text = "Добавить";
            buttonAddDock.UseVisualStyleBackColor = true;
            buttonAddDock.Click += buttonAddDock_Click;
            // 
            // buttonBackToMenu
            // 
            buttonBackToMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBackToMenu.Location = new Point(885, 11);
            buttonBackToMenu.Name = "buttonBackToMenu";
            buttonBackToMenu.Size = new Size(75, 23);
            buttonBackToMenu.TabIndex = 13;
            buttonBackToMenu.Text = "Назад";
            buttonBackToMenu.UseVisualStyleBackColor = true;
            buttonBackToMenu.Click += buttonBackToMenu_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(37, 42, 52);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 10);
            panel1.TabIndex = 15;
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
            dataGridDocks.Location = new Point(12, 57);
            dataGridDocks.Name = "dataGridDocks";
            dataGridDocks.ReadOnly = true;
            dataGridDocks.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridDocks.RowTemplate.Height = 50;
            dataGridDocks.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridDocks.Size = new Size(948, 381);
            dataGridDocks.TabIndex = 25;
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
            // buttonDeleteFromDocks
            // 
            buttonDeleteFromDocks.ForeColor = Color.FromArgb(37, 42, 52);
            buttonDeleteFromDocks.Location = new Point(781, 11);
            buttonDeleteFromDocks.Name = "buttonDeleteFromDocks";
            buttonDeleteFromDocks.Size = new Size(75, 23);
            buttonDeleteFromDocks.TabIndex = 26;
            buttonDeleteFromDocks.Text = "Удалить";
            buttonDeleteFromDocks.UseVisualStyleBackColor = true;
            buttonDeleteFromDocks.Click += buttonDeleteFromDocks_Click;
            // 
            // textBoxIdDocks
            // 
            textBoxIdDocks.Location = new Point(673, 12);
            textBoxIdDocks.Name = "textBoxIdDocks";
            textBoxIdDocks.Size = new Size(102, 23);
            textBoxIdDocks.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(37, 42, 52);
            label4.Location = new Point(619, 16);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 28;
            label4.Text = "Id_Dock:";
            // 
            // DocksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(972, 450);
            Controls.Add(label4);
            Controls.Add(textBoxIdDocks);
            Controls.Add(buttonDeleteFromDocks);
            Controls.Add(dataGridDocks);
            Controls.Add(panel1);
            Controls.Add(buttonBackToMenu);
            Controls.Add(buttonAddDock);
            Controls.Add(textBoxByWho);
            Controls.Add(label3);
            Controls.Add(textBoxCategory);
            Controls.Add(label2);
            Controls.Add(textBoxHeader);
            Controls.Add(label1);
            Name = "DocksForm";
            Text = "DocksForm";
            ((System.ComponentModel.ISupportInitialize)dataGridDocks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHeader;
        private Label label1;
        private TextBox textBoxCategory;
        private Label label2;
        private TextBox textBoxByWho;
        private Label label3;
        private Button buttonAddDock;
        private Button buttonBackToMenu;
        private Panel panel1;
        private DataGridView dataGridDocks;
        private DataGridViewTextBoxColumn IdDate;
        private DataGridViewTextBoxColumn HeaderDate;
        private DataGridViewTextBoxColumn CategoryDate;
        private DataGridViewTextBoxColumn ByWhoDate;
        private Button buttonDeleteFromDocks;
        private TextBox textBoxIdDocks;
        private Label label4;
    }
}