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

    public partial class RemoveProduct : Form
    {
        private string SelectedCategory = "";
        private string SelectedProduct = "";
        public RemoveProduct()
        {
            InitializeComponent();
        }
        public void UpdateData()
        {
            RemoveButton.Enabled = false;
            SelectedCategory = "";
            SelectedProduct = "";

            CategoryBox.ResetText();
            CategoryBox.Items.Clear();
            ProductBox.ResetText();
            ProductBox.Items.Clear();
            SerialModelBox.Text = "";
            ProductDescriptionBox.Text = "";
            ProductPriceBox.Text = "";
            PictureBox.Image = null;

            for (int i = 0; i < SessionManager.Instance.DatabaseInstance.ProductTables.Count(); i++)
            {
                CategoryBox.Items.Add(SessionManager.Instance.DatabaseInstance.ProductTables[i]);
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[11].Hide();
            SessionManager.Instance.openForms[4].Show();
        }
        private void RemoveProduct_Closing(object sender, EventArgs e)
        {
            for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            {
                SessionManager.Instance.openForms[SessionManager.Instance.openForms.Count - 1 - i].Close();
            }
        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedProduct = "";
            ProductBox.ResetText();
            ProductBox.Items.Clear();
            SerialModelBox.Text = "";
            ProductDescriptionBox.Text = "";
            ProductPriceBox.Text = "";
            PictureBox.Image = null;

            SelectedCategory = CategoryBox.Text;
            var list = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValue(SelectedCategory, "SerialModel");
            for (int i = 0; i < list.Count(); i++)
            {
                ProductBox.Items.Add(list[i]);
            }
        }

        private void ProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedProduct = ProductBox.Text;
            var item = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(SelectedCategory, SelectedProduct);
            SerialModelBox.Text = item.Model;
            ProductDescriptionBox.Text = item.Description;
            ProductPriceBox.Text = item.Price.ToString();
            PictureBox.Image = item.Image;
            RemoveButton.Enabled = true;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.DatabaseInstance.ProductDB.RemoveProduct(SelectedCategory, SelectedProduct);
            MessageBox.Show("Product Has Been Successfully Removed!");
            UpdateData();
        }
    }
}
