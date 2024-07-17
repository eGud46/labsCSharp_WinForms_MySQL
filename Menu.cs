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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }

        private void OutAffairsButton_Click(object sender, EventArgs e)
        {
            string[] logins = { "root", "chief", "oper" };
            if (logins.Contains(LastLogin.lastLogin))
            {
                this.Hide();
                AffairsForm affairsForm = new AffairsForm();
                affairsForm.Show();
            }
            else
                MessageBox.Show("Нет прав.");
        }

        private void OutPeopleButton_Click(object sender, EventArgs e)
        {
            string[] logins = { "root", "chief", "oper" };
            if (logins.Contains(LastLogin.lastLogin))
            {
                this.Hide();
                PeopleForm personForm = new PeopleForm();
                personForm.Show();
            }
            else
                MessageBox.Show("Нет прав.");
        }

        private void OutDateButton_Click(object sender, EventArgs e)
        {
            string[] logins = { "root", "chief", "oper" };
            if (logins.Contains(LastLogin.lastLogin))
            {
                this.Hide();
                DateForm dateForm = new DateForm();
                dateForm.Show();
            }
            else
                MessageBox.Show("Нет прав.");
        }

        private void AddDocksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocksForm docksForm = new DocksForm();
            docksForm.Show();
        }

        private void AddDocksStatus_Click(object sender, EventArgs e)
        {
            string[] logins = { "root", "chief"};
            if (logins.Contains(LastLogin.lastLogin))
            {
                this.Hide();
                DocksStatusForm docksStatusForm = new DocksStatusForm();
                docksStatusForm.Show();
            }
            else
                MessageBox.Show("Нет прав.");
        }

        private void AddAffairsPeople_Click(object sender, EventArgs e)
        {
            string[] logins = { "root", "oper" };
            if (logins.Contains(LastLogin.lastLogin))
            {
                this.Hide();
                PeopleAffairsForm peopleAffairsForm = new PeopleAffairsForm();
                peopleAffairsForm.Show();
            }
            else
                MessageBox.Show("Нет прав.");
        }
    }
}
