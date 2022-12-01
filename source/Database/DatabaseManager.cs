using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A single class that holds all the other classes. This is done to not clutter the 'SessionManager' class.

namespace OOP5.source.Database
{
    using OOP5.source.Core;
    public class DatabaseManager
    {
        // sqlite instance:
        public Database ShopDatabase = new Database("Store");
        public UserDatabase UserDB = new UserDatabase();
        public WishlistArchiveDatabase WishlistArchiveDB = new WishlistArchiveDatabase();
        public WishlistDatabase WishlistDB = new WishlistDatabase();
        public CommentsArchiveDatabase CommentsArchiveDB = new CommentsArchiveDatabase();
        public CommentsDatabase CommentsDB = new CommentsDatabase();
        public ProductDatabase ProductDB = new ProductDatabase();
        // Following variable is important for adding and removing product tables and adding, removing, modifying product records.
        // TODO: find a better way to implement.
        public List<string> ProductTables;

        public void Generate()
        {
            UserDB.Generate();
            ProductDB.Generate();
            ReloadTableList();
            CommentsArchiveDB.Generate();
            CommentsDB.Generate();
            WishlistArchiveDB.Generate();
            WishlistDB.Generate();

            // Change .cfg value.
            if (!SessionManager.Instance.SessionConfiguration.DatabaseFound)
            {
                SessionManager.Instance.SessionConfiguration.ChangeDatabase(true);
            }
        }

        // Used if product tables are modified.
        public void ReloadTableList()
        {
            List<string> temp = ShopDatabase.SelectAllOneValue("sqlite_master", "name");
            temp.RemoveAll(x => !x.Contains("Product"));
            string display = "";
            for (int i = 0; i < temp.Count(); i++)
            {
                display += temp[i] + ", ";
            }

            ProductTables = temp;
        }
    }
}
