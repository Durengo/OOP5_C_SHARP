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
    public partial class Wishlist : Form
    {

        private ImageList ImageList = new ImageList();
        private List<Product.Product> Products = new List<Product.Product>();
        private List<string> ProductSerialNames = new List<string>();
        public Wishlist()
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

            //int internalCounter = 0;
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            int wishlistItems = db.CountWhere("Wishlist", "Username = '" + SessionManager.Instance.currentUser.Username + "'");
            if (wishlistItems == 0) { return; }
            //MessageBox.Show(wishlistItems.ToString());
            var serialModels = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValueWhere(
                "Wishlist", "ProductSerialModel", "Username = '" + SessionManager.Instance.currentUser.Username + "'");
            ProductSerialNames = serialModels;

            var productTypes = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValueWhere(
                "Wishlist", "ProductType", "Username = '" + SessionManager.Instance.currentUser.Username + "'");
            

            for (int i = 0; i < wishlistItems; i++)
            {
                for(int j = 0; j < SessionManager.Instance.DatabaseInstance.ProductTables.Count(); j++)
                {
                    if(productTypes[i] == SessionManager.Instance.DatabaseInstance.ProductTables[j])
                    {
                        var item = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(SessionManager.Instance.DatabaseInstance.ProductTables[j], ProductSerialNames[i]);
                        ImageList.Images.Add(item.Model, item.Image);
                        ProductView.Items.Add(item.Name, i);
                    }
                }
                // if(productTypes[i] == "GPU")
                // {
                //     var item = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(Product.ProductType.GPU, ProductSerialNames[i]);
                //     ImageList.Images.Add(item.Model, item.Image);
                //     ProductView.Items.Add(item.Name, i);
                // }
                // else if(productTypes[i] == "HDD")
                // {
                //     var item = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(Product.ProductType.HDD, ProductSerialNames[i]);
                //     ImageList.Images.Add(item.Model, item.Image);
                //     ProductView.Items.Add(item.Name, i);
                // }
                // else if(productTypes[i] == "RAM")
                // {
                //     var item = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(Product.ProductType.RAM, ProductSerialNames[i]);
                //     ImageList.Images.Add(item.Model, item.Image);
                //     ProductView.Items.Add(item.Name, i);
                // }
                // else
                // {
                //     return;
                // }
            }

            // var temp = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValue("ProductGPU", "SerialModel");
            // ProductSerialNames.AddRange(temp);
            // for(int i = 0; i < ProductSerialNames.Count(); i++)
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
        private void ProductView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewButton.Enabled = true;
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[8].Hide();
            Products.Clear();
            ProductSerialNames.Clear();
            ProductView.Items.Clear();
            ImageList.Images.Clear();
            SessionManager.Instance.openForms[4].Show();
        }
        private void ViewButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[8].Hide();
            var Form = (ProductView)SessionManager.Instance.openForms[7];
            Form.FromWishlist = true;
            Form.SerialModelSelected = ProductSerialNames[ProductView.FocusedItem.Index];
            Form.ReloadData();
            SessionManager.Instance.openForms[7].Show();
        }
        private void Wishlist_Closing(object sender, EventArgs e)
        {
            for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            {
                SessionManager.Instance.openForms[SessionManager.Instance.openForms.Count - 1 - i].Close();
            }
        }


    }
}
