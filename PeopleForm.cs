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
    public partial class PeopleForm : Form
    {
        public PeopleForm()
        {
            InitializeComponent();
        }

        private void PeopleOutButton_Click(object sender, EventArgs e)
        {
            KursdbContext db = new KursdbContext();

            dataGridPeople.Rows.Clear();

            if (textBoxAffairsId.Text == "" && textBoxAlias.Text == "" && textBoxBirthday.Text == "" && textBoxFullname.Text == "")
            {
                var peoples = from people in db.People
                              join alias in db.Aliases on people.Id equals alias.IdPeople
                              join criminalrecord in db.CriminalRecords on people.Id equals criminalrecord.IdPeople

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
            else if (textBoxAffairsId.Text != "" && textBoxAlias.Text == "" && textBoxBirthday.Text == "" && textBoxFullname.Text == "")
            {
                var peoples = from people in db.People
                              join alias in db.Aliases on people.Id equals alias.IdPeople
                              join criminalrecord in db.CriminalRecords on people.Id equals criminalrecord.IdPeople
                              join affairspeople in db.AffairsPeople on people.Id equals affairspeople.IdPeople
                              join affairs in db.Affairs on affairspeople.IdAffairs equals affairs.Id
                              where affairs.Id == Int32.Parse(textBoxAffairsId.Text)
                              select new
                              {
                                  Id = people.Id,
                                  Fullname = people.Fullname,
                                  Birthday = people.Birthday,
                                  Biography = people.Biography,
                                  CriminalRecords = criminalrecord.CriminalRecord1,
                                  Alias = alias.Alias1,
                                  Affair_Id = affairs.Id,
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
            else if (textBoxAffairsId.Text == "" && textBoxAlias.Text != "" && textBoxBirthday.Text == "" && textBoxFullname.Text == "")
            {
                var peoples = from people in db.People
                              join alias in db.Aliases on people.Id equals alias.IdPeople
                              join criminalrecord in db.CriminalRecords on people.Id equals criminalrecord.IdPeople
                              where alias.Alias1.IndexOf(textBoxAlias.Text) != -1
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
            else if (textBoxAffairsId.Text == "" && textBoxAlias.Text == "" && textBoxBirthday.Text != "" && textBoxFullname.Text == "")
            {
                var peoples = from people in db.People
                              join alias in db.Aliases on people.Id equals alias.IdPeople
                              join criminalrecord in db.CriminalRecords on people.Id equals criminalrecord.IdPeople
                              where people.Birthday == DateOnly.Parse(textBoxBirthday.Text)
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
            else if (textBoxAffairsId.Text == "" && textBoxAlias.Text == "" && textBoxBirthday.Text == "" && textBoxFullname.Text != "")
            {
                var peoples = from people in db.People
                              join alias in db.Aliases on people.Id equals alias.IdPeople
                              join criminalrecord in db.CriminalRecords on people.Id equals criminalrecord.IdPeople
                              where people.Fullname.IndexOf(textBoxFullname.Text) != -1
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

            textBoxAffairsId.Text = String.Empty;
            textBoxAlias.Text = String.Empty;
            textBoxBirthday.Text = String.Empty;
            textBoxFullname.Text = String.Empty;
            
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }


    }
}
