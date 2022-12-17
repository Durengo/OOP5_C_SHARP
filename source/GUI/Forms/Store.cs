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
    using System.Configuration;
    using System.Text.Json;

    public partial class Store : Form
    {
        private ImageList ImageList = new ImageList();
        private List<Product.Product> Products = new List<Product.Product>();
        private List<string> ProductSerialNames = new List<string>();

        public Store()
        {
            InitializeComponent();
            ImageList.ImageSize = new Size(64, 64);
            ProductView.LargeImageList = ImageList;
        }

        public void ReloadData()
        {
            ViewButton.Enabled = false;

            Products.Clear();
            ProductSerialNames.Clear();
            ProductView.Items.Clear();
            ImageList.Images.Clear();

            int internalCounter = 0;

            for (int i = 0; i < SessionManager.Instance.DatabaseInstance.ProductTables.Count(); i++)
            {
                var temp = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValue(
                    SessionManager.Instance.DatabaseInstance.ProductTables[i],
                    "SerialModel"
                );
                ProductSerialNames.AddRange(temp);
                for (int j = 0; j < ProductSerialNames.Count(); j++)
                {
                    if (
                        SessionManager.Instance.DatabaseInstance.ShopDatabase.CountWhere(
                            SessionManager.Instance.DatabaseInstance.ProductTables[i],
                            "SerialModel = '" + ProductSerialNames[j] + "'"
                        ) == 1
                    )
                    {
                        var item = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(
                            SessionManager.Instance.DatabaseInstance.ProductTables[i],
                            ProductSerialNames[j]
                        );
                        ImageList.Images.Add(item.Model, item.Image);
                        ProductView.Items.Add(item.Name, internalCounter);
                        internalCounter++;
                    }
                }
            }

            //var temp = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValue("ProductGPU", "SerialModel");
            // ProductSerialNames.AddRange(temp);
            // for (int i = 0; i < ProductSerialNames.Count(); i++)
            // {
            //     var item = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(Product.ProductType.GPU, ProductSerialNames[i]);
            //     ImageList.Images.Add(item.Model, item.Image);
            //     ProductView.Items.Add(item.Name, internalCounter);
            //     internalCounter++;
            // }

            // temp = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValue("ProductHDD", "SerialModel");
            // ProductSerialNames.AddRange(temp);
            // for (int i = internalCounter; i < ProductSerialNames.Count(); i++)
            // {
            //     var item = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(Product.ProductType.HDD, ProductSerialNames[i]);
            //     ImageList.Images.Add(item.Model, item.Image);
            //     ProductView.Items.Add(item.Name, internalCounter);
            //     internalCounter++;
            // }

            // temp = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValue("ProductRAM", "SerialModel");
            // ProductSerialNames.AddRange(temp);
            // for (int i = internalCounter; i < ProductSerialNames.Count(); i++)
            // {
            //     var item = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(Product.ProductType.RAM, ProductSerialNames[i]);
            //     ImageList.Images.Add(item.Model, item.Image);
            //     ProductView.Items.Add(item.Name, internalCounter);
            //     internalCounter++;
            // }
        }

        private void Store_Closing(object sender, EventArgs e)
        {
            SessionManager.Instance.Shutdown();

            // for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            // {
            //     SessionManager.Instance.openForms[SessionManager.Instance.openForms.Count - 1 - i].Close();
            // }
        }

        private void ProductView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewButton.Enabled = true;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[6].Hide();
            var Form = (ProductView)SessionManager.Instance.openForms[7];
            Form.SerialModelSelected = ProductSerialNames[ProductView.FocusedItem.Index];
            Form.ReloadData();
            if (SessionManager.Instance.currentUser != null)
            {
                SessionManager.Instance.ClientHistory.Log(
                    SessionManager.Instance.currentUser.Username
                        + " VIEWED PRODUCT ---> "
                        + Form.SerialModelSelected
                );
            }
            else
            {
                // SessionManager.Instance.ClientHistory.Log("AN ANONYMOUS USER VIEWED PRODUCT ---> " + Form.SerialModelSelected);
            }
            SessionManager.Instance.openForms[7].Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[6].Hide();
            Products.Clear();
            ProductSerialNames.Clear();
            ProductView.Items.Clear();
            ImageList.Images.Clear();
            if (SessionManager.Instance.currentUser != null)
            {
                SessionManager.Instance.openForms[4].Show();
            }
            else
            {
                SessionManager.Instance.openForms[0].Show();
            }
        }
    }
}
