using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Shop
{
    public class WishlistItem
    {
        private string WishlistUsername;
        private string WishlistProductType;
        private string WishlistProductSerialModel;
        public WishlistItem(string username, string type, string serialModel)
        {
            WishlistUsername = username;
            WishlistProductType = type;
            WishlistProductSerialModel = serialModel;
        }
        public string Username
        {
            get { return WishlistUsername; }
            set { WishlistUsername = value; }
        }
        public string Type
        {
            get { return WishlistProductType; }
            set { WishlistProductType = value; }
        }
        public string SerialModel
        {
            get { return WishlistProductSerialModel; }
            set { WishlistProductSerialModel = value; }
        }
    }
}
