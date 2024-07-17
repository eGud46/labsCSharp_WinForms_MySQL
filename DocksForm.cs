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
    public partial class DocksForm : Form
    {
        public DocksForm()
        {
            InitializeComponent();
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonAddDock_Click(object sender, EventArgs e)
        {
            KursdbContext context = new KursdbContext();
            if (textBoxByWho.Text != "" || textBoxCategory.Text != "" || textBoxHeader.Text != "")
            {
                Dock newDock = new Dock { Header = textBoxHeader.Text, Category = textBoxCategory.Text, ByWho = textBoxByWho.Text };
                context.Docks.Add(newDock);
                context.SaveChanges();
            }
            dataGridDocks.Rows.Clear();

            var docks = context.Docks.ToList();

            foreach (var dock in docks)
            {
                dataGridDocks.Rows.Add(dock.Id, dock.Header, dock.Category, dock.ByWho);
            }

            textBoxByWho.Text = String.Empty;
            textBoxCategory.Text = String.Empty;
            textBoxHeader.Text = String.Empty;
        }

        private void buttonDeleteFromDocks_Click(object sender, EventArgs e)
        {
            KursdbContext context = new KursdbContext();
            if (textBoxIdDocks.Text != "")
            {
                int parseId;
                bool succesParse = Int32.TryParse(textBoxIdDocks.Text, out parseId);
                if (succesParse)
                {
                    Dock? deleteDock = context.Docks.FirstOrDefault(d => d.Id == parseId);
                    if (deleteDock != null)
                    {
                        context.Docks.Remove(deleteDock);
                        context.SaveChanges();
                    }
                    else
                        MessageBox.Show("Документа с таким Id не найдено!");
                }
                else
                    MessageBox.Show("Невозможно распознать Id документа!");
                
            }
            
            dataGridDocks.Rows.Clear();

            var docks = context.Docks.ToList();

            foreach (var dock in docks)
            {
                dataGridDocks.Rows.Add(dock.Id, dock.Header, dock.Category, dock.ByWho);
            }

            textBoxByWho.Text = String.Empty;
            textBoxCategory.Text = String.Empty;
            textBoxHeader.Text = String.Empty;
            textBoxIdDocks.Text = String.Empty;
        }
    }
}
