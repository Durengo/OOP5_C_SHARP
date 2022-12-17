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

    public partial class CreateCategory : Form
    {
        public string NewCategoryText = "";

        public CreateCategory()
        {
            InitializeComponent();
            ErrMsg.Hide();
        }

        public void UpdateData()
        {
            CreateButton.Enabled = false;
            NewCategoryText = "";
            TrueDisplayTextBox.Text = "";
            CategoryTextBox.Text = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[9].Hide();
            ErrMsg.Hide();
            SessionManager.Instance.openForms[4].Show();
        }

        private void CategoryTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrMsg.Hide();
            NewCategoryText = "Product" + CategoryTextBox.Text;
            TrueDisplayTextBox.Text = NewCategoryText;
            if (CategoryTextBox.Text != "")
            {
                CreateButton.Enabled = true;
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (SessionManager.Instance.DatabaseInstance.ProductTables.Contains(NewCategoryText))
            {
                ErrMsg.Show();
                return;
            }
            SessionManager.Instance.DatabaseInstance.ProductDB.CreateNewProductTable(
                NewCategoryText
            );
            SessionManager.Instance.DatabaseInstance.ReloadTableList();
            MessageBox.Show("Category '" + NewCategoryText + "' Created!");
            UpdateData();
        }

        private void CreateCategory_Closing(object sender, EventArgs e)
        {
            SessionManager.Instance.Shutdown();

            // for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            // {
            //     SessionManager.Instance.openForms[SessionManager.Instance.openForms.Count - 1 - i].Close();
            // }
        }
    }
}
