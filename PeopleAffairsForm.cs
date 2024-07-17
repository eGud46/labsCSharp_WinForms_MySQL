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
    public partial class PeopleAffairsForm : Form
    {
        public PeopleAffairsForm()
        {
            InitializeComponent();
            labelIdPeople.Visible = textBoxIdPeople.Visible = false;
            labelCriminalRecord.Visible = textBoxCriminalRecord.Visible = false;
            labelAlias.Visible = textBoxAlias.Visible = false;
            labelIdAffairs.Visible = textBoxIdAffairs.Visible = false;
            labelFullname.Visible = textBoxFullname.Visible = false;
            labelBirthday.Visible = textBoxBirhtday.Visible = false;
            labelBiography.Visible = textBoxBiography.Visible = false;
            labelIdDocks.Visible = textBoxIdDocks.Visible = false;
            labelCriminal.Visible = textBoxCriminal.Visible = false;
            labelResponsible.Visible = textBoxResponsible.Visible = false;
            labelPrints.Visible = checkBoxPrints.Visible = false;
            labelPhoto.Visible = checkBoxPhoto.Visible = false;
            labelDocksFile.Visible = checkBoxDockFile.Visible = false;
        }

        private void buttonAddCriminalRecordAlias_Click(object sender, EventArgs e)
        {
            dataGridDocks.Visible = false;
            dataGridAffairs.Visible = false;
            dataGridPeople.Visible = true;

            labelIdPeople.Visible = textBoxIdPeople.Visible = true;
            labelCriminalRecord.Visible = textBoxCriminalRecord.Visible = true;
            labelAlias.Visible = textBoxAlias.Visible = true;
            labelIdAffairs.Visible = textBoxIdAffairs.Visible = false;
            labelFullname.Visible = textBoxFullname.Visible = false;
            labelBirthday.Visible = textBoxBirhtday.Visible = false;
            labelBiography.Visible = textBoxBiography.Visible = false;
            labelIdDocks.Visible = textBoxIdDocks.Visible = false;
            labelCriminal.Visible = textBoxCriminal.Visible = false;
            labelResponsible.Visible = textBoxResponsible.Visible = false;
            labelPrints.Visible = checkBoxPrints.Visible = false;
            labelPhoto.Visible = checkBoxPhoto.Visible = false;
            labelDocksFile.Visible = checkBoxDockFile.Visible = false;

            dataGridPeople.Rows.Clear();

            KursdbContext context = new KursdbContext();

            if (textBoxAlias.Text == "" && textBoxCriminalRecord.Text == "" && textBoxIdPeople.Text == "")
            {
                var peoples = from people in context.People
                              join alias in context.Aliases on people.Id equals alias.IdPeople
                              join criminalrecord in context.CriminalRecords on people.Id equals criminalrecord.IdPeople

                              select new
                              {
                                  Id = people.Id,
                                  Fullname = people.Fullname,
                                  Birthday = people.Birthday,
                                  Biography = people.Biography,
                                  CriminalRecords = criminalrecord.CriminalRecord1,
                                  Alias = alias.Alias1,
                                  Photo = people.Photo,
                                  Prints = people.Print

                              };

                string lastAlias = string.Empty;
                string lastCriminalRecord = string.Empty;
                int lastId = -1;
                foreach (var p in peoples)
                {

                    if (p.Id != lastId)
                        dataGridPeople.Rows.Add(p.Id, p.Fullname, p.Birthday, p.Biography, p.Photo, p.Prints, p.Alias, p.CriminalRecords);
                    else
                    {
                        int lastIndexRow = dataGridPeople.Rows.Count - 1;
                        if (lastAlias != p.Alias)
                            dataGridPeople.Rows[lastIndexRow].Cells[6].Value += "\n" + p.Alias;
                        if (lastCriminalRecord != p.CriminalRecords)
                            dataGridPeople.Rows[lastIndexRow].Cells[7].Value += "\n" + p.CriminalRecords;
                    }
                    lastId = p.Id;
                    lastAlias = p.Alias;
                    lastCriminalRecord = p.CriminalRecords;
                }
            }
            else if (textBoxIdPeople.Text != "" && textBoxAlias.Text != "" && textBoxCriminalRecord.Text == "")
            {
                int idAfterParse;
                bool succesParseId = Int32.TryParse(textBoxIdPeople.Text, out idAfterParse);

                if (succesParseId == true)
                {
                    Person? person = context.People.FirstOrDefault(p => p.Id == idAfterParse);
                    if (person != null)
                    {
                        Alias addAlias = new Alias { IdPeople = idAfterParse, Alias1 = textBoxAlias.Text };
                        context.Aliases.Add(addAlias);

                        Alias? defaultAlias = context.Aliases.FirstOrDefault(a => a.Alias1 == "Отсутствует");
                        if (defaultAlias != null)
                            context.Aliases.Remove(defaultAlias);
                        context.SaveChanges();
                    }
                    else
                        MessageBox.Show("Гражданина с таким Id не найдено!");
                }
                else
                    MessageBox.Show("Не удаётся корректно получить Id гражданина!");

                var peoples = from people in context.People
                              join alias in context.Aliases on people.Id equals alias.IdPeople
                              join criminalrecord in context.CriminalRecords on people.Id equals criminalrecord.IdPeople

                              select new
                              {
                                  Id = people.Id,
                                  Fullname = people.Fullname,
                                  Birthday = people.Birthday,
                                  Biography = people.Biography,
                                  CriminalRecords = criminalrecord.CriminalRecord1,
                                  Alias = alias.Alias1,
                                  Photo = people.Photo,
                                  Prints = people.Print

                              };

                string lastAlias = string.Empty;
                string lastCriminalRecord = string.Empty;
                int lastId = -1;
                foreach (var p in peoples)
                {

                    if (p.Id != lastId)
                        dataGridPeople.Rows.Add(p.Id, p.Fullname, p.Birthday, p.Biography, p.Photo, p.Prints, p.Alias, p.CriminalRecords);
                    else
                    {
                        int lastIndexRow = dataGridPeople.Rows.Count - 1;
                        if (lastAlias != p.Alias)
                            dataGridPeople.Rows[lastIndexRow].Cells[6].Value += "\n" + p.Alias;
                        if (lastCriminalRecord != p.CriminalRecords)
                            dataGridPeople.Rows[lastIndexRow].Cells[7].Value += "\n" + p.CriminalRecords;
                    }
                    lastId = p.Id;
                    lastAlias = p.Alias;
                    lastCriminalRecord = p.CriminalRecords;
                }
            }
            else if (textBoxAlias.Text == "" && textBoxCriminalRecord.Text != "" && textBoxIdPeople.Text != "")
            {
                int idAfterParse;
                bool succesParseId = Int32.TryParse(textBoxIdPeople.Text, out idAfterParse);

                if (succesParseId == true)
                {
                    Person? person = context.People.FirstOrDefault(p => p.Id == idAfterParse);
                    if (person != null)
                    {
                        CriminalRecord addCriminalRecord = new CriminalRecord { IdPeople = idAfterParse, CriminalRecord1 = textBoxCriminalRecord.Text };
                        context.CriminalRecords.Add(addCriminalRecord);

                        CriminalRecord? defaultCriminalRecord = context.CriminalRecords.FirstOrDefault(c => c.CriminalRecord1 == "Отсутствует");
                        if (defaultCriminalRecord != null)
                            context.CriminalRecords.Remove(defaultCriminalRecord);
                        context.SaveChanges();
                    }
                    else
                        MessageBox.Show("Гражданина с таким Id не найдено!");
                }
                else
                    MessageBox.Show("Не удаётся корректно получить Id гражданина!");

                var peoples = from people in context.People
                              join alias in context.Aliases on people.Id equals alias.IdPeople
                              join criminalrecord in context.CriminalRecords on people.Id equals criminalrecord.IdPeople

                              select new
                              {
                                  Id = people.Id,
                                  Fullname = people.Fullname,
                                  Birthday = people.Birthday,
                                  Biography = people.Biography,
                                  CriminalRecords = criminalrecord.CriminalRecord1,
                                  Alias = alias.Alias1,
                                  Photo = people.Photo,
                                  Prints = people.Print

                              };

                string lastAlias = string.Empty;
                string lastCriminalRecord = string.Empty;
                int lastId = -1;
                foreach (var p in peoples)
                {

                    if (p.Id != lastId)
                        dataGridPeople.Rows.Add(p.Id, p.Fullname, p.Birthday, p.Biography, p.Photo, p.Prints, p.Alias, p.CriminalRecords);
                    else
                    {
                        int lastIndexRow = dataGridPeople.Rows.Count - 1;
                        if (lastAlias != p.Alias)
                            dataGridPeople.Rows[lastIndexRow].Cells[6].Value += "\n" + p.Alias;
                        if (lastCriminalRecord != p.CriminalRecords)
                            dataGridPeople.Rows[lastIndexRow].Cells[7].Value += "\n" + p.CriminalRecords;
                    }
                    lastId = p.Id;
                    lastAlias = p.Alias;
                    lastCriminalRecord = p.CriminalRecords;
                }
            }

            textBoxAlias.Text = String.Empty;
            textBoxCriminalRecord.Text = String.Empty;
            textBoxIdPeople.Text = String.Empty;
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonDeleteCriminalRecordAlias_Click(object sender, EventArgs e)
        {
            dataGridDocks.Visible = false;
            dataGridAffairs.Visible = false;
            dataGridPeople.Visible = true;

            labelIdPeople.Visible = textBoxIdPeople.Visible = true;
            labelCriminalRecord.Visible = textBoxCriminalRecord.Visible = true;
            labelAlias.Visible = textBoxAlias.Visible = true;
            labelIdAffairs.Visible = textBoxIdAffairs.Visible = false;
            labelFullname.Visible = textBoxFullname.Visible = false;
            labelBirthday.Visible = textBoxBirhtday.Visible = false;
            labelBiography.Visible = textBoxBiography.Visible = false;
            labelIdDocks.Visible = textBoxIdDocks.Visible = false;
            labelCriminal.Visible = textBoxCriminal.Visible = false;
            labelResponsible.Visible = textBoxResponsible.Visible = false;
            labelPrints.Visible = checkBoxPrints.Visible = false;
            labelPhoto.Visible = checkBoxPhoto.Visible = false;
            labelDocksFile.Visible = checkBoxDockFile.Visible = false;

            dataGridPeople.Rows.Clear();

            KursdbContext context = new KursdbContext();

            if (textBoxAlias.Text == "" && textBoxCriminalRecord.Text == "" && textBoxIdPeople.Text == "")
            {
                var peoples = from people in context.People
                              join alias in context.Aliases on people.Id equals alias.IdPeople
                              join criminalrecord in context.CriminalRecords on people.Id equals criminalrecord.IdPeople

                              select new
                              {
                                  Id = people.Id,
                                  Fullname = people.Fullname,
                                  Birthday = people.Birthday,
                                  Biography = people.Biography,
                                  CriminalRecords = criminalrecord.CriminalRecord1,
                                  Alias = alias.Alias1,
                                  Photo = people.Photo,
                                  Prints = people.Print

                              };

                string lastAlias = string.Empty;
                string lastCriminalRecord = string.Empty;
                int lastId = -1;
                foreach (var p in peoples)
                {

                    if (p.Id != lastId)
                        dataGridPeople.Rows.Add(p.Id, p.Fullname, p.Birthday, p.Biography, p.Photo, p.Prints, p.Alias, p.CriminalRecords);
                    else
                    {
                        int lastIndexRow = dataGridPeople.Rows.Count - 1;
                        if (lastAlias != p.Alias)
                            dataGridPeople.Rows[lastIndexRow].Cells[6].Value += "\n" + p.Alias;
                        if (lastCriminalRecord != p.CriminalRecords)
                            dataGridPeople.Rows[lastIndexRow].Cells[7].Value += "\n" + p.CriminalRecords;
                    }
                    lastId = p.Id;
                    lastAlias = p.Alias;
                    lastCriminalRecord = p.CriminalRecords;
                }
            }
            else if (textBoxIdPeople.Text != "" && textBoxAlias.Text != "" && textBoxCriminalRecord.Text == "")
            {
                int idAfterParse;
                bool succesParseId = Int32.TryParse(textBoxIdPeople.Text, out idAfterParse);

                if (succesParseId == true)
                {
                    Person? person = context.People.FirstOrDefault(p => p.Id == idAfterParse);
                    if (person != null)
                    {
                        Alias? alias = context.Aliases.FirstOrDefault(p => p.IdPeople == idAfterParse && p.Alias1 == textBoxAlias.Text);
                        if (alias != null)
                        {
                            Alias? delAlias = context.Aliases.FirstOrDefault(a => a.Alias1 == textBoxAlias.Text);
                            if (delAlias != null)
                                context.Aliases.Remove(delAlias);
                            context.SaveChanges();
                        }
                        else
                            MessageBox.Show("Такого прозвища данный гражданнин не имеет!");
                    }
                    else
                        MessageBox.Show("Гражданина с таким Id не найдено!");
                }
                else
                    MessageBox.Show("Не удаётся корректно получить Id гражданина!");

                var peoples = from people in context.People
                              join alias in context.Aliases on people.Id equals alias.IdPeople
                              join criminalrecord in context.CriminalRecords on people.Id equals criminalrecord.IdPeople

                              select new
                              {
                                  Id = people.Id,
                                  Fullname = people.Fullname,
                                  Birthday = people.Birthday,
                                  Biography = people.Biography,
                                  CriminalRecords = criminalrecord.CriminalRecord1,
                                  Alias = alias.Alias1,
                                  Photo = people.Photo,
                                  Prints = people.Print

                              };

                string lastAlias = string.Empty;
                string lastCriminalRecord = string.Empty;
                int lastId = -1;
                foreach (var p in peoples)
                {

                    if (p.Id != lastId)
                        dataGridPeople.Rows.Add(p.Id, p.Fullname, p.Birthday, p.Biography, p.Photo, p.Prints, p.Alias, p.CriminalRecords);
                    else
                    {
                        int lastIndexRow = dataGridPeople.Rows.Count - 1;
                        if (lastAlias != p.Alias)
                            dataGridPeople.Rows[lastIndexRow].Cells[6].Value += "\n" + p.Alias;
                        if (lastCriminalRecord != p.CriminalRecords)
                            dataGridPeople.Rows[lastIndexRow].Cells[7].Value += "\n" + p.CriminalRecords;
                    }
                    lastId = p.Id;
                    lastAlias = p.Alias;
                    lastCriminalRecord = p.CriminalRecords;
                }
            }
            else if (textBoxAlias.Text == "" && textBoxCriminalRecord.Text != "" && textBoxIdPeople.Text != "")
            {
                int idAfterParse;
                bool succesParseId = Int32.TryParse(textBoxIdPeople.Text, out idAfterParse);

                if (succesParseId == true)
                {
                    Person? person = context.People.FirstOrDefault(p => p.Id == idAfterParse);
                    if (person != null)
                    {
                        CriminalRecord? criminalRecord = context.CriminalRecords.FirstOrDefault(p => p.IdPeople == idAfterParse && p.CriminalRecord1 == textBoxCriminalRecord.Text);
                        if (criminalRecord != null)
                        {
                            CriminalRecord? delCriminalRecord = context.CriminalRecords.FirstOrDefault(c => c.CriminalRecord1 == textBoxCriminalRecord.Text);
                            if (delCriminalRecord != null)
                                context.CriminalRecords.Remove(delCriminalRecord);
                            context.SaveChanges();
                        }
                        else
                            MessageBox.Show("Такой статьи гражданин не имеет, проверьте корректность введеной статьи.");
                    }
                    else
                        MessageBox.Show("Гражданина с таким Id не найдено!");
                }
                else
                    MessageBox.Show("Не удаётся корректно получить Id гражданина!");

                var peoples = from people in context.People
                              join alias in context.Aliases on people.Id equals alias.IdPeople
                              join criminalrecord in context.CriminalRecords on people.Id equals criminalrecord.IdPeople

                              select new
                              {
                                  Id = people.Id,
                                  Fullname = people.Fullname,
                                  Birthday = people.Birthday,
                                  Biography = people.Biography,
                                  CriminalRecords = criminalrecord.CriminalRecord1,
                                  Alias = alias.Alias1,
                                  Photo = people.Photo,
                                  Prints = people.Print

                              };

                string lastAlias = string.Empty;
                string lastCriminalRecord = string.Empty;
                int lastId = -1;
                foreach (var p in peoples)
                {

                    if (p.Id != lastId)
                        dataGridPeople.Rows.Add(p.Id, p.Fullname, p.Birthday, p.Biography, p.Photo, p.Prints, p.Alias, p.CriminalRecords);
                    else
                    {
                        int lastIndexRow = dataGridPeople.Rows.Count - 1;
                        if (lastAlias != p.Alias)
                            dataGridPeople.Rows[lastIndexRow].Cells[6].Value += "\n" + p.Alias;
                        if (lastCriminalRecord != p.CriminalRecords)
                            dataGridPeople.Rows[lastIndexRow].Cells[7].Value += "\n" + p.CriminalRecords;
                    }
                    lastId = p.Id;
                    lastAlias = p.Alias;
                    lastCriminalRecord = p.CriminalRecords;
                }
            }

            textBoxAlias.Text = String.Empty;
            textBoxCriminalRecord.Text = String.Empty;
            textBoxIdPeople.Text = String.Empty;
        }

        private void buttonAddPeople_Click(object sender, EventArgs e)
        {
            dataGridDocks.Visible = false;
            dataGridAffairs.Visible = false;
            dataGridPeople.Visible = true;

            labelIdPeople.Visible = textBoxIdPeople.Visible = false;
            labelCriminalRecord.Visible = textBoxCriminalRecord.Visible = false;
            labelAlias.Visible = textBoxAlias.Visible = false;
            labelIdAffairs.Visible = textBoxIdAffairs.Visible = true;
            labelFullname.Visible = textBoxFullname.Visible = true;
            labelBirthday.Visible = textBoxBirhtday.Visible = true;
            labelBiography.Visible = textBoxBiography.Visible = true;
            labelIdDocks.Visible = textBoxIdDocks.Visible = false;
            labelCriminal.Visible = textBoxCriminal.Visible = false;
            labelResponsible.Visible = textBoxResponsible.Visible = false;
            labelPrints.Visible = checkBoxPrints.Visible = true;
            labelPhoto.Visible = checkBoxPhoto.Visible = true;
            labelDocksFile.Visible = checkBoxDockFile.Visible = false;

            dataGridPeople.Rows.Clear();

            KursdbContext context = new KursdbContext();

            if (textBoxIdAffairs.Text == "" && textBoxFullname.Text == "" && textBoxBirhtday.Text == "" && textBoxBiography.Text == "")
            {
                var peoples = from people in context.People
                              join alias in context.Aliases on people.Id equals alias.IdPeople
                              join criminalrecord in context.CriminalRecords on people.Id equals criminalrecord.IdPeople

                              select new
                              {
                                  Id = people.Id,
                                  Fullname = people.Fullname,
                                  Birthday = people.Birthday,
                                  Biography = people.Biography,
                                  CriminalRecords = criminalrecord.CriminalRecord1,
                                  Alias = alias.Alias1,
                                  Photo = people.Photo,
                                  Prints = people.Print

                              };

                string lastAlias = string.Empty;
                string lastCriminalRecord = string.Empty;
                int lastId = -1;
                foreach (var p in peoples)
                {

                    if (p.Id != lastId)
                        dataGridPeople.Rows.Add(p.Id, p.Fullname, p.Birthday, p.Biography, p.Photo, p.Prints, p.Alias, p.CriminalRecords);
                    else
                    {
                        int lastIndexRow = dataGridPeople.Rows.Count - 1;
                        if (lastAlias != p.Alias)
                            dataGridPeople.Rows[lastIndexRow].Cells[6].Value += "\n" + p.Alias;
                        if (lastCriminalRecord != p.CriminalRecords)
                            dataGridPeople.Rows[lastIndexRow].Cells[7].Value += "\n" + p.CriminalRecords;
                    }
                    lastId = p.Id;
                    lastAlias = p.Alias;
                    lastCriminalRecord = p.CriminalRecords;
                }
            }
            else if (textBoxIdAffairs.Text != "" && textBoxFullname.Text != "" && textBoxBirhtday.Text != "" && textBoxBiography.Text != "")
            {
                int idAfterParse;
                bool succesIdParse = Int32.TryParse(textBoxIdAffairs.Text, out idAfterParse);

                if (succesIdParse == true)
                {
                    Affair? affair = context.Affairs.FirstOrDefault(a => a.Id == idAfterParse);
                    if (affair != null)
                    {
                        DateOnly birthdayAfterParse;
                        bool succesBirthdayParse = DateOnly.TryParse(textBoxBirhtday.Text, out birthdayAfterParse);

                        if (succesBirthdayParse == true)
                        {
                            byte[]? Photoimage = null;
                            byte[]? Printsimage = null;

                            if (checkBoxPhoto.Checked)
                            {
                                OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Photo | *.bmp; *.png; *.jpg; *.JPEG" };
                                openFileDialog.ShowDialog();
                                Photoimage = File.ReadAllBytes(openFileDialog.FileName);
                            }
                            if (checkBoxPrints.Checked)
                            {
                                OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Prints | *.bmp; *.png; *.jpg; *.JPEG" };
                                openFileDialog.ShowDialog();
                                Printsimage = File.ReadAllBytes(openFileDialog.FileName);
                            }


                            Person addPerson = new Person { Fullname = textBoxFullname.Text, Birthday = birthdayAfterParse, Biography = textBoxBiography.Text, Photo = Photoimage, Print = Printsimage };
                            context.People.Add(addPerson);
                            context.SaveChanges();

                            Person lastPerson = context.People.OrderBy(p => p.Id).Last();

                            AffairsPerson affairsPerson = new AffairsPerson { IdAffairs = idAfterParse, IdPeople = lastPerson.Id };
                            context.AffairsPeople.Add(affairsPerson);

                            CriminalRecord criminalRecord = new CriminalRecord { IdPeople = lastPerson.Id, CriminalRecord1 = "Отсутствует" };
                            context.CriminalRecords.Add(criminalRecord);

                            Alias alias = new Alias { IdPeople = lastPerson.Id, Alias1 = "Отсутствует" };
                            context.Aliases.Add(alias);

                            context.SaveChanges();
                        }
                        else
                            MessageBox.Show("Не удалось корректно получить дату рождения!");
                    }
                    else
                        MessageBox.Show("Дела с таким Id не существует!");
                }
                else
                    MessageBox.Show("Не удалось корректно получить Id дела!");

                var peoples = from people in context.People
                              join alias in context.Aliases on people.Id equals alias.IdPeople
                              join criminalrecord in context.CriminalRecords on people.Id equals criminalrecord.IdPeople

                              select new
                              {
                                  Id = people.Id,
                                  Fullname = people.Fullname,
                                  Birthday = people.Birthday,
                                  Biography = people.Biography,
                                  CriminalRecords = criminalrecord.CriminalRecord1,
                                  Alias = alias.Alias1,
                                  Photo = people.Photo,
                                  Prints = people.Print

                              };

                string lastAlias = string.Empty;
                string lastCriminalRecord = string.Empty;
                int lastId = -1;
                foreach (var p in peoples)
                {

                    if (p.Id != lastId)
                        dataGridPeople.Rows.Add(p.Id, p.Fullname, p.Birthday, p.Biography, p.Photo, p.Prints, p.Alias, p.CriminalRecords);
                    else
                    {
                        int lastIndexRow = dataGridPeople.Rows.Count - 1;
                        if (lastAlias != p.Alias)
                            dataGridPeople.Rows[lastIndexRow].Cells[6].Value += "\n" + p.Alias;
                        if (lastCriminalRecord != p.CriminalRecords)
                            dataGridPeople.Rows[lastIndexRow].Cells[7].Value += "\n" + p.CriminalRecords;
                    }
                    lastId = p.Id;
                    lastAlias = p.Alias;
                    lastCriminalRecord = p.CriminalRecords;
                }
            }



            textBoxBiography.Text = String.Empty;
            textBoxBirhtday.Text = String.Empty;
            textBoxFullname.Text = String.Empty;
            textBoxIdAffairs.Text = String.Empty;
        }

        private void buttonDeletePeople_Click(object sender, EventArgs e)
        {
            dataGridDocks.Visible = false;
            dataGridAffairs.Visible = false;
            dataGridPeople.Visible = true;

            labelIdPeople.Visible = textBoxIdPeople.Visible = true;
            labelCriminalRecord.Visible = textBoxCriminalRecord.Visible = false;
            labelAlias.Visible = textBoxAlias.Visible = false;
            labelIdAffairs.Visible = textBoxIdAffairs.Visible = false;
            labelFullname.Visible = textBoxFullname.Visible = false;
            labelBirthday.Visible = textBoxBirhtday.Visible = false;
            labelBiography.Visible = textBoxBiography.Visible = false;
            labelIdDocks.Visible = textBoxIdDocks.Visible = false;
            labelCriminal.Visible = textBoxCriminal.Visible = false;
            labelResponsible.Visible = textBoxResponsible.Visible = false;
            labelPrints.Visible = checkBoxPrints.Visible = false;
            labelPhoto.Visible = checkBoxPhoto.Visible = false;
            labelDocksFile.Visible = checkBoxDockFile.Visible = false;

            dataGridPeople.Rows.Clear();

            KursdbContext context = new KursdbContext();

            if (textBoxIdPeople.Text != "")
            {
                int idAfterParse;
                bool succesIdParse = Int32.TryParse(textBoxIdPeople.Text, out idAfterParse);

                if (succesIdParse == true)
                {
                    Person? person = context.People.FirstOrDefault(a => a.Id == idAfterParse);
                    if (person != null)
                    {

                        context.People.Remove(person);
                        context.SaveChanges();

                    }
                    else
                        MessageBox.Show("Гражданина с таким Id не существует!");
                }
                else
                    MessageBox.Show("Не удалось корректно получить Id гражданина!");
            }

            var peoples = from people in context.People
                          join alias in context.Aliases on people.Id equals alias.IdPeople
                          join criminalrecord in context.CriminalRecords on people.Id equals criminalrecord.IdPeople

                          select new
                          {
                              Id = people.Id,
                              Fullname = people.Fullname,
                              Birthday = people.Birthday,
                              Biography = people.Biography,
                              CriminalRecords = criminalrecord.CriminalRecord1,
                              Alias = alias.Alias1,
                              Photo = people.Photo,
                              Prints = people.Print

                          };

            string lastAlias = string.Empty;
            string lastCriminalRecord = string.Empty;
            int lastId = -1;
            foreach (var p in peoples)
            {

                if (p.Id != lastId)
                    dataGridPeople.Rows.Add(p.Id, p.Fullname, p.Birthday, p.Biography, p.Photo, p.Prints, p.Alias, p.CriminalRecords);
                else
                {
                    int lastIndexRow = dataGridPeople.Rows.Count - 1;
                    if (lastAlias != p.Alias)
                        dataGridPeople.Rows[lastIndexRow].Cells[6].Value += "\n" + p.Alias;
                    if (lastCriminalRecord != p.CriminalRecords)
                        dataGridPeople.Rows[lastIndexRow].Cells[7].Value += "\n" + p.CriminalRecords;
                }
                lastId = p.Id;
                lastAlias = p.Alias;
                lastCriminalRecord = p.CriminalRecords;
            }

            textBoxBiography.Text = String.Empty;
            textBoxBirhtday.Text = String.Empty;
            textBoxFullname.Text = String.Empty;
            textBoxIdAffairs.Text = String.Empty;
            textBoxIdPeople.Text = String.Empty;
        }

        private void buttonDocksWithoutAffairs_Click(object sender, EventArgs e)
        {
            dataGridPeople.Visible = false;
            dataGridAffairs.Visible = false;
            dataGridDocks.Visible = true;

            labelIdPeople.Visible = textBoxIdPeople.Visible = false;
            labelCriminalRecord.Visible = textBoxCriminalRecord.Visible = false;
            labelAlias.Visible = textBoxAlias.Visible = false;
            labelIdAffairs.Visible = textBoxIdAffairs.Visible = false;
            labelFullname.Visible = textBoxFullname.Visible = false;
            labelBirthday.Visible = textBoxBirhtday.Visible = false;
            labelBiography.Visible = textBoxBiography.Visible = false;
            labelIdDocks.Visible = textBoxIdDocks.Visible = false;
            labelCriminal.Visible = textBoxCriminal.Visible = false;
            labelResponsible.Visible = textBoxResponsible.Visible = false;
            labelPrints.Visible = checkBoxPrints.Visible = false;
            labelPhoto.Visible = checkBoxPhoto.Visible = false;
            labelDocksFile.Visible = checkBoxDockFile.Visible = false;

            dataGridDocks.Rows.Clear();

            KursdbContext context = new KursdbContext();



            var Affairs = context.Affairs.ToList();
            int[] idDocksArr = new int[Affairs.Count]; int i = 0;
            foreach (var affair in Affairs)
            {
                idDocksArr[i] = affair.IdDocks;
                i++;
            }

            var DocksWithoutAffairs = from dock in context.Docks
                                      where !idDocksArr.Contains(dock.Id)
                                      select dock;

            foreach (var docks in DocksWithoutAffairs)
            {
                dataGridDocks.Rows.Add(docks.Id, docks.Header, docks.Category, docks.ByWho);
            }
        }

        private void buttonAddAffairs_Click(object sender, EventArgs e)
        {
            dataGridPeople.Visible = false;
            dataGridDocks.Visible = false;
            dataGridAffairs.Visible = true;

            labelIdPeople.Visible = textBoxIdPeople.Visible = false;
            labelCriminalRecord.Visible = textBoxCriminalRecord.Visible = false;
            labelAlias.Visible = textBoxAlias.Visible = false;
            labelIdAffairs.Visible = textBoxIdAffairs.Visible = false;
            labelFullname.Visible = textBoxFullname.Visible = false;
            labelBirthday.Visible = textBoxBirhtday.Visible = false;
            labelBiography.Visible = textBoxBiography.Visible = false;
            labelIdDocks.Visible = textBoxIdDocks.Visible = true;
            labelCriminal.Visible = textBoxCriminal.Visible = true;
            labelResponsible.Visible = textBoxResponsible.Visible = true;
            labelPrints.Visible = checkBoxPrints.Visible = false;
            labelPhoto.Visible = checkBoxPhoto.Visible = false;
            labelDocksFile.Visible = checkBoxDockFile.Visible = true;


            dataGridAffairs.Rows.Clear();

            KursdbContext context = new KursdbContext();

            if (textBoxIdDocks.Text != "" && textBoxCriminal.Text != "" && textBoxResponsible.Text != "")
            {
                int idAfterParse;
                bool succesIdParse = Int32.TryParse(textBoxIdDocks.Text, out idAfterParse);
                if (succesIdParse)
                {
                    Dock? dock = context.Docks.FirstOrDefault(d => d.Id == idAfterParse);
                    if (dock != null)
                    {
                        sbyte criminalAfterParse;
                        bool succesCriminalParse = sbyte.TryParse(textBoxCriminal.Text, out criminalAfterParse);
                        if (succesCriminalParse && (criminalAfterParse == 1 || criminalAfterParse == 0))
                        {
                            byte[]? dockPdf = null;

                            if (checkBoxDockFile.Checked)
                            {
                                OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Files | *.doc; *.odt" };
                                openFileDialog.ShowDialog();
                                dockPdf = File.ReadAllBytes(openFileDialog.FileName);
                            }

                            DocksFile docksFile = new DocksFile { IdDocks = idAfterParse, File = dockPdf};
                            context.DocksFiles.Add(docksFile);

                            Affair addAffairs = new Affair { IdDocks = idAfterParse, Responsible = textBoxResponsible.Text, CriminalOrNot = criminalAfterParse };
                            context.Affairs.Add(addAffairs);
                            
                            context.SaveChanges();
                        }
                        else
                            MessageBox.Show("Распознать криминальное или нет не удалось. 0 или 1");
                    }
                    else
                        MessageBox.Show("Документа с таким id не существует.");
                }
                else
                    MessageBox.Show("Распознать Id документа не удалось.");

                var affairs = from affair in context.Affairs
                              join dock in context.Docks on affair.IdDocks equals dock.Id
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

            if (textBoxIdDocks.Text == "" && textBoxCriminal.Text == "" && textBoxResponsible.Text == "")
            {
                var affairs = from affair in context.Affairs
                              join dock in context.Docks on affair.IdDocks equals dock.Id
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
            textBoxIdDocks.Text = string.Empty;
            textBoxCriminal.Text = string.Empty;
            textBoxResponsible.Text = string.Empty;


        }

        private void buttonDeleteAffairs_Click(object sender, EventArgs e)
        {
            dataGridPeople.Visible = false;
            dataGridDocks.Visible = false;
            dataGridAffairs.Visible = true;

            labelIdPeople.Visible = textBoxIdPeople.Visible = false;
            labelCriminalRecord.Visible = textBoxCriminalRecord.Visible = false;
            labelAlias.Visible = textBoxAlias.Visible = false;
            labelIdAffairs.Visible = textBoxIdAffairs.Visible = true;
            labelFullname.Visible = textBoxFullname.Visible = false;
            labelBirthday.Visible = textBoxBirhtday.Visible = false;
            labelBiography.Visible = textBoxBiography.Visible = false;
            labelIdDocks.Visible = textBoxIdDocks.Visible = false;
            labelCriminal.Visible = textBoxCriminal.Visible = false;
            labelResponsible.Visible = textBoxResponsible.Visible = false;
            labelPrints.Visible = checkBoxPrints.Visible = false;
            labelPhoto.Visible = checkBoxPhoto.Visible = false;
            labelDocksFile.Visible = checkBoxDockFile.Visible = false;

            dataGridAffairs.Rows.Clear();

            KursdbContext context = new KursdbContext();

            if (textBoxIdAffairs.Text != "")
            {
                int idAfterParse;
                bool succesIdParse = Int32.TryParse(textBoxIdAffairs.Text, out idAfterParse);
                if (succesIdParse)
                {
                    Affair? affair = context.Affairs.FirstOrDefault(a => a.Id == idAfterParse);
                    if (affair != null)
                    {
                        context.Affairs.Remove(affair);
                        context.SaveChanges();
                    }
                    else
                        MessageBox.Show("Дела с таким Id не существует.");
                }
                else
                    MessageBox.Show("Не удалось распарсить Id дела.");
            }


            var affairs = from affair in context.Affairs
                          join dock in context.Docks on affair.IdDocks equals dock.Id
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

            textBoxIdDocks.Text = string.Empty;
            textBoxCriminal.Text = string.Empty;
            textBoxResponsible.Text = string.Empty;
        }
    }
}
