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
    public partial class AffairsForm : Form
    {
        public AffairsForm()
        {
            InitializeComponent();
        }

        private void OutAffairsButton_Click(object sender, EventArgs e)
        {
            KursdbContext db = new KursdbContext();

            dataGridAffairs.Rows.Clear();

            if (textBoxResponsible.Text == "" && textBoxCrime.Text == "" && textBoxDocksId.Text == "" && textBoxId.Text == "")
            {
                var affairs = from affair in db.Affairs
                              join dock in db.Docks on affair.IdDocks equals dock.Id
                              select new
                              {
                                  Responsible = affair.Responsible,
                                  CrimeOrNot = affair.CriminalOrNot,
                                  Name = dock.Header,
                                  Category = dock.Category,
                                  byWho = dock.ByWho,
                                  Id = affair.Id
                              };


                foreach (var a in affairs)
                {
                    dataGridAffairs.Rows.Add(a.Id, a.Name, a.Category, a.byWho, a.CrimeOrNot, a.Responsible);
                }
            }
            else if (textBoxResponsible.Text != "" && textBoxCrime.Text == "" && textBoxDocksId.Text == "" && textBoxId.Text == "")
            {
                var affairs = from affair in db.Affairs
                              join dock in db.Docks on affair.IdDocks equals dock.Id
                              where affair.Responsible.IndexOf(textBoxResponsible.Text) != -1
                              select new
                              {
                                  Responsible = affair.Responsible,
                                  CrimeOrNot = affair.CriminalOrNot,
                                  Name = dock.Header,
                                  Category = dock.Category,
                                  byWho = dock.ByWho,
                                  Id = affair.Id
                              };


                foreach (var a in affairs)
                {
                    dataGridAffairs.Rows.Add(a.Id, a.Name, a.Category, a.byWho, a.CrimeOrNot, a.Responsible);
                }
            }
            else if (textBoxResponsible.Text == "" && textBoxCrime.Text != "" && textBoxDocksId.Text == "" && textBoxId.Text == "")
            {
                var affairs = from affair in db.Affairs
                              join dock in db.Docks on affair.IdDocks equals dock.Id
                              where affair.CriminalOrNot == sbyte.Parse(textBoxCrime.Text)
                              select new
                              {
                                  Responsible = affair.Responsible,
                                  CrimeOrNot = affair.CriminalOrNot,
                                  Name = dock.Header,
                                  Category = dock.Category,
                                  byWho = dock.ByWho,
                                  Id = affair.Id
                              };


                foreach (var a in affairs)
                {
                    dataGridAffairs.Rows.Add(a.Id, a.Name, a.Category, a.byWho, a.CrimeOrNot, a.Responsible);
                }
            }
            else if (textBoxResponsible.Text == "" && textBoxCrime.Text == "" && textBoxDocksId.Text != "" && textBoxId.Text == "")
            {
                var affairs = from affair in db.Affairs
                              join dock in db.Docks on affair.IdDocks equals dock.Id
                              where affair.IdDocks == sbyte.Parse(textBoxDocksId.Text)
                              select new
                              {
                                  Responsible = affair.Responsible,
                                  CrimeOrNot = affair.CriminalOrNot,
                                  Name = dock.Header,
                                  Category = dock.Category,
                                  byWho = dock.ByWho,
                                  Id = affair.Id
                              };


                foreach (var a in affairs)
                {
                    dataGridAffairs.Rows.Add(a.Id, a.Name, a.Category, a.byWho, a.CrimeOrNot, a.Responsible);
                }
            }
            else if (textBoxResponsible.Text == "" && textBoxCrime.Text == "" && textBoxDocksId.Text == "" && textBoxId.Text != "")
            {
                var affairs = from affair in db.Affairs
                              join dock in db.Docks on affair.IdDocks equals dock.Id
                              where affair.Id == sbyte.Parse(textBoxId.Text)
                              select new
                              {
                                  Responsible = affair.Responsible,
                                  CrimeOrNot = affair.CriminalOrNot,
                                  Name = dock.Header,
                                  Category = dock.Category,
                                  byWho = dock.ByWho,
                                  Id = affair.Id
                              };


                foreach (var a in affairs)
                {
                    dataGridAffairs.Rows.Add(a.Id, a.Name, a.Category, a.byWho, a.CrimeOrNot, a.Responsible);
                }
            }

            textBoxCrime.Text = String.Empty;
            textBoxDocksId.Text = String.Empty;
            textBoxId.Text = String.Empty;
            textBoxResponsible.Text = String.Empty;
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonDownloadFiles_Click(object sender, EventArgs e)
        {
            dataGridAffairs.Rows.Clear();

            KursdbContext db = new KursdbContext();
            if (textBoxDocksId.Text != "")
            {
                int idAfterParse;
                bool succesIdParse = Int32.TryParse(textBoxDocksId.Text, out idAfterParse);
                if (succesIdParse)
                {
                    Dock? dockTrue = db.Docks.FirstOrDefault(d=>d.Id == idAfterParse);
                    if (dockTrue != null)
                    {
                        var affairs = from affair in db.Affairs
                                      join dock in db.Docks on affair.IdDocks equals dock.Id
                                      where affair.IdDocks == idAfterParse
                                      select new
                                      {
                                          Responsible = affair.Responsible,
                                          CrimeOrNot = affair.CriminalOrNot,
                                          Name = dock.Header,
                                          Category = dock.Category,
                                          byWho = dock.ByWho,
                                          Id = affair.Id
                                      };


                        foreach (var a in affairs)
                        {
                            dataGridAffairs.Rows.Add(a.Id, a.Name, a.Category, a.byWho, a.CrimeOrNot, a.Responsible);
                        }

                        var docksFiles = db.DocksFiles.Where(d => d.IdDocks == idAfterParse).ToList();

                        foreach (var dockfile in docksFiles)
                        {
                            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "Files | *.doc; *.odt", DefaultExt = "odt", AddExtension = true};
                            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
                            {
                                using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                                {
                                    fileStream.Write(dockfile.File, 0, dockfile.File.Length);
                                }
                                
                            }
                        }

                    }
                    else
                        MessageBox.Show("Документа с таким Id не существует.");
                }
                else
                    MessageBox.Show("Не удалось распознать Id документа.");
            }

            textBoxDocksId.Text = String.Empty;
            textBoxCrime.Text = String.Empty;
            textBoxId.Text = String.Empty;
            textBoxResponsible.Text = String.Empty;
        }
    }
}
