namespace OOP5.source.GUI.Forms
{
    partial class RemoveProduct
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
            this.BackButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.ProductBox = new System.Windows.Forms.ComboBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.ProductPriceBox = new System.Windows.Forms.TextBox();
            this.ProductDescriptionBox = new System.Windows.Forms.TextBox();
            this.SerialModelBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SerialModelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(0, 514);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(784, 47);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.AutoSize = true;
            this.RemoveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveButton.Location = new System.Drawing.Point(0, 467);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(784, 47);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove Product";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Location = new System.Drawing.Point(158, 52);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(113, 26);
            this.CategoryLabel.TabIndex = 9;
            this.CategoryLabel.Text = "Category:";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Location = new System.Drawing.Point(129, 85);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(142, 26);
            this.ProductNameLabel.TabIndex = 10;
            this.ProductNameLabel.Text = "Product Name:";
            this.ProductNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(277, 52);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(240, 23);
            this.CategoryBox.TabIndex = 11;
            this.CategoryBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBox_SelectedIndexChanged);
            // 
            // ProductBox
            // 
            this.ProductBox.FormattingEnabled = true;
            this.ProductBox.Location = new System.Drawing.Point(277, 85);
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.Size = new System.Drawing.Size(240, 23);
            this.ProductBox.TabIndex = 12;
            this.ProductBox.SelectedIndexChanged += new System.EventHandler(this.ProductBox_SelectedIndexChanged);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.PictureBox.ImageLocation = "";
            this.PictureBox.Location = new System.Drawing.Point(330, 294);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(128, 128);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 44;
            this.PictureBox.TabStop = false;
            // 
            // PictureLabel
            // 
            this.PictureLabel.Location = new System.Drawing.Point(178, 294);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(93, 26);
            this.PictureLabel.TabIndex = 43;
            this.PictureLabel.Text = "Picture:";
            this.PictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductPriceBox
            // 
            this.ProductPriceBox.Location = new System.Drawing.Point(277, 268);
            this.ProductPriceBox.Name = "ProductPriceBox";
            this.ProductPriceBox.ReadOnly = true;
            this.ProductPriceBox.Size = new System.Drawing.Size(240, 23);
            this.ProductPriceBox.TabIndex = 42;
            // 
            // ProductDescriptionBox
            // 
            this.ProductDescriptionBox.Location = new System.Drawing.Point(277, 191);
            this.ProductDescriptionBox.Multiline = true;
            this.ProductDescriptionBox.Name = "ProductDescriptionBox";
            this.ProductDescriptionBox.ReadOnly = true;
            this.ProductDescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProductDescriptionBox.Size = new System.Drawing.Size(240, 71);
            this.ProductDescriptionBox.TabIndex = 41;
            // 
            // SerialModelBox
            // 
            this.SerialModelBox.Location = new System.Drawing.Point(277, 139);
            this.SerialModelBox.Name = "SerialModelBox";
            this.SerialModelBox.ReadOnly = true;
            this.SerialModelBox.Size = new System.Drawing.Size(240, 23);
            this.SerialModelBox.TabIndex = 40;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Location = new System.Drawing.Point(178, 268);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(93, 26);
            this.PriceLabel.TabIndex = 39;
            this.PriceLabel.Text = "Price:";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Location = new System.Drawing.Point(178, 191);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(93, 26);
            this.DescriptionLabel.TabIndex = 38;
            this.DescriptionLabel.Text = "Description:";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SerialModelLabel
            // 
            this.SerialModelLabel.Location = new System.Drawing.Point(141, 139);
            this.SerialModelLabel.Name = "SerialModelLabel";
            this.SerialModelLabel.Size = new System.Drawing.Size(130, 26);
            this.SerialModelLabel.TabIndex = 37;
            this.SerialModelLabel.Text = "Serial Model:";
            this.SerialModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RemoveProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.PictureLabel);
            this.Controls.Add(this.ProductPriceBox);
            this.Controls.Add(this.ProductDescriptionBox);
            this.Controls.Add(this.SerialModelBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.SerialModelLabel);
            this.Controls.Add(this.ProductBox);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RemoveProduct";
            this.Text = "RemoveProduct";
            this.Disposed += new System.EventHandler(this.RemoveProduct_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BackButton;
        private Button RemoveButton;
        private Label CategoryLabel;
        private Label ProductNameLabel;
        private ComboBox CategoryBox;
        private ComboBox ProductBox;
        private PictureBox PictureBox;
        private Label PictureLabel;
        private TextBox ProductPriceBox;
        private TextBox ProductDescriptionBox;
        private TextBox SerialModelBox;
        private Label PriceLabel;
        private Label DescriptionLabel;
        private Label SerialModelLabel;
    }
}