using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Database
{
    using OOP5.source.Core;
    using OOP5.source.Shop;
    public class CommentsDatabase
    {
        public void Generate()
        {
            if (!SessionManager.Instance.SessionConfiguration.DatabaseFound)
            {
                GenerateCommentsTable();
                GenerateComments();
            }
        }
        public void GenerateCommentsTable()
        {
            SessionManager.Instance.DatabaseInstance.ShopDatabase.CreateTable("Comments",
                @"Username TEXT,
                ProductType TYPE,
                ProductSerialModel TEXT,
                Comment TEXT,
                PostDateTime DATE");
        }
        public void AddCommentItem(string username, string type, string productSerialModel, string comment, DateTime date)
        {
            if (!SessionManager.Instance.DatabaseInstance.ProductTables.Contains(type))
            {
                MessageBox.Show(type + " DOES NOT EXIT!");
                return;
            }
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.InsertItem(
                "Comments",
                "Username, ProductType, ProductSerialModel, Comment, PostDateTime",
                "'" + username + "', '" +
                type + "', '" +
                productSerialModel + "', '" +
                comment + "', '" +
                date.ToString() + "'");
            SessionManager.Instance.DatabaseInstance.CommentsArchiveDB.AddCommentArchiveItem(username, type, productSerialModel, comment, date);
        }
        public void RemoveCommentItem(string username, string productSerialModel)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.DeleteMultipleWhere("Comments", "Username = '" + username + "' AND ProductSerialModel = '" + productSerialModel + "'");
        }
        public void RemoveAllCommentItemsWithSerialModel(string productSerialModel)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.DeleteMultipleWhere("Comments", "ProductSerialModel = '" + productSerialModel + "'");
        }
        public Comment SelectCommentItem(string username, string serialModel)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            List<string> item = db.SelectItem("Comments",
            "Username, ProductType, ProductSerialModel, Comment, PostDateTime",
            "Username = '" + username + "' AND ProductSerialModel = '" + serialModel + "'");
            Comment selected;
            selected = new Comment(item[0], item[1], item[2], item[3], DateTime.Parse(item[4]));
            return selected;
        }
        public void GenerateComments()
        {
            AddCommentItem("Dur", "ProductGPU", "MSIGTX970IKMG44", "Not the best thing in the world.", DateTime.Now);
            AddCommentItem("Dur", "ProductRAM", "CMW16GX4M2D3600C18", "Very niiiice.", DateTime.Now);
            AddCommentItem("test2", "ProductHDD", "WD20EZAZ", "Bad bad bad!!!!", DateTime.Today);
        }
    }
}
