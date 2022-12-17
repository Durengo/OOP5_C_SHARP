using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Database
{
    using OOP5.source.Core;
    using OOP5.source.Shop;

    public class WishlistDatabase
    {
        public void Generate()
        {
            if (!SessionManager.Instance.SessionConfiguration.DatabaseFound)
            {
                GenerateWishlistTable();
                GenerateWishlists();
            }
        }

        public void GenerateWishlistTable()
        {
            SessionManager.Instance.DatabaseInstance.ShopDatabase.CreateTable(
                "Wishlist",
                @"Username TEXT,
                ProductType TYPE,
                ProductSerialModel TEXT"
            );
        }

        public void AddWishlistItem(string username, string type, string productSerialModel)
        {
            if (!SessionManager.Instance.DatabaseInstance.ProductTables.Contains(type))
            {
                MessageBox.Show(type + " DOES NOT EXIT!");
                return;
            }
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.InsertItem(
                "Wishlist",
                "Username, ProductType, ProductSerialModel",
                "'" + username + "', '" + type + "', '" + productSerialModel + "'"
            );
            SessionManager.Instance.DatabaseInstance.WishlistArchiveDB.AddWishlistArchiveItem(
                username,
                type,
                productSerialModel
            );
        }

        public void RemoveWishlistItem(string username, string productSerialModel)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.DeleteMultipleWhere(
                "Wishlist",
                "Username = '"
                    + username
                    + "' AND ProductSerialModel = '"
                    + productSerialModel
                    + "'"
            );
        }

        public void RemoveAllWishlistItemsWithSerialModel(string productSerialModel)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.DeleteMultipleWhere("Wishlist", "ProductSerialModel = '" + productSerialModel + "'");
        }

        public WishlistItem SelectWishlistItem(string username, string serialModel)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            List<string> item = db.SelectItem(
                "Wishlist",
                "Username, ProductType, ProductSerialModel",
                "Username = '" + username + "' AND ProductSerialModel = '" + serialModel + "'"
            );
            WishlistItem selected;
            selected = new WishlistItem(item[0], item[1], item[2]);
            return selected;
        }

        public void GenerateWishlists()
        {
            AddWishlistItem("Dur", "ProductGPU", "MSIGTX970IKMG44");
            AddWishlistItem("Dur", "ProductGPU", "DUAL-GTX1650-O4G");
            AddWishlistItem("Dur", "ProductHDD", "WD20EZAZ");
            AddWishlistItem("admin", "ProductGPU", "RX6400 CLI 4G");
            AddWishlistItem("admin", "ProductRAM", "CMK16GX4M2Z3200C16");
        }
    }
}
