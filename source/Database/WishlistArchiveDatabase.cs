using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Database
{
    using OOP5.source.Core;
    using OOP5.source.Shop;

    public class WishlistArchiveDatabase
    {
        public void Generate()
        {
            if (!SessionManager.Instance.SessionConfiguration.DatabaseFound)
            {
                GenerateWishlistArchiveTable();
            }
        }

        public void GenerateWishlistArchiveTable()
        {
            SessionManager.Instance.DatabaseInstance.ShopDatabase.CreateTable(
                "Archive_Wishlist",
                @"Username TEXT,
                ProductType TYPE,
                ProductSerialModel TEXT"
            );
        }

        public void AddWishlistArchiveItem(string username, string type, string productSerialModel)
        {
            if (!SessionManager.Instance.DatabaseInstance.ProductTables.Contains(type))
            {
                MessageBox.Show(type + " DOES NOT EXIT!");
                return;
            }
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.InsertItem(
                "Archive_Wishlist",
                "Username, ProductType, ProductSerialModel",
                "'" + username + "', '" + type + "', '" + productSerialModel + "'"
            );
        }

        public void RemoveWishlistArchiveItem(string username, string productSerialModel)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.DeleteMultipleWhere(
                "Archive_Wishlist",
                "Username = '"
                    + username
                    + "' AND ProductSerialModel = '"
                    + productSerialModel
                    + "'"
            );
        }

        public WishlistItem SelectWishlistArchiveItem(string username, string serialModel)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            List<string> item = db.SelectItem(
                "Archive_Wishlist",
                "Username, ProductType, ProductSerialModel",
                "Username = '" + username + "' AND ProductSerialModel = '" + serialModel + "'"
            );
            WishlistItem selected;
            selected = new WishlistItem(item[0], item[1], item[2]);
            return selected;
        }
    }
}
