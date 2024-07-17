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

    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();

            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String loginUser = LoginTextBox.Text;
            String passwordUser = PasswordTextBox.Text;

            string[] logins = { "root", "duty", "chief", "oper" };

            if (logins.Contains(loginUser) && passwordUser == "1234")
            {
                LastLogin.lastLogin = loginUser;
                this.Hide();
                Menu menu = new Menu();
                menu.Show();

            }


            LoginTextBox.Text = "";
            PasswordTextBox.Text = "";

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
