using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursDBWinForms
{
    public partial class DocksStatusForm : Form
    {
        public DocksStatusForm()
        {
            InitializeComponent();
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonAddDocksStatus_Click(object sender, EventArgs e)
        {
            dataGridDocks.Visible = false;
            dataGridDocksStatuses.Visible = true;

            KursdbContext context = new KursdbContext();

            dataGridDocksStatuses.Rows.Clear();

            if (textBoxComplete.Text == "" && textBoxDeadline.Text == "" && textBoxExecutor.Text == "" && textBoxIdDocks.Text == "" && textBoxResponsible.Text == "")
            {
                var dockStatuses = context.DocksStatuses.ToList();

                foreach (var dockStatus in dockStatuses)
                {
                    dataGridDocksStatuses.Rows.Add(dockStatus.IdDocks, dockStatus.Executor, dockStatus.Deadline, dockStatus.Responsible, dockStatus.Complete);
                }
            }
            else if (textBoxComplete.Text != "" && textBoxDeadline.Text != "" && textBoxExecutor.Text != "" && textBoxIdDocks.Text != "" && textBoxResponsible.Text != "")
            {
                int IdAfterParse;

                bool succesParseId = Int32.TryParse(textBoxIdDocks.Text, out IdAfterParse);
                if (succesParseId == true)
                {
                    DocksStatus? docksStatus = context.DocksStatuses.FirstOrDefault(d=>d.IdDocks == IdAfterParse);
                    Dock? idDockStatuses = context.Docks.FirstOrDefault(i => i.Id == IdAfterParse);
                    if (idDockStatuses != null)
                    {
                        if (docksStatus == null)
                        {
                            sbyte CompleteAfterParse;
                            bool succesParseComplete = sbyte.TryParse(textBoxComplete.Text, out CompleteAfterParse);
                            if (succesParseComplete == true && (CompleteAfterParse == 1 || CompleteAfterParse == 0))
                            {
                                DateOnly DeadlineAfterParse;
                                bool succesParseDeadline = DateOnly.TryParse(textBoxDeadline.Text, out DeadlineAfterParse);
                                if (succesParseDeadline == true)
                                {
                                    DocksStatus dockStatusToAdd = new DocksStatus { IdDocks = IdAfterParse, Executor = textBoxExecutor.Text, Responsible = textBoxResponsible.Text, Complete = CompleteAfterParse, Deadline = DeadlineAfterParse };
                                    context.DocksStatuses.Add(dockStatusToAdd);
                                    context.SaveChanges();
                                }
                                else
                                    MessageBox.Show("Неправильный формат даты, попробуйте иначе!");
                            }
                            else
                                MessageBox.Show("Complete принимает параметры 0 или 1!");
                        }
                        else
                            MessageBox.Show("Запись на такой Id уже есть!");
                    }
                    else
                        MessageBox.Show("Документа с таким Id не существует!");
                }
                else
                    MessageBox.Show("Id не распознан!");


                var dockStatuses = context.DocksStatuses.ToList();

                foreach (var dockStatus in dockStatuses)
                {
                    dataGridDocksStatuses.Rows.Add(dockStatus.IdDocks, dockStatus.Executor, dockStatus.Deadline, dockStatus.Responsible, dockStatus.Complete);
                }
            }
            else
                MessageBox.Show("Заполните все textBox'ы или ни одного для вывода всех существующих.");

            textBoxComplete.Text = String.Empty;
            textBoxDeadline.Text = String.Empty;
            textBoxExecutor.Text = String.Empty;
            textBoxIdDocks.Text = String.Empty;
            textBoxResponsible.Text = String.Empty;
        }

        private void buttonWithoutStatuses_Click(object sender, EventArgs e)
        {
            dataGridDocksStatuses.Visible = false;
            dataGridDocks.Visible = true;

            KursdbContext context = new KursdbContext();

            dataGridDocks.Rows.Clear();

            var DocksWithoutStatuses = (from docks in context.Docks.Include(p => p.DocksStatus)
                                        where docks.Id != docks.DocksStatus.IdDocks
                                        select docks).ToList();

            foreach (var dock in DocksWithoutStatuses)
            {
                dataGridDocks.Rows.Add(dock.Id, dock.Header, dock.Category, dock.ByWho);

            }

            textBoxComplete.Text = String.Empty;
            textBoxDeadline.Text = String.Empty;
            textBoxExecutor.Text = String.Empty;
            textBoxIdDocks.Text = String.Empty;
            textBoxResponsible.Text = String.Empty;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataGridDocks.Visible = false;
            dataGridDocksStatuses.Visible = true;

            KursdbContext context = new KursdbContext();

            if (textBoxIdDocks.Text != "")
            {
                int parseId;
                bool succesParse = Int32.TryParse(textBoxIdDocks.Text, out parseId);
                if (succesParse)
                {
                    DocksStatus? deleteDocksStatus = context.DocksStatuses.FirstOrDefault(d => d.IdDocks == parseId);
                    if (deleteDocksStatus != null)
                    {
                        context.DocksStatuses.Remove(deleteDocksStatus);
                        context.SaveChanges();
                    }
                    else
                        MessageBox.Show("Статуса документа с таким Id не найдено!");
                }
                else
                    MessageBox.Show("Невозможно распознать Id статуса документа!");
            }

            dataGridDocksStatuses.Rows.Clear();

            var docksStatuses = context.DocksStatuses.ToList();

            foreach (var docksStatus in docksStatuses)
            {
                dataGridDocksStatuses.Rows.Add(docksStatus.IdDocks, docksStatus.Executor, docksStatus.Deadline, docksStatus.Responsible, docksStatus.Complete);
            }

            textBoxComplete.Text = String.Empty;
            textBoxDeadline.Text = String.Empty;
            textBoxExecutor.Text = String.Empty;
            textBoxIdDocks.Text = String.Empty;
            textBoxResponsible.Text = String.Empty;
        }
    }
}
