using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Database
{
    using OOP5.source.Core;
    using OOP5.source.Shop;

    public class CommentsArchiveDatabase
    {
        public void Generate()
        {
            if (!SessionManager.Instance.SessionConfiguration.DatabaseFound)
            {
                GenerateCommentsArchiveTable();
            }
        }

        public void GenerateCommentsArchiveTable()
        {
            SessionManager.Instance.DatabaseInstance.ShopDatabase.CreateTable(
                "Archive_Comments",
                @"Username TEXT,
                ProductType TYPE,
                ProductSerialModel TEXT,
                Comment TEXT,
                PostDateTime DATE"
            );
        }

        public void AddCommentArchiveItem(
            string username,
            string type,
            string productSerialModel,
            string comment,
            DateTime date
        )
        {
            if (!SessionManager.Instance.DatabaseInstance.ProductTables.Contains(type))
            {
                MessageBox.Show(type + " DOES NOT EXIT!");
                return;
            }
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.InsertItem(
                "Archive_Comments",
                "Username, ProductType, ProductSerialModel, Comment, PostDateTime",
                "'"
                    + username
                    + "', '"
                    + type
                    + "', '"
                    + productSerialModel
                    + "', '"
                    + comment
                    + "', '"
                    + date.ToString()
                    + "'"
            );
        }

        public void RemoveCommentArchiveItem(string username, string productSerialModel)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.DeleteMultipleWhere(
                "Archive_Comments",
                "Username = '"
                    + username
                    + "' AND ProductSerialModel = '"
                    + productSerialModel
                    + "'"
            );
        }

        public Comment SelectCommentArchiveItem(string username, string serialModel)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            List<string> item = db.SelectItem(
                "Archive_Comments",
                "Username, ProductType, ProductSerialModel, Comment, PostDateTime",
                "Username = '" + username + "' AND ProductSerialModel = '" + serialModel + "'"
            );
            Comment selected;
            selected = new Comment(item[0], item[1], item[2], item[3], DateTime.Parse(item[4]));
            return selected;
        }
    }
}
