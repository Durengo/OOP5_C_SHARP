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
    using OOP5.source.Log;

    public partial class ShoppingHistory : Form
    {
        private Logger JsonHistoryFile = null;

        //private ImageList ImageList = new ImageList();
        private List<Shop.ShoppingCart> Products = new List<Shop.ShoppingCart>();
        private List<string> ProductSerialNames = new List<string>();
        private List<string> ShoppingCartItems = new List<string>();
        private string SelectedSerialModel = "";
        public float TotalPrice = 0;
        private bool FileCreated = false;

        public ShoppingHistory()
        {
            InitializeComponent();
        }

        public void ReloadData()
        {
            ShoppingHistoryView.ClearSelected();
            ViewButton.Enabled = false;
            TotalPrice = 0;
            TotalProfitTextBox.Text = "Total Profit = " + TotalPrice.ToString() + "$";
            Products.Clear();
            ProductSerialNames.Clear();
            ShoppingHistoryView.Items.Clear();
            ShoppingCartItems.Clear();

            ExportToJsonButton.Enabled = false;
            ExportToJsonButton.Hide();

            if (SessionManager.Instance.currentUser.UserAccountType == User.AccountType.FINANCER)
            {
                ExportToJsonButton.Show();
                ShoppingCartItems =
                    SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValueWhereAndOrderBy(
                        "ShoppingCart",
                        "CartItemUsername, ProductType, ProductSerialModel, CartItemDate, CartItemStatus",
                        "CartItemStatus = 'Paid'",
                        "CartItemDate"
                    );
                //MessageBox.Show(items.Count().ToString());
                int internalCounter = 0;
                for (int i = 0; i < ShoppingCartItems.Count() / 5; i++)
                {
                    Products.Add(
                        new Shop.ShoppingCart(
                            ShoppingCartItems[internalCounter + 0],
                            ShoppingCartItems[internalCounter + 1],
                            ShoppingCartItems[internalCounter + 2],
                            DateTime.Parse(ShoppingCartItems[internalCounter + 3]),
                            ShoppingCartItems[internalCounter + 4]
                        )
                    );

                    //Products.Add(SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(ShoppingCartItems[internalCounter + 1], ShoppingCartItems[internalCounter + 2]));
                    var item = Products[Products.Count() - 1];
                    float productPrice = SessionManager.Instance.DatabaseInstance.ProductDB
                        .SelectProduct(item.CartType, item.CartProduct)
                        .Price;
                    //Products.Add(SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(ShoppingCartItems[internalCounter + 1], ShoppingCartItems[internalCounter + 2]));
                    //float productPrice = Products[Products.Count() - 1].Price;

                    ShoppingHistoryView.Items.Add(
                        ShoppingCartItems[internalCounter + 0]
                            + "\t\t"
                            + ShoppingCartItems[internalCounter + 1]
                            + "\t"
                            + ShoppingCartItems[internalCounter + 2]
                            + "\t"
                            + ShoppingCartItems[internalCounter + 3]
                            + "\t"
                            + productPrice
                            + "$"
                    );

                    TotalPrice += productPrice;
                    TotalProfitTextBox.Text = "Total Profit = " + TotalPrice.ToString() + "$";

                    internalCounter += 5;
                }

                if (TotalProfitTextBox.Text == "Total Profit = 0$")
                {
                    ExportToJsonButton.Enabled = false;
                }
                else
                {
                    ExportToJsonButton.Enabled = true;
                }
            }
            else
            {
                ShoppingCartItems =
                    SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValueWhereAndOrderBy(
                        "ShoppingCart",
                        "CartItemUsername, ProductType, ProductSerialModel, CartItemDate, CartItemStatus",
                        "CartItemStatus = 'Paid' AND CartItemUsername = '"
                            + SessionManager.Instance.currentUser.Username
                            + "'",
                        "CartItemDate"
                    );
                //MessageBox.Show(items.Count().ToString());
                int internalCounter = 0;
                for (int i = 0; i < ShoppingCartItems.Count() / 5; i++)
                {
                    Products.Add(
                        new Shop.ShoppingCart(
                            ShoppingCartItems[internalCounter + 0],
                            ShoppingCartItems[internalCounter + 1],
                            ShoppingCartItems[internalCounter + 2],
                            DateTime.Parse(ShoppingCartItems[internalCounter + 3]),
                            ShoppingCartItems[internalCounter + 4]
                        )
                    );

                    //Products.Add(SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(ShoppingCartItems[internalCounter + 1], ShoppingCartItems[internalCounter + 2]));
                    var item = Products[Products.Count() - 1];
                    float productPrice = SessionManager.Instance.DatabaseInstance.ProductDB
                        .SelectProduct(item.CartType, item.CartProduct)
                        .Price;
                    //Products.Add(SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(ShoppingCartItems[internalCounter + 1], ShoppingCartItems[internalCounter + 2]));
                    //float productPrice = Products[Products.Count() - 1].Price;

                    ShoppingHistoryView.Items.Add(
                        ShoppingCartItems[internalCounter + 0]
                            + "\t\t"
                            + ShoppingCartItems[internalCounter + 1]
                            + "\t"
                            + ShoppingCartItems[internalCounter + 2]
                            + "\t"
                            + ShoppingCartItems[internalCounter + 3]
                            + "\t"
                            + productPrice
                            + "$"
                    );

                    TotalPrice += productPrice;
                    TotalProfitTextBox.Text = "Total Spent = " + TotalPrice.ToString() + "$";

                    internalCounter += 5;
                }
            }
        }

        private void ShoppingHistory_Closing(object sender, EventArgs e)
        {
            SessionManager.Instance.Shutdown();

            // for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            // {
            //     SessionManager.Instance.openForms[SessionManager.Instance.openForms.Count - 1 - i].Close();
            // }
        }

        private void ShoppingHistoryView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ShoppingHistoryView.SelectedIndex;
            if (index != -1)
            {
                //BuyButton.Enabled = true;
                //RemoveItemButton.Enabled = true;

                ViewButton.Enabled = true;
                int count = 5 * (index);
                SelectedSerialModel = ShoppingCartItems[count + 2];
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[12].Hide();
            var Form = (ProductView)SessionManager.Instance.openForms[7];
            Form.FromShoppingHistory = true;
            Form.SerialModelSelected = SelectedSerialModel;
            Form.ReloadData();
            SessionManager.Instance.openForms[7].Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[12].Hide();
            Products.Clear();
            ProductSerialNames.Clear();
            ShoppingHistoryView.Items.Clear();
            //ImageList.Images.Clear();
            // if (SessionManager.Instance.currentUser != null)
            // {
            //     SessionManager.Instance.openForms[4].Show();
            // }
            // else
            // {
            SessionManager.Instance.openForms[4].Show();
            // }
        }

        private void ExportToJsonButton_Click(object sender, EventArgs e)
        {
            if(!FileCreated)
            {
                JsonHistoryFile = new Logger(new JsonLog("ShoppingHistory.json"));
            }
            JsonHistoryFile.Clear();
            for (int i = 0; i < Products.Count(); i++)
            {
                var product = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(Products[i].CartType, Products[i].CartProduct);
                JsonHistoryFile.Log(Products[i]);
                JsonHistoryFile.Log(product);
            }
        }
    }
}
