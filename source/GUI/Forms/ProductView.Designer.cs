namespace OOP5.source.GUI.Forms
{
    partial class ProductView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WishlistButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.ProductName = new System.Windows.Forms.Label();
            this.ProductSerialModel = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.Comments = new System.Windows.Forms.ListView();
            this.writeCommentButton1 = new System.Windows.Forms.Button();
            this.deleteCommentButton1 = new System.Windows.Forms.Button();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.CheckOutTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // WishlistButton
            // 
            this.WishlistButton.AutoSize = true;
            this.WishlistButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WishlistButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WishlistButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WishlistButton.Location = new System.Drawing.Point(0, 367);
            this.WishlistButton.Name = "WishlistButton";
            this.WishlistButton.Size = new System.Drawing.Size(768, 47);
            this.WishlistButton.TabIndex = 15;
            this.WishlistButton.Text = "Add To Wishlist";
            this.WishlistButton.UseVisualStyleBackColor = true;
            this.WishlistButton.Click += new System.EventHandler(this.WishlistButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(0, 414);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(768, 47);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ProductImage
            // 
            this.ProductImage.Location = new System.Drawing.Point(12, 12);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(229, 223);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImage.TabIndex = 17;
            this.ProductImage.TabStop = false;
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductName.Location = new System.Drawing.Point(247, 12);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(136, 25);
            this.ProductName.TabIndex = 18;
            this.ProductName.Text = "ProductName";
            // 
            // ProductSerialModel
            // 
            this.ProductSerialModel.AutoSize = true;
            this.ProductSerialModel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductSerialModel.Location = new System.Drawing.Point(247, 37);
            this.ProductSerialModel.Name = "ProductSerialModel";
            this.ProductSerialModel.Size = new System.Drawing.Size(108, 13);
            this.ProductSerialModel.TabIndex = 19;
            this.ProductSerialModel.Text = "ProductSerialModel";
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSize = true;
            this.ProductPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductPrice.Location = new System.Drawing.Point(636, 68);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(120, 25);
            this.ProductPrice.TabIndex = 20;
            this.ProductPrice.Text = "ProductPrice";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(247, 76);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.DescriptionLabel.TabIndex = 22;
            this.DescriptionLabel.Text = "Description";
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Description.Location = new System.Drawing.Point(247, 96);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Description.Size = new System.Drawing.Size(509, 139);
            this.Description.TabIndex = 24;
            this.Description.Text = "Description";
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CommentLabel.Location = new System.Drawing.Point(12, 240);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(74, 17);
            this.CommentLabel.TabIndex = 25;
            this.CommentLabel.Text = "Comments";
            // 
            // Comments
            // 
            this.Comments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Comments.Location = new System.Drawing.Point(0, 270);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(768, 97);
            this.Comments.TabIndex = 26;
            this.Comments.UseCompatibleStateImageBehavior = false;
            this.Comments.View = System.Windows.Forms.View.List;
            this.Comments.SelectedIndexChanged += new System.EventHandler(this.Comments_SelectedIndexChanged);
            // 
            // writeCommentButton1
            // 
            this.writeCommentButton1.AutoSize = true;
            this.writeCommentButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.writeCommentButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.writeCommentButton1.Location = new System.Drawing.Point(636, 241);
            this.writeCommentButton1.Name = "writeCommentButton1";
            this.writeCommentButton1.Size = new System.Drawing.Size(121, 27);
            this.writeCommentButton1.TabIndex = 27;
            this.writeCommentButton1.Text = "Write A Comment";
            this.writeCommentButton1.UseVisualStyleBackColor = true;
            this.writeCommentButton1.Click += new System.EventHandler(this.writeCommentButton1_Click);
            // 
            // deleteCommentButton1
            // 
            this.deleteCommentButton1.AutoSize = true;
            this.deleteCommentButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteCommentButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCommentButton1.Location = new System.Drawing.Point(575, 241);
            this.deleteCommentButton1.Name = "deleteCommentButton1";
            this.deleteCommentButton1.Size = new System.Drawing.Size(55, 27);
            this.deleteCommentButton1.TabIndex = 28;
            this.deleteCommentButton1.Text = "Delete";
            this.deleteCommentButton1.UseVisualStyleBackColor = true;
            this.deleteCommentButton1.Click += new System.EventHandler(this.deleteCommentButton1_Click);
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.AutoSize = true;
            this.AddToCartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddToCartButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddToCartButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddToCartButton.Location = new System.Drawing.Point(668, 37);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(88, 27);
            this.AddToCartButton.TabIndex = 29;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = false;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.AutoSize = true;
            this.CheckoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CheckoutButton.BackColor = System.Drawing.Color.Cornsilk;
            this.CheckoutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckoutButton.Location = new System.Drawing.Point(685, 10);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(71, 27);
            this.CheckoutButton.TabIndex = 30;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = false;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // CheckOutTotalPrice
            // 
            this.CheckOutTotalPrice.AutoSize = true;
            this.CheckOutTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckOutTotalPrice.Location = new System.Drawing.Point(630, 15);
            this.CheckOutTotalPrice.Name = "CheckOutTotalPrice";
            this.CheckOutTotalPrice.Size = new System.Drawing.Size(49, 17);
            this.CheckOutTotalPrice.TabIndex = 31;
            this.CheckOutTotalPrice.Text = "ChkTTL";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 461);
            this.Controls.Add(this.CheckOutTotalPrice);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.deleteCommentButton1);
            this.Controls.Add(this.writeCommentButton1);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.ProductSerialModel);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductImage);
            this.Controls.Add(this.WishlistButton);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductView";
            this.Text = "ProductView";
            this.Disposed += new System.EventHandler(this.ProductView_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button WishlistButton;
        private Button BackButton;
        private PictureBox ProductImage;
        private Label ProductName;
        private Label ProductSerialModel;
        private Label ProductPrice;
        private Label DescriptionLabel;
        private TextBox Description;
        private Label CommentLabel;
        private ListView Comments;
        private Button writeCommentButton1;
        private Button deleteCommentButton1;
        private Button AddToCartButton;
        private Button CheckoutButton;
        private Label CheckOutTotalPrice;
    }
}