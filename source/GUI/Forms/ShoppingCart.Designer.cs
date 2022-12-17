namespace OOP5.source.GUI.Forms
{
    partial class ShoppingCart
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
            this.BuyButton = new System.Windows.Forms.Button();
            this.ProductView = new System.Windows.Forms.ListBox();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ViewProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.AutoSize = true;
            this.BuyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BuyButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuyButton.Location = new System.Drawing.Point(0, 273);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(768, 47);
            this.BuyButton.TabIndex = 13;
            this.BuyButton.Text = "Pay";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // ProductView
            // 
            this.ProductView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductView.FormattingEnabled = true;
            this.ProductView.ItemHeight = 15;
            this.ProductView.Location = new System.Drawing.Point(0, 0);
            this.ProductView.Name = "ProductView";
            this.ProductView.ScrollAlwaysVisible = true;
            this.ProductView.Size = new System.Drawing.Size(768, 244);
            this.ProductView.TabIndex = 14;
            this.ProductView.SelectedIndexChanged += new System.EventHandler(this.ProductView_SelectedIndexChanged);
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotalPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceTextBox.Location = new System.Drawing.Point(0, 244);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.ReadOnly = true;
            this.TotalPriceTextBox.Size = new System.Drawing.Size(768, 29);
            this.TotalPriceTextBox.TabIndex = 15;
            this.TotalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.AutoSize = true;
            this.RemoveItemButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveItemButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RemoveItemButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveItemButton.Location = new System.Drawing.Point(0, 367);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(768, 47);
            this.RemoveItemButton.TabIndex = 16;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ViewProductButton
            // 
            this.ViewProductButton.AutoSize = true;
            this.ViewProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewProductButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ViewProductButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewProductButton.Location = new System.Drawing.Point(0, 320);
            this.ViewProductButton.Name = "ViewProductButton";
            this.ViewProductButton.Size = new System.Drawing.Size(768, 47);
            this.ViewProductButton.TabIndex = 17;
            this.ViewProductButton.Text = "View Product";
            this.ViewProductButton.UseVisualStyleBackColor = true;
            this.ViewProductButton.Click += new System.EventHandler(this.ViewProductButton_Click);
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 461);
            this.Controls.Add(this.TotalPriceTextBox);
            this.Controls.Add(this.ProductView);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.ViewProductButton);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShoppingCart";
            this.Text = "ShoppingCart";
            this.Disposed += new System.EventHandler(this.ShoppingCart_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BackButton;
        private Button BuyButton;
        private ListBox ProductView;
        private TextBox TotalPriceTextBox;
        private Button RemoveItemButton;
        private Button ViewProductButton;
    }
}