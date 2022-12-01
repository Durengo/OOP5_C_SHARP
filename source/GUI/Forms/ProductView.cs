using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP5.source.GUI.Forms
{
    using OOP5.source.Core;
    using OOP5.source.Shop;
    public partial class ProductView : Form
    {
        public string SerialModelSelected;
        public Product.Product Item;
        private WishlistItem WItem;
        private List<Comment> CommentItems = new List<Comment>();
        private int SelectedComment = -1;
        public bool FromWishlist = false;
        public ProductView()
        {
            InitializeComponent();
        }
        public void SelectItem()
        {
            Item = SessionManager.Instance.DatabaseInstance.ProductDB.SelectProduct(SerialModelSelected);
        }

        public void ReloadData()
        {
            SelectedComment = -1;
            CommentItems.Clear();
            Comments.Items.Clear();
            SelectItem();
            ProductName.Text = Item.Name;
            ProductSerialModel.Text = Item.Model;
            ProductPrice.Text = Item.Price.ToString() + " EUR";
            ProductImage.Image = Item.Image;
            Description.Text = Item.Description;

            WItem = null;
            WishlistButton.Text = "Add To Wishlist";

            WishlistButton.Enabled = false;
            WishlistButton.Hide();

            writeCommentButton1.Hide();
            writeCommentButton1.Enabled = false;

            deleteCommentButton1.Hide();
            deleteCommentButton1.Enabled = false;


            int internalCounter = 5;
            var comments = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValueWhere("Comments",
            "Username, ProductType, ProductSerialModel, Comment, PostDateTime", "ProductSerialModel = '" + Item.Model + "'");
            for (int i = 0; i < comments.Count() / 5; i++)
            {
                var item = new Comment(
                    comments[internalCounter - 5],
                    comments[internalCounter - 4],
                    comments[internalCounter - 3],
                    comments[internalCounter - 2],
                    DateTime.Parse(comments[internalCounter - 1]));
                CommentItems.Add(item);
                internalCounter += 5;
                Comments.Items.Add(CommentItems[i].Username + " (" + CommentItems[i].Date + "): " + CommentItems[i].Text);
            }


            if (SessionManager.Instance.currentUser != null)
            {
                // WISHLIST:
                WishlistButton.Enabled = true;
                WishlistButton.Show();
                int count = SessionManager.Instance.DatabaseInstance.ShopDatabase.CountWhere("Wishlist",
                "Username = '" + SessionManager.Instance.currentUser.Username + "' AND ProductSerialModel = '" + Item.Model + "'");
                if (count == 1)
                {
                    WItem = SessionManager.Instance.DatabaseInstance.WishlistDB.SelectWishlistItem(SessionManager.Instance.currentUser.Username, Item.Model);
                    WishlistButton.Text = "Remove From Wishlist";
                }
                // COMMENTS:
                writeCommentButton1.Show();
                writeCommentButton1.Enabled = true;
                for(int i = 0; i < CommentItems.Count(); i++)
                {
                    if(CommentItems[i].Username == SessionManager.Instance.currentUser.Username)
                    {
                        writeCommentButton1.Enabled = false;
                        break;
                    }
                }
                if (SessionManager.Instance.currentUser.UserAccountType == User.AccountType.ADMINISTRATOR)
                {
                    deleteCommentButton1.Show();
                }
            }


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[7].Hide();
            ProductName.Text = "";
            ProductSerialModel.Text = "";
            ProductPrice.Text = "";
            ProductImage.Image = null;
            Description.Text = "";
            //Description.Items.Clear();

            Comments.Items.Clear();
            if (FromWishlist)
            {
                FromWishlist = false;
                var Form = (Wishlist)SessionManager.Instance.openForms[8];
                Form.ReloadData();
                SessionManager.Instance.openForms[8].Show();
            }
            else
            {
                SessionManager.Instance.openForms[6].Show();
            }
        }

        private void ProductView_Closing(object sender, EventArgs e)
        {
            for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            {
                SessionManager.Instance.openForms[SessionManager.Instance.openForms.Count - 1 - i].Close();
            }
        }

        private void WishlistButton_Click(object sender, EventArgs e)
        {
            var db = SessionManager.Instance.DatabaseInstance.WishlistDB;
            if (WItem == null)
            {
                db.AddWishlistItem(SessionManager.Instance.currentUser.Username, Item.Type, Item.Model);
                WItem = db.SelectWishlistItem(SessionManager.Instance.currentUser.Username, Item.Model);
                WishlistButton.Text = "Remove From Wishlist";
            }
            else
            {
                db.RemoveWishlistItem(SessionManager.Instance.currentUser.Username, Item.Model);
                WItem = null;
                WishlistButton.Text = "Add To Wishlist";
                //db.SelectWishlistItem()
            }
        }

        private void writeCommentButton1_Click(object sender, EventArgs e)
        {
            WriteComment popup = new WriteComment();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            ReloadData();
        }

        //CREATE COMMENT RELOAD FUNC

        private void deleteCommentButton1_Click(object sender, EventArgs e)
        {
            var item = CommentItems[SelectedComment];
            SessionManager.Instance.DatabaseInstance.CommentsDB.RemoveCommentItem(item.Username, item.ProductSerialModel);
            ReloadData();
        }

        private void Comments_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedComment = Comments.FocusedItem.Index;
            if (SessionManager.Instance.currentUser != null && SessionManager.Instance.currentUser.UserAccountType == User.AccountType.ADMINISTRATOR && SelectedComment != -1)
            {
                deleteCommentButton1.Enabled = true;
            }
        }
    }
}
