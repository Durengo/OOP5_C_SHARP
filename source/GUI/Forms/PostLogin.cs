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

    public partial class PostLogin : Form
    {
        public PostLogin()
        {
            InitializeComponent();
        }
        public void UpdateData()
        {
            var user = SessionManager.Instance.currentUser;
            usernameWelcomeLabel.Text = user.Username;
            usernameWelcomeLabel.ForeColor = Color.Black;
            deleteUser.Enabled = false;
            deleteUser.Hide();
            CreateCategoryButton.Enabled = false;
            CreateCategoryButton.Hide();
            CreateProductButton.Enabled = false;
            CreateProductButton.Hide();
            RemoveProductButton.Enabled = false;
            RemoveProductButton.Hide();
            if (user.UserAccountType == User.AccountType.ADMINISTRATOR)
            {
                usernameWelcomeLabel.ForeColor = Color.Red;
                deleteUser.Enabled = true;
                deleteUser.Show();
                CreateCategoryButton.Enabled = true;
                CreateCategoryButton.Show();
                CreateProductButton.Enabled = true;
                CreateProductButton.Show();
                RemoveProductButton.Enabled = true;
                RemoveProductButton.Show();
            }
        }
        private void viewAccountButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[4].Hide();
            var Form = (AccountView)SessionManager.Instance.openForms[3];
            Form.UpdateData();
            SessionManager.Instance.openForms[3].Show();
        }
        private void exitButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.Logout();
            Close();
        }
        private void logoutButton1_Click_1(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[4].Hide();
            var Form = (AccountView)SessionManager.Instance.openForms[3];
            Form.ResetForm();
            SessionManager.Instance.Logout();
            SessionManager.Instance.openForms[0].Show();
        }
        private void shopButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[4].Hide();
            var Form = (Store)SessionManager.Instance.openForms[6];
            Form.ReloadData();
            SessionManager.Instance.openForms[6].Show();
        }
        private void PostLogin_Closing(object sender, EventArgs e)
        {
            for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            {
                SessionManager.Instance.openForms[SessionManager.Instance.openForms.Count - 1 - i].Close();
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            var Form = (RemoveUsers)SessionManager.Instance.openForms[5];
            Form.UpdateUserList();
            Form.ShowDialog();
        }

        private void wishlistButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[4].Hide();
            var Form = (Wishlist)SessionManager.Instance.openForms[8];
            Form.ReloadData();
            SessionManager.Instance.openForms[8].Show();
        }

        private void commentHistoryButton1_Click(object sender, EventArgs e)
        {

        }

        private void CreateCategoryButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[4].Hide();
            var Form = (CreateCategory)SessionManager.Instance.openForms[9];
            Form.UpdateData();
            SessionManager.Instance.openForms[9].Show();
        }

        private void CreateProductButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[4].Hide();
            var Form = (CreateProduct)SessionManager.Instance.openForms[10];
            Form.UpdateData();
            SessionManager.Instance.openForms[10].Show();
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[4].Hide();
            var Form = (RemoveProduct)SessionManager.Instance.openForms[11];
            Form.UpdateData();
            SessionManager.Instance.openForms[11].Show();
        }
    }
}
