using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP5.source.GUI.Forms
{
    using source.Core;

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            if (SessionManager.Instance.Login(usernameBox.Text, passwordBox.Text))
            {
                usernameBox.Text = "";
                passwordBox.Text = "";
                // if (SessionManager.Instance.currentUser.UserAccountType == User.AccountType.ADMINISTRATOR)
                // {
                //     SessionManager.Instance.openForms[1].Hide();
                //     var Form = (AdminPostLogin)SessionManager.Instance.openForms[4];
                //     Form.UpdateUserText();
                //     SessionManager.Instance.openForms[4].Show();
                // }
                // else
                // {
                //     SessionManager.Instance.openForms[1].Hide();
                //     var Form = (PostLogin)SessionManager.Instance.openForms[3];
                //     Form.UpdateUserText();
                //     SessionManager.Instance.openForms[3].Show();
                // }
                SessionManager.Instance.openForms[1].Hide();
                var Form = (PostLogin)SessionManager.Instance.openForms[4];
                Form.UpdateData();
                SessionManager.Instance.openForms[4].Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }

        private void backButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[1].Hide();
            SessionManager.Instance.openForms[0].Show();
        }

        private void Login_Closing(object sender, EventArgs e)
        {
            SessionManager.Instance.Shutdown();

            // for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            // {
            //     SessionManager.Instance.openForms[SessionManager.Instance.openForms.Count - 1 - i].Close();
            // }
        }
    }
}
