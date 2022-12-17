using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Shop
{
    public class Comment
    {
        private string CommentUsername;
        private string CommentProductType;
        private string CommentProductModel;
        private string CommentText;
        private DateTime CommentDate;

        public Comment(string username, string type, string model, string comment, DateTime date)
        {
            CommentUsername = username;
            CommentProductType = type;
            CommentProductModel = model;
            CommentText = comment;
            CommentDate = date;
        }

        public string Username
        {
            get { return CommentUsername; }
            set { CommentUsername = value; }
        }
        public string Type
        {
            get { return CommentProductType; }
            set { CommentProductType = value; }
        }
        public string ProductSerialModel
        {
            get { return CommentProductModel; }
            set { CommentProductModel = value; }
        }
        public string Text
        {
            get { return CommentText; }
            set { CommentText = value; }
        }
        public DateTime Date
        {
            get { return CommentDate; }
            set { CommentDate = value; }
        }
    }
}
