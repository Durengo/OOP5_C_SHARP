using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Database
{
    using OOP5.source.Core;
    using OOP5.source.Shop;

    public class ShoppingCartDatabase
    {
        public void Generate()
        {
            if (!SessionManager.Instance.SessionConfiguration.DatabaseFound)
            {
                GenerateShoppingCartTable();
                GenerateShoppingCart();
            }
        }

        public void GenerateShoppingCartTable()
        {
            SessionManager.Instance.DatabaseInstance.ShopDatabase.CreateTable(
                "ShoppingCart",
                @"CartItemUsername TEXT,
                ProductType TEXT,
                ProductSerialModel TEXT,
                CartItemDate DATE,
                CartItemStatus TEXT"
            );
        }

        public void AddShoppingCartItem(
            string username,
            string productType,
            string productSerialModel,
            DateTime date,
            string status
        )
        {
            if (!SessionManager.Instance.DatabaseInstance.ProductTables.Contains(productType))
            {
                MessageBox.Show(productType + " DOES NOT EXIT!");
                return;
            }
            if (
                SessionManager.Instance.DatabaseInstance.ShopDatabase.CountWhere(
                    productType,
                    "SerialModel = '" + productSerialModel + "'"
                ) == 0
            )
            {
                MessageBox.Show(productSerialModel + " DOES NOT EXIT!");
                return;
            }
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.InsertItem(
                "ShoppingCart",
                "CartItemUsername, ProductType, ProductSerialModel, CartItemDate, CartItemStatus",
                "'"
                    + username
                    + "', '"
                    + productType
                    + "', '"
                    + productSerialModel
                    + "', '"
                    + date
                    + "', '"
                    + status
                    + "'"
            );
        }

        public void RemoveShoppingCartItem(
            string username,
            string productSerialModel,
            DateTime date
        )
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.DeleteMultipleWhere(
                "ShoppingCart",
                "CartItemUsername = '"
                    + username
                    + "' AND ProductSerialModel = '"
                    + productSerialModel
                    + "' AND CartItemDate = '"
                    + date.ToString()
                    + "'"
            );
        }

        public void ModifyProductValue(
            string username,
            string productSerialModel,
            DateTime date,
            string values
        )
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.UpdateItem(
                "ShoppingCart",
                values,
                "ProductSerialModel = '"
                    + productSerialModel
                    + "' AND CartItemUsername = '"
                    + username
                    + "' AND CartItemDate = '"
                    + date.ToString()
                    + "'"
            );
        }

        public ShoppingCart SelectShoppingCartItem(
            string username,
            string productType,
            string productSerialModel,
            DateTime date,
            string status
        )
        {
            if (!SessionManager.Instance.DatabaseInstance.ProductTables.Contains(productType))
            {
                MessageBox.Show(productType + " DOES NOT EXIT!");
                return null;
            }
            if (
                SessionManager.Instance.DatabaseInstance.ShopDatabase.CountWhere(
                    productType,
                    "SerialModel = '" + productSerialModel + "'"
                ) == 0
            )
            {
                MessageBox.Show(productSerialModel + " DOES NOT EXIT!");
                return null;
            }
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;

            List<string> item = db.SelectItem(
                "ShoppingCart",
                "CartItemUsername, ProductType, ProductSerialModel, CartItemDate, CartItemStatus",
                "CartItemUsername = '"
                    + username
                    + "' AND CartItemDate = '"
                    + date
                    + "' AND ProductSerialModel = '"
                    + productSerialModel
                    + "'"
            );
            ShoppingCart selected;
            selected = new ShoppingCart(
                item[0],
                item[1],
                item[2],
                DateTime.Parse(item[3]),
                item[4]
            );
            // TODO: Add condition for no picture?
            return selected;
        }

        private void GenerateShoppingCart()
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            //ADD Shopping Cart Items:
            AddShoppingCartItem("Dur", "ProductGPU", "MSIGTX970IKMG44", DateTime.Now, "Paid");
            AddShoppingCartItem("Dur", "ProductGPU", "100-506159", DateTime.Now, "Paid");
            AddShoppingCartItem("Dur", "ProductGPU", "DUAL-GTX1650-O4G", DateTime.Now, "Paid");
            AddShoppingCartItem("Dur", "ProductHDD", "WD20EZAZ", DateTime.Now, "Unpaid");
            AddShoppingCartItem("admin", "ProductGPU", "RX6400 CLI 4G", DateTime.Now, "Unpaid");
            AddShoppingCartItem(
                "admin",
                "ProductRAM",
                "CMK16GX4M2Z3200C16",
                DateTime.Now,
                "Unpaid"
            );
            AddShoppingCartItem(
                "admin",
                "ProductRAM",
                "CMW16GX4M2D3600C18",
                DateTime.Now,
                "Unpaid"
            );
            AddShoppingCartItem(
                "admin",
                "ProductRAM",
                "F4-3600C18D-16GTZRX",
                DateTime.Now,
                "Unpaid"
            );
            AddShoppingCartItem("admin", "ProductHDD", "WD20EZAZ", DateTime.Now, "Paid");
        }
    }
}
