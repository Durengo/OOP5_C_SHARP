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

    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            err1.Hide();
            err2.Hide();
            err3.Hide();
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            err1.Hide();
            err2.Hide();
            err3.Hide();
            if (repeatPass.Text == newPass.Text)
            {
                if (SessionManager.Instance.currentUser.ChangePassword(currentPass.Text, newPass.Text))
                {
                    var db = SessionManager.Instance.DatabaseInstance.UserDB;
                    db.ModifyUserValue(SessionManager.Instance.currentUser.Username, "Password = '" + newPass.Text + "'");
                    for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
                    {
                        SessionManager.Instance.openForms[i].Hide();
                    }
                    SessionManager.Instance.openForms[0].Show();
                    SessionManager.Instance.Logout();
                    this.Dispose();
                }
                err1.Show();
            }
            else
            {
                err3.Show();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            //this.Dispose();
        }

        private void err1_Click(object sender, EventArgs e)
        {
            PopUpError popup = new PopUpError("The password does not match the current password.");
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }

        private void err2_Click(object sender, EventArgs e)
        {
            PopUpError popup = new PopUpError("Some undefined error here.");
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }

        private void err3_Click(object sender, EventArgs e)
        {
            PopUpError popup = new PopUpError(
                "This password must be the same as the previous password."
            );
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }
    }
}
