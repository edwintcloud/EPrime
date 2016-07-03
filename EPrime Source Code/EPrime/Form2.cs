using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPrime
{
    public partial class LoginForm : Form
    {
        private EPrime form1 = null;
        public LoginForm(Form b1)
        {
            InitializeComponent();
            form1 = b1 as EPrime;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var conn = new MySql();
            int login = conn.ParseLogin(usernameBox.Text, passwordBox.Text);
            if (login != -1) {
                loginstatusLbl.Visible = false;
                var adminPanel = new adminForm(usernameBox.Text, login);
                adminPanel.Show();
                form1.Enabled = true;
                Dispose();
            }
            else
            {
                Blink();
            }
        }
        private async void Blink()
        {
            loginstatusLbl.Visible = true;
            await Task.Delay(700);
            loginstatusLbl.Visible = false;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Enabled = true;
        }
    }
}
