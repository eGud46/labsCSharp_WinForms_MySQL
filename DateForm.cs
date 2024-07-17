using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursDBWinForms
{
    public partial class DateForm : Form
    {
        public DateForm()
        {
            InitializeComponent();
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void DateOutButton_Click(object sender, EventArgs e)
        {
            KursdbContext db = new KursdbContext();
            dataGridDate.Rows.Clear();

            if (textBoxComplete.Text == "" && textBoxDateFirst.Text == "" && textBoxDateSecond.Text == "" && textBoxExecutor.Text == "" && textBoxResponsible.Text == "")
            {
                var docks = from dock in db.Docks
                            join dockstatus in db.DocksStatuses on dock.Id equals dockstatus.IdDocks
                            select new
                            {
                                Header = dock.Header,
                                Category = dock.Category,
                                ByWho = dock.ByWho,
                                Executor = dockstatus.Executor,
                                Deadline = dockstatus.Deadline,
                                Responsible = dockstatus.Responsible,
                                Complete = dockstatus.Complete,
                                Id = dock.Id
                            };

                foreach (var dock in docks)
                {
                    dataGridDate.Rows.Add(dock.Id, dock.Header, dock.Category, dock.ByWho, dock.Executor, dock.Deadline, dock.Responsible, dock.Complete);
                }

            }
            else if (textBoxComplete.Text != "" && textBoxDateFirst.Text == "" && textBoxDateSecond.Text == "" && textBoxExecutor.Text == "" && textBoxResponsible.Text == "")
            {
                var docks = from dock in db.Docks
                            join dockstatus in db.DocksStatuses on dock.Id equals dockstatus.IdDocks
                            where dockstatus.Complete == sbyte.Parse(textBoxComplete.Text)
                            select new
                            {
                                Header = dock.Header,
                                Category = dock.Category,
                                ByWho = dock.ByWho,
                                Executor = dockstatus.Executor,
                                Deadline = dockstatus.Deadline,
                                Responsible = dockstatus.Responsible,
                                Complete = dockstatus.Complete,
                                Id = dock.Id
                            };

                foreach (var dock in docks)
                {
                    dataGridDate.Rows.Add(dock.Id, dock.Header, dock.Category, dock.ByWho, dock.Executor, dock.Deadline, dock.Responsible, dock.Complete);
                }
            }
            else if (textBoxComplete.Text == "" && textBoxDateFirst.Text != "" && textBoxDateSecond.Text != "" && textBoxExecutor.Text == "" && textBoxResponsible.Text == "")
            {
                var docks = from dock in db.Docks
                            join dockstatus in db.DocksStatuses on dock.Id equals dockstatus.IdDocks
                            where dockstatus.Deadline >= DateOnly.Parse(textBoxDateFirst.Text) && dockstatus.Deadline <= DateOnly.Parse(textBoxDateSecond.Text)
                            select new
                            {
                                Header = dock.Header,
                                Category = dock.Category,
                                ByWho = dock.ByWho,
                                Executor = dockstatus.Executor,
                                Deadline = dockstatus.Deadline,
                                Responsible = dockstatus.Responsible,
                                Complete = dockstatus.Complete,
                                Id = dock.Id
                            };

                foreach (var dock in docks)
                {
                    dataGridDate.Rows.Add(dock.Id, dock.Header, dock.Category, dock.ByWho, dock.Executor, dock.Deadline, dock.Responsible, dock.Complete);
                }
            }
            else if (textBoxComplete.Text == "" && textBoxDateFirst.Text == "" && textBoxDateSecond.Text == "" && textBoxExecutor.Text != "" && textBoxResponsible.Text == "")
            {
                var docks = from dock in db.Docks
                            join dockstatus in db.DocksStatuses on dock.Id equals dockstatus.IdDocks
                            where dockstatus.Executor.IndexOf(textBoxExecutor.Text) != -1
                            select new
                            {
                                Header = dock.Header,
                                Category = dock.Category,
                                ByWho = dock.ByWho,
                                Executor = dockstatus.Executor,
                                Deadline = dockstatus.Deadline,
                                Responsible = dockstatus.Responsible,
                                Complete = dockstatus.Complete,
                                Id = dock.Id
                            };

                foreach (var dock in docks)
                {
                    dataGridDate.Rows.Add(dock.Id, dock.Header, dock.Category, dock.ByWho, dock.Executor, dock.Deadline, dock.Responsible, dock.Complete);
                }
            }
            else if (textBoxComplete.Text == "" && textBoxDateFirst.Text == "" && textBoxDateSecond.Text == "" && textBoxExecutor.Text == "" && textBoxResponsible.Text != "")
            {
                var docks = from dock in db.Docks
                            join dockstatus in db.DocksStatuses on dock.Id equals dockstatus.IdDocks
                            where dockstatus.Responsible.IndexOf(textBoxResponsible.Text) != -1
                            select new
                            {
                                Header = dock.Header,
                                Category = dock.Category,
                                ByWho = dock.ByWho,
                                Executor = dockstatus.Executor,
                                Deadline = dockstatus.Deadline,
                                Responsible = dockstatus.Responsible,
                                Complete = dockstatus.Complete,
                                Id = dock.Id
                            };

                foreach (var dock in docks)
                {
                    dataGridDate.Rows.Add(dock.Id, dock.Header, dock.Category, dock.ByWho, dock.Executor, dock.Deadline, dock.Responsible, dock.Complete);
                }
            }

            textBoxComplete.Text = String.Empty;
            textBoxDateFirst.Text = String.Empty;
            textBoxDateSecond.Text = String.Empty;
            textBoxExecutor.Text = String.Empty;
            textBoxResponsible.Text = String.Empty;
        }
    }
}
