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
    using OOP5.source.Core;

    public partial class RemoveUsers : Form
    {
        private int whichUser = -1;

        public RemoveUsers()
        {
            InitializeComponent();
            removeButton1.BackColor = Color.DarkGray;
        }

        public void UpdateUserList()
        {
            userList.Items.Clear();
            List<string> usernames =
                SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValue(
                    "Users",
                    "Username"
                );
            for (
                int i = 0;
                i < SessionManager.Instance.DatabaseInstance.ShopDatabase.Count("Users");
                i++
            )
            {
                //List<string> item = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectItem("Users", "ID, Username, Name, Surname, DateOfBirth", "ID = '" + i + "'");
                var item = SessionManager.Instance.DatabaseInstance.UserDB.SelectUser(usernames[i]);
                userList.Items.Add(item);
            }
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            whichUser = userList.SelectedIndex;
            removeButton1.BackColor = Color.Red;
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[5].Hide();
            SessionManager.Instance.openForms[4].Show();
        }

        private void removeButton1_Click(object sender, EventArgs e)
        {
            if (whichUser == -1)
            {
                return;
            }
            else
            {
                var user = (User.User)userList.SelectedItem;
                if (user.UserAccountType == User.AccountType.ADMINISTRATOR)
                {
                    PopUpError popup = new PopUpError("Cannot remove any administrator users.");
                    DialogResult dialogresult = popup.ShowDialog();
                    popup.Dispose();
                    return;
                }
                else
                {
                    SessionManager.Instance.DatabaseInstance.UserDB.RemoverUser(user.Username);
                    removeButton1.BackColor = Color.DarkGray;
                    whichUser = -1;
                    UpdateUserList();
                }

                // var user = SessionManager.Instance.users[whichUser];
                // if (user.UserAccountType == User.AccountType.ADMINISTRATOR)
                // {
                //     PopUpError popup = new PopUpError("Cannot remove any administrator users.");
                //     DialogResult dialogresult = popup.ShowDialog();
                //     popup.Dispose();
                //     return;
                // }
                // else
                // {
                //     SessionManager.Instance.users.RemoveAt(whichUser);
                //     removeButton1.BackColor = Color.DarkGray;
                //     whichUser = -1;
                //     UpdateUserList();
                // }
            }
        }
    }
}
