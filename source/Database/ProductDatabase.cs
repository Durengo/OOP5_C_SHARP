using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Database
{
    using OOP5.source.Core;
    using OOP5.source.Product;

    public class ProductDatabase
    {
        public void Generate()
        {
            if (!SessionManager.Instance.SessionConfiguration.DatabaseFound)
            {
                GenerateProductTables();
                SessionManager.Instance.DatabaseInstance.ReloadTableList();
                GenerateProducts();
                // ModifyProductValue("ProductGPU", "MSIGTX970IKMG44", "ProductName = 'MSI GTX 970 II'");
            }
        }

        public void GenerateProductTables()
        {
            SessionManager.Instance.DatabaseInstance.ShopDatabase.CreateTable(
                "ProductGPU",
                @"SerialModel TEXT,
                ProductName TEXT,
                Description TEXT,
                Price REAL,
                Picture TEXT"
            );
            SessionManager.Instance.DatabaseInstance.ShopDatabase.CreateTable(
                "ProductHDD",
                @"SerialModel TEXT,
                ProductName TEXT,
                Description TEXT,
                Price REAL,
                Picture TEXT"
            );
            SessionManager.Instance.DatabaseInstance.ShopDatabase.CreateTable(
                "ProductRAM",
                @"SerialModel TEXT,
                ProductName TEXT,
                Description TEXT,
                Price REAL,
                Picture TEXT"
            );
        }

        public void CreateNewProductTable(string name)
        {
            SessionManager.Instance.DatabaseInstance.ShopDatabase.CreateTable(
                name,
                @"SerialModel TEXT,
                ProductName TEXT,
                Description TEXT,
                Price REAL,
                Picture TEXT"
            );
        }

        public void AddProduct(
            string type,
            string productSerialModel,
            string productName,
            string productDescription,
            float productPrice,
            string productImage
        )
        {
            if (!SessionManager.Instance.DatabaseInstance.ProductTables.Contains(type))
            {
                MessageBox.Show(type + " DOES NOT EXIT!");
                return;
            }
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.InsertItem(
                type,
                "SerialModel, ProductName, Description, Price, Picture",
                "'"
                    + productSerialModel
                    + "', '"
                    + productName
                    + "', '"
                    + productDescription
                    + "', '"
                    + productPrice.ToString()
                    + "', '"
                    + Base64.ConvertAndGetImageAsString(productImage)
                    + "'"
            );
        }

        public void RemoveProduct(string type, string serialModel)
        {
            if (!SessionManager.Instance.DatabaseInstance.ProductTables.Contains(type))
            {
                MessageBox.Show(type + " DOES NOT EXIT!");
                return;
            }
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            if (db.CountWhere(type, "SerialModel = '" + serialModel + "'") > 1)
            {
                return;
            }
            SessionManager.Instance.DatabaseInstance.CommentsDB.RemoveAllCommentItemsWithSerialModel(
                serialModel
            );
            SessionManager.Instance.DatabaseInstance.WishlistDB.RemoveAllWishlistItemsWithSerialModel(
                serialModel
            );
            db.DeleteWhere(type, "SerialModel", serialModel);
        }

        public void ModifyProductValue(string type, string serialModel, string values)
        {
            if (!SessionManager.Instance.DatabaseInstance.ProductTables.Contains(type))
            {
                MessageBox.Show(type + " DOES NOT EXIT!");
                return;
            }
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            if (db.CountWhere(type, "SerialModel = '" + serialModel + "'") > 1)
            {
                return;
            }
            db.UpdateItem(type, values, "SerialModel = '" + serialModel + "'");
        }

        public Product SelectProduct(string type, string serialModel)
        {
            if (!SessionManager.Instance.DatabaseInstance.ProductTables.Contains(type))
            {
                MessageBox.Show(type + " DOES NOT EXIT!");
                return null;
            }
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;

            List<string> item = db.SelectItem(
                type,
                "SerialModel, ProductName, Description, Price, Picture",
                "SerialModel = '" + serialModel + "'"
            );
            Product selected;
            selected = new Product(
                type,
                item[0],
                item[1],
                item[2],
                float.Parse(item[3]),
                new Bitmap(Base64.Base64ToImage(item[4]))
            );
            // TODO: Add condition for no picture?
            return selected;
        }

        public Product SelectProduct(string serialModel)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            Product selected;
            for (int i = 0; i < SessionManager.Instance.DatabaseInstance.ProductTables.Count(); i++)
            {
                if (
                    db.CountWhere(
                        SessionManager.Instance.DatabaseInstance.ProductTables[i],
                        "SerialModel = '" + serialModel + "'"
                    ) == 1
                )
                {
                    List<string> item = db.SelectItem(
                        SessionManager.Instance.DatabaseInstance.ProductTables[i],
                        "SerialModel, ProductName, Description, Price, Picture",
                        "SerialModel = '" + serialModel + "'"
                    );
                    selected = new Product(
                        SessionManager.Instance.DatabaseInstance.ProductTables[i],
                        item[0],
                        item[1],
                        item[2],
                        float.Parse(item[3]),
                        new Bitmap(Base64.Base64ToImage(item[4]))
                    );
                    return selected;
                }
            }
            MessageBox.Show("PRODUCT NOT FOUND!");
            return null;
        }

        public void UpdateProductCount()
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
        }

        private void GenerateProducts()
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            //ADD GPUs:
            AddProduct(
                "ProductGPU",
                "MSIGTX970IKMG44",
                "MSI GTX 970",
                "Powerful GPU",
                (float)340.0,
                "data/products/GPU/msigtx970.png"
            );
            AddProduct(
                "ProductGPU",
                "100-506159",
                "AMD RADEON PRO W6600",
                "AMD RADEON PRO W6600 8GB GDDR6, 128bit, PCI-E 4, 4 x DP, Active",
                (float)530.0,
                "data/products/GPU/amdradeonprow6600.jpg"
            );
            AddProduct(
                "ProductGPU",
                "RX6400 CLI 4G",
                "ASROCK Radeon RX 6400 Challenger",
                "ASROCK Radeon RX 6400 Challenger ITX 4GB 64-bit GDDR6 1923/2321 MHz DP 1.4 HDMI 2.1 VRR",
                (float)195.79,
                "data/products/GPU/RX6400CLI4G.jpg"
            );
            AddProduct(
                "ProductGPU",
                "DUAL-GTX1650-O4G",
                "ASUS DUAL GTX1650",
                "ASUS Dual GeForce® GTX 1650 OC edition 4GB GDDR5 is your ticket into PC gaming. - The ASUS Dual GeForce® GTX 1650 is built with the breakthrough graphics performance of the award-winning NVIDIA Turing™ architecture to supercharge your favorite games. - Get game ready with performance that’s twice as fast as the GeForce GTX 950 and up to 70% faster than the GTX 1050. - GeForce Experience lets you capture and share videos, screenshots, and livestreams with friends, keep your GeForce drivers up to date, and easily optimize your in-game settings. - IP5X dust resistance offers protection from particle ingress for better durability. - Auto-Extreme Technology uses automation to enhance reliability. - 144-Hour Validation Program puts cards through a series of stringent tests to ensure compatibility with the latest games. - GPU Tweak II provides intuitive performance tweaking, thermal controls, and system monitoring.",
                (float)200.0,
                "data/products/GPU/asusdualgtx1650.png"
            );
            AddProduct(
                "ProductGPU",
                "90YV0IB1-M0NA00",
                "ASUS TUF Gaming GeForce RTX 4080 16GB",
                @"NVIDIA Ada Lovelace Streaming Multiprocessors: Up to 2x performance and power efficiency
                4th Generation Tensor Cores: Up to 2X AI performance
                3rd Generation RT Cores: Up to 2X ray tracing performance
                Axial-tech fans scaled up to deliver 23% more airflow
                Dual Ball Fan Bearings last up to twice as long as conventional designs
                Military-grade Capacitors rated for 20K hours at 105C make the GPU power rail more durable
                Metal Exoskeleton adds structural rigidity and vents to increase heat dissipation  
                Auto-Extreme precision automated manufacturing for higher reliability  
                GPU Tweak III software provides intuitive performance tweaking, thermal controls, and system monitoring",
                (float)1749.0,
                "data/products/GPU/asustufgaminggeforcertx4080.jpg"
            );
            AddProduct(
                "ProductGPU",
                "GV-N3050EAGLE-8GD",
                "Gigabyte GeForce RTX 3050",
                "GeForce RTX™ 3050 EAGLE 8G NVIDIA Ampere Streaming Multiprocessors 2nd Generation RT Cores 3rd Generation Tensor Cores Powered by GeForce RTX™ 3050 Integrated with 8GB GDDR6 128-bit memory interface WINDFORCE 2X Cooling System with alternate spinning fans 90mm unique blade fans Protection back plate",
                (float)343.0,
                "data/products/GPU/gigabytertx3050.png"
            );

            //ADD RAM:
            AddProduct(
                "ProductRAM",
                "CMK16GX4M2Z3200C16",
                "Corsair Vengeance LPX DDR4",
                "CORSAIR 16GB RAMKit 2x8GB DDR4 3200MHz 2x288Dimm Unbuffered 16-18-18-36 Vengeance LPX HEat Spreader 1,35V",
                (float)63.0,
                "data/products/RAM/cirsaurvebgeancelpxddr4.jpg"
            );
            AddProduct(
                "ProductRAM",
                "CMW16GX4M2D3600C18",
                "Corsair Vengeance RGB PRO DDR4",
                "CORSAIR 16GB DDR4 3600MHz 2x8GB Dimm Unbuffered 18-22-22-42",
                (float)80.0,
                "data/products/RAM/corsairvengeancergbproddr4.jpg"
            );
            AddProduct(
                "ProductRAM",
                "F4-3600C18D-16GTZRX",
                "MEMORY DIMM 16GB",
                "Trident Z RGB (For AMD) DDR4-3600 CL18-22-22-42 1.35V 16GB (2x8GB) Constructed with the highest quality components, the Trident Z RGB (For AMD) series is engineered and tested for AMD platform compatibility. Featuring a completely exposed light bar with vibrant RGB LEDs and merged with the award-winning Trident Z heatspreader designed, the Trident Z RGB (for AMD) memory kits combine the most vivid RGB lighting with uncompromised performance for supported AMD builds. ! The memory kit will boot at the SPD speed when BIOS settings are at default. If XMP is supported, enable XMP/DOCP/A-XMP profile in the BIOS to reach up to the rated XMP overclock speed of the memory kit. For XMP-enabled memory kits, reaching the rated XMP overclock speed and system stability depends on the capability of the motherboard & CPU.",
                (float)89.0,
                "data/products/RAM/memorydimm16gb.png"
            );

            //ADD HDD:
            AddProduct(
                "ProductHDD",
                "WD20EZAZ",
                "WD Blue 2TB SATA",
                "WD Blue PC Desktop Hard Drive. Boost your PC storage with WD Blue drives, the brand designed just for desktop and all-in-one PCs with a variety of storage capacities.",
                (float)58.0,
                "data/products/HDD/wdblue2tb.jpg"
            );
        }
    }
}
