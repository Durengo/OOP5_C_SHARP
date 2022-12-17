using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Shop
{
    public class ShoppingCart
    {
        private string CartItemUsername;
        private string ProductType;
        private string ProductSerialModel;
        private DateTime CartItemDate;

        // "Paid" or "Unpaid"
        private string CartItemStatus;

        public ShoppingCart(
            string user,
            string productType,
            string productSerialModel,
            DateTime date,
            string status
        )
        {
            CartItemUsername = user;
            ProductType = productType;
            ProductSerialModel = productSerialModel;
            CartItemDate = date;
            CartItemStatus = status;
        }

        public string CartItemUser
        {
            get { return CartItemUsername; }
            set { CartItemUsername = value; }
        }
        public string CartType
        {
            get { return ProductType; }
            set { ProductType = value; }
        }
        public string CartProduct
        {
            get { return ProductSerialModel; }
            set { ProductSerialModel = value; }
        }
        public DateTime CartDate
        {
            get { return CartItemDate; }
            set { CartItemDate = value; }
        }
        public string CartStatus
        {
            get { return CartItemStatus; }
            set { CartItemStatus = value; }
        }
    }
}
