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
    using OOP5.source.Shop;

    public partial class ShoppingCart : Form
    {
        //private Logger JsonHistoryFile = null;
        //private ImageList ImageList = new ImageList();
        private List<Product.Product> Products = new List<Product.Product>();
        private List<string> ProductSerialNames = new List<string>();
        private List<string> ShoppingCartItems = new List<string>();
        private string SelectedSerialModel = "";
        public float TotalPrice = 0;
        public ShoppingCartTotalEvent Cart = null;

        public ShoppingCart()
        {
            InitializeComponent();
            //ImageList.ImageSize = new Size(64, 64);
            //ProductView.LargeImageList = ImageList;
        }

        public void ReloadData()
        {
            // Cart Total Price Event
            Cart = null;
            Cart = new ShoppingCartTotalEvent();
            //float amount = Cart.ChangeTotalPrice(0) + Cart.ChangeTotalPrice(1);

            BuyButton.Text = "Pay";
            ProductView.ClearSelected();
            // var item2 = SessionManager.Instance.DatabaseInstance.ShoppingCartDB.SelectShoppingCartItem(
            //                 "Dur", "ProductGPU", "MSIGTX970IKMG44", DateTime.Parse("2022-12-08 15:37:54"), "Paid");
            //MessageBox.Show(item2.CartItemUser + " " + item2.CartProduct + " " + item2.CartStatus);


            //JsonHistoryFile = new Logger(new JsonLog("ShoppingCart.json"));
            //BuyButton.Enabled = false;
            RemoveItemButton.Enabled = false;
            ViewProductButton.Enabled = false;

            TotalPrice = 0;
            TotalPriceTextBox.Text = "Total Price = " + Cart.TotalCartAmount.ToString() + "$";
            //MessageBox.Show(TotalPriceTextBox.Text);

            Products.Clear();
            ProductSerialNames.Clear();
            ProductView.Items.Clear();
            //ImageList.Images.Clear();

            ShoppingCartItems.Clear();

            //var containerSize = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValue("ShoppingCart", "CartItemUsername = '" + SessionManager.Instance.currentUser.Username + "'");
            //var containerSize = SessionManager.Instance.DatabaseInstance.ShopDatabase.CountWhere("ShoppingCart", "CartItemUsername = '" + SessionManager.Instance.currentUser.Username + "'");

            ShoppingCartItems =
                SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValueWhere(
                    "ShoppingCart",
                    "CartItemUsername, ProductType, ProductSerialModel, CartItemDate, CartItemStatus",
                    "CartItemUsername = '" + SessionManager.Instance.currentUser.Username + "'"
                );
            //MessageBox.Show(items.Count().ToString());
            int internalCounter = 0;
            for (int i = 0; i < ShoppingCartItems.Count() / 5; i++)
            {
                var product = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(
                    ShoppingCartItems[internalCounter + 1],
                    ShoppingCartItems[internalCounter + 2]
                );
                if (ShoppingCartItems[internalCounter + 4] == "Unpaid")
                {
                    ProductView.Items.Add(
                        ShoppingCartItems[internalCounter + 2]
                            + "\t\t\t"
                            + ShoppingCartItems[internalCounter + 3]
                            + "\t\t\t"
                            + product.Price
                            + "$"
                    );
                    Cart.ChangeTotalPrice(product.Price);
                    //TotalPrice += product.Price;
                }
                TotalPriceTextBox.Text = "Total Price = " + Cart.TotalCartAmount + "$";
                internalCounter += 5;
            }

            if (TotalPriceTextBox.Text == "Total Price = 0$")
            {
                BuyButton.Enabled = false;
            }
            else
            {
                BuyButton.Enabled = true;
                if (SessionManager.Instance.BirthdayDiscount)
                {
                    float oldprice = Cart.TotalCartAmount;
                    //TotalPrice *= 0.9f;
                    Cart.ChangeTotalPrice(-(oldprice * 0.1f));
                    //Cart.TotalCartAmount *= 0.9f;
                    TotalPriceTextBox.Text =
                        "Total Price = "
                        + oldprice
                        + " - 10% = "
                        + Cart.TotalCartAmount.ToString()
                        + "$";
                    BuyButton.Text = "Pay (Birthday Discount - 10% OFF!)";
                }
            }

            // for (int i = 0; i < SessionManager.Instance.DatabaseInstance.ProductTables.Count(); i++)
            // {
            //     var temp = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValue(SessionManager.Instance.DatabaseInstance.ProductTables[i], "SerialModel");
            //     ProductSerialNames.AddRange(temp);
            //     for (int j = 0; j < ProductSerialNames.Count(); j++)
            //     {
            //         if (SessionManager.Instance.DatabaseInstance.ShopDatabase.CountWhere(SessionManager.Instance.DatabaseInstance.ProductTables[i], "SerialModel = '" + ProductSerialNames[j] + "'") == 1)
            //         {
            //             var item = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(SessionManager.Instance.DatabaseInstance.ProductTables[i], ProductSerialNames[j]);
            //             //ImageList.Images.Add(item.Model, item.Image);
            //             ProductView.Items.Add(item.Name + " " + item.Price + "$");
            //             internalCounter++;
            //         }

            //     }
            // }
        }

        private void ProductView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ProductView.SelectedIndex;
            if (index != -1)
            {
                //BuyButton.Enabled = true;
                RemoveItemButton.Enabled = true;

                ViewProductButton.Enabled = true;
                int count = 5 * (index);
                SelectedSerialModel = ShoppingCartItems[count + 2];
            }
        }

        private void ShoppingCart_Closing(object sender, EventArgs e)
        {
            SessionManager.Instance.Shutdown();
        }

        // private void ProductView_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //     ViewButton.Enabled = true;
        // }

        // private void ViewButton_Click(object sender, EventArgs e)
        // {
        //     SessionManager.Instance.openForms[6].Hide();
        //     var Form = (ProductView)SessionManager.Instance.openForms[7];
        //     Form.SerialModelSelected = ProductSerialNames[ProductView.FocusedItem.Index];
        //     Form.ReloadData();

        //     var item = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(Form.SerialModelSelected);
        //     JsonHistoryFile.Log(item);


        //     SessionManager.Instance.openForms[7].Show();
        // }
        private void BuyButton_Click(object sender, EventArgs e)
        {
            int internalCounter = 0;
            for (int i = 0; i < ShoppingCartItems.Count() / 5; i++)
            {
                SessionManager.Instance.DatabaseInstance.ShoppingCartDB.ModifyProductValue(
                    SessionManager.Instance.currentUser.Username,
                    ShoppingCartItems[internalCounter + 2],
                    DateTime.Parse(ShoppingCartItems[internalCounter + 3]),
                    "CartItemStatus = 'Paid'"
                );
                // var product = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(ShoppingCartItems[internalCounter + 1], ShoppingCartItems[internalCounter + 2]);
                // if (ShoppingCartItems[internalCounter + 4] == "Unpaid")
                // {
                //     ProductView.Items.Add(ShoppingCartItems[internalCounter + 2] + "\t\t\t\t\t" + product.Price + "$");
                // }
                internalCounter += 5;
            }
            ReloadData();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            var index = ProductView.SelectedIndex;
            int count = 5 * (index);
            //MessageBox.Show(ShoppingCartItems[count + 2] + " " + ShoppingCartItems[count + 3]);
            SessionManager.Instance.DatabaseInstance.ShoppingCartDB.RemoveShoppingCartItem(
                SessionManager.Instance.currentUser.Username,
                ShoppingCartItems[count + 2],
                DateTime.Parse(ShoppingCartItems[count + 3])
            );
            ReloadData();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[13].Hide();
            Products.Clear();
            ProductSerialNames.Clear();
            ProductView.Items.Clear();
            //ImageList.Images.Clear();
            // if (SessionManager.Instance.currentUser != null)
            // {
            //     SessionManager.Instance.openForms[4].Show();
            // }
            // else
            //{
            SessionManager.Instance.openForms[4].Show();
            //}
        }

        private void ViewProductButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[13].Hide();
            var Form = (ProductView)SessionManager.Instance.openForms[7];
            Form.FromShoppingCart = true;
            Form.SerialModelSelected = SelectedSerialModel;
            Form.ReloadData();
            SessionManager.Instance.openForms[7].Show();
        }
    }
}

// BACK UP:
// public void ReloadData()
//         {
//             // Cart Total Price Event
//             Cart = null;
//             Cart = new ShoppingCartTotalEvent();
//             float amount = Cart.ChangeTotalPrice(0);

//             BuyButton.Text = "Pay";
//             ProductView.ClearSelected();
//             // var item2 = SessionManager.Instance.DatabaseInstance.ShoppingCartDB.SelectShoppingCartItem(
//             //                 "Dur", "ProductGPU", "MSIGTX970IKMG44", DateTime.Parse("2022-12-08 15:37:54"), "Paid");
//             //MessageBox.Show(item2.CartItemUser + " " + item2.CartProduct + " " + item2.CartStatus);


//             //JsonHistoryFile = new Logger(new JsonLog("ShoppingCart.json"));
//             //BuyButton.Enabled = false;
//             RemoveItemButton.Enabled = false;
//             ViewProductButton.Enabled = false;

//             TotalPrice = 0;
//             TotalPriceTextBox.Text = "Total Price = " + TotalPrice.ToString() + "$";

//             Products.Clear();
//             ProductSerialNames.Clear();
//             ProductView.Items.Clear();
//             //ImageList.Images.Clear();

//             ShoppingCartItems.Clear();


//             //var containerSize = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValue("ShoppingCart", "CartItemUsername = '" + SessionManager.Instance.currentUser.Username + "'");
//             //var containerSize = SessionManager.Instance.DatabaseInstance.ShopDatabase.CountWhere("ShoppingCart", "CartItemUsername = '" + SessionManager.Instance.currentUser.Username + "'");

//             ShoppingCartItems = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValueWhere("ShoppingCart",
//             "CartItemUsername, ProductType, ProductSerialModel, CartItemDate, CartItemStatus",
//             "CartItemUsername = '" + SessionManager.Instance.currentUser.Username + "'");
//             //MessageBox.Show(items.Count().ToString());
//             int internalCounter = 0;
//             for (int i = 0; i < ShoppingCartItems.Count() / 5; i++)
//             {
//                 var product = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(ShoppingCartItems[internalCounter + 1], ShoppingCartItems[internalCounter + 2]);
//                 if (ShoppingCartItems[internalCounter + 4] == "Unpaid")
//                 {
//                     ProductView.Items.Add(ShoppingCartItems[internalCounter + 2] + "\t\t\t" + ShoppingCartItems[internalCounter + 3] + "\t\t\t" + product.Price + "$");
//                     TotalPrice += product.Price;
//                 }
//                 TotalPriceTextBox.Text = "Total Price = " + TotalPrice.ToString() + "$";
//                 internalCounter += 5;
//             }

//             if (TotalPriceTextBox.Text == "Total Price = 0$")
//             {
//                 BuyButton.Enabled = false;
//             }
//             else
//             {
//                 BuyButton.Enabled = true;
//                 if(SessionManager.Instance.BirthdayDiscount)
//                 {
//                     float oldprice = TotalPrice;
//                     TotalPrice *= 0.9f;
//                     TotalPriceTextBox.Text = "Total Price = " + oldprice + " - 10% = " + TotalPrice.ToString() + "$";
//                     BuyButton.Text = "Pay (Birthday Discount - 10% OFF!)";
//                 }
//             }

//             // for (int i = 0; i < SessionManager.Instance.DatabaseInstance.ProductTables.Count(); i++)
//             // {
//             //     var temp = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValue(SessionManager.Instance.DatabaseInstance.ProductTables[i], "SerialModel");
//             //     ProductSerialNames.AddRange(temp);
//             //     for (int j = 0; j < ProductSerialNames.Count(); j++)
//             //     {
//             //         if (SessionManager.Instance.DatabaseInstance.ShopDatabase.CountWhere(SessionManager.Instance.DatabaseInstance.ProductTables[i], "SerialModel = '" + ProductSerialNames[j] + "'") == 1)
//             //         {
//             //             var item = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(SessionManager.Instance.DatabaseInstance.ProductTables[i], ProductSerialNames[j]);
//             //             //ImageList.Images.Add(item.Model, item.Image);
//             //             ProductView.Items.Add(item.Name + " " + item.Price + "$");
//             //             internalCounter++;
//             //         }

//             //     }
//             // }
//         }
