using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Product
{
    public class Product
    {
        private string ProductType;
        private string SerialModel;
        private string ProductName;
        private string ProductDescription;
        float ProductPrice;
        private Bitmap ProductImage;

        public Product(string type, string serialModel, string name, string description, float price, Bitmap image)
        {
            ProductType = type;
            SerialModel = serialModel;
            ProductName = name;
            ProductDescription = description;
            ProductPrice = price;
            ProductImage = image;
        }
        public Product(string serialModel, string name, string description, float price, Bitmap image)
        {
            SerialModel = serialModel;
            ProductName = name;
            ProductDescription = description;
            ProductPrice = price;
            ProductImage = image;
        }
        public string Type
        {
            get { return ProductType; }
            set { ProductType = value; }
        }
        public string Model
        {
            get { return SerialModel; }
            set { SerialModel = value; }
        }
        public string Name
        {
            get { return ProductName; }
            set { ProductName = value; }
        }
        public string Description
        {
            get { return ProductDescription; }
            set { ProductDescription = value; }
        }
        public float Price
        {
            get { return ProductPrice; }
            set { ProductPrice = value; }
        }
        public Bitmap Image
        {
            get { return ProductImage; }
            set { ProductImage = value; }
        }
    }
}
