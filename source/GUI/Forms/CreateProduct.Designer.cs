namespace OOP5.source.GUI.Forms
{
    partial class CreateProduct
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
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.SerialModelLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.SerialModelBox = new System.Windows.Forms.TextBox();
            this.ProductNameBox = new System.Windows.Forms.TextBox();
            this.ProductDescriptionBox = new System.Windows.Forms.TextBox();
            this.ProductPriceBox = new System.Windows.Forms.TextBox();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.UploadPictureButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ErrBox2 = new System.Windows.Forms.PictureBox();
            this.ErrBox3 = new System.Windows.Forms.PictureBox();
            this.ErrBox4 = new System.Windows.Forms.PictureBox();
            this.ErrBox5 = new System.Windows.Forms.PictureBox();
            this.ErrBox6 = new System.Windows.Forms.PictureBox();
            this.ErrBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrBox1)).BeginInit();
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
            // CategoryLabel
            // 
            this.CategoryLabel.Location = new System.Drawing.Point(156, 58);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(113, 26);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Category:";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SerialModelLabel
            // 
            this.SerialModelLabel.Location = new System.Drawing.Point(139, 84);
            this.SerialModelLabel.Name = "SerialModelLabel";
            this.SerialModelLabel.Size = new System.Drawing.Size(130, 26);
            this.SerialModelLabel.TabIndex = 5;
            this.SerialModelLabel.Text = "Serial Model:";
            this.SerialModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Location = new System.Drawing.Point(127, 110);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(142, 26);
            this.ProductNameLabel.TabIndex = 6;
            this.ProductNameLabel.Text = "Product Name:";
            this.ProductNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Location = new System.Drawing.Point(176, 136);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(93, 26);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description:";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Location = new System.Drawing.Point(176, 213);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(93, 26);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "Price:";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(275, 58);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(240, 23);
            this.CategoryBox.TabIndex = 9;
            // 
            // SerialModelBox
            // 
            this.SerialModelBox.Location = new System.Drawing.Point(275, 84);
            this.SerialModelBox.Name = "SerialModelBox";
            this.SerialModelBox.Size = new System.Drawing.Size(240, 23);
            this.SerialModelBox.TabIndex = 10;
            // 
            // ProductNameBox
            // 
            this.ProductNameBox.Location = new System.Drawing.Point(275, 110);
            this.ProductNameBox.Name = "ProductNameBox";
            this.ProductNameBox.Size = new System.Drawing.Size(240, 23);
            this.ProductNameBox.TabIndex = 11;
            // 
            // ProductDescriptionBox
            // 
            this.ProductDescriptionBox.Location = new System.Drawing.Point(275, 136);
            this.ProductDescriptionBox.Multiline = true;
            this.ProductDescriptionBox.Name = "ProductDescriptionBox";
            this.ProductDescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProductDescriptionBox.Size = new System.Drawing.Size(240, 71);
            this.ProductDescriptionBox.TabIndex = 12;
            // 
            // ProductPriceBox
            // 
            this.ProductPriceBox.Location = new System.Drawing.Point(275, 213);
            this.ProductPriceBox.Name = "ProductPriceBox";
            this.ProductPriceBox.Size = new System.Drawing.Size(240, 23);
            this.ProductPriceBox.TabIndex = 13;
            // 
            // PictureLabel
            // 
            this.PictureLabel.Location = new System.Drawing.Point(176, 239);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(93, 26);
            this.PictureLabel.TabIndex = 14;
            this.PictureLabel.Text = "Picture:";
            this.PictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.PictureBox.ImageLocation = "";
            this.PictureBox.Location = new System.Drawing.Point(328, 239);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(128, 128);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 36;
            this.PictureBox.TabStop = false;
            // 
            // UploadPictureButton
            // 
            this.UploadPictureButton.Location = new System.Drawing.Point(355, 373);
            this.UploadPictureButton.Name = "UploadPictureButton";
            this.UploadPictureButton.Size = new System.Drawing.Size(75, 23);
            this.UploadPictureButton.TabIndex = 37;
            this.UploadPictureButton.Text = "Upload";
            this.UploadPictureButton.UseVisualStyleBackColor = true;
            this.UploadPictureButton.Click += new System.EventHandler(this.UploadPictureButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.AutoSize = true;
            this.CreateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateButton.Location = new System.Drawing.Point(0, 467);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(784, 47);
            this.CreateButton.TabIndex = 38;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ErrBox2
            // 
            this.ErrBox2.BackColor = System.Drawing.Color.Red;
            this.ErrBox2.Location = new System.Drawing.Point(521, 84);
            this.ErrBox2.Name = "ErrBox2";
            this.ErrBox2.Size = new System.Drawing.Size(15, 15);
            this.ErrBox2.TabIndex = 42;
            this.ErrBox2.TabStop = false;
            this.ErrBox2.Click += new System.EventHandler(this.ErrBox2_Click);
            // 
            // ErrBox3
            // 
            this.ErrBox3.BackColor = System.Drawing.Color.Red;
            this.ErrBox3.Location = new System.Drawing.Point(521, 110);
            this.ErrBox3.Name = "ErrBox3";
            this.ErrBox3.Size = new System.Drawing.Size(15, 15);
            this.ErrBox3.TabIndex = 43;
            this.ErrBox3.TabStop = false;
            this.ErrBox3.Click += new System.EventHandler(this.ErrBox3_Click);
            // 
            // ErrBox4
            // 
            this.ErrBox4.BackColor = System.Drawing.Color.Red;
            this.ErrBox4.Location = new System.Drawing.Point(521, 136);
            this.ErrBox4.Name = "ErrBox4";
            this.ErrBox4.Size = new System.Drawing.Size(15, 15);
            this.ErrBox4.TabIndex = 44;
            this.ErrBox4.TabStop = false;
            this.ErrBox4.Click += new System.EventHandler(this.ErrBox4_Click);
            // 
            // ErrBox5
            // 
            this.ErrBox5.BackColor = System.Drawing.Color.Red;
            this.ErrBox5.Location = new System.Drawing.Point(521, 213);
            this.ErrBox5.Name = "ErrBox5";
            this.ErrBox5.Size = new System.Drawing.Size(15, 15);
            this.ErrBox5.TabIndex = 45;
            this.ErrBox5.TabStop = false;
            this.ErrBox5.Click += new System.EventHandler(this.ErrBox5_Click);
            // 
            // ErrBox6
            // 
            this.ErrBox6.BackColor = System.Drawing.Color.Red;
            this.ErrBox6.Location = new System.Drawing.Point(436, 373);
            this.ErrBox6.Name = "ErrBox6";
            this.ErrBox6.Size = new System.Drawing.Size(15, 15);
            this.ErrBox6.TabIndex = 46;
            this.ErrBox6.TabStop = false;
            this.ErrBox6.Click += new System.EventHandler(this.ErrBox6_Click);
            // 
            // ErrBox1
            // 
            this.ErrBox1.BackColor = System.Drawing.Color.Red;
            this.ErrBox1.Location = new System.Drawing.Point(521, 58);
            this.ErrBox1.Name = "ErrBox1";
            this.ErrBox1.Size = new System.Drawing.Size(15, 15);
            this.ErrBox1.TabIndex = 41;
            this.ErrBox1.TabStop = false;
            this.ErrBox1.Click += new System.EventHandler(this.ErrBox1_Click);
            // 
            // CreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ErrBox6);
            this.Controls.Add(this.ErrBox5);
            this.Controls.Add(this.ErrBox4);
            this.Controls.Add(this.ErrBox3);
            this.Controls.Add(this.ErrBox2);
            this.Controls.Add(this.ErrBox1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.UploadPictureButton);
            this.Controls.Add(this.PictureLabel);
            this.Controls.Add(this.ProductPriceBox);
            this.Controls.Add(this.ProductDescriptionBox);
            this.Controls.Add(this.ProductNameBox);
            this.Controls.Add(this.SerialModelBox);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.SerialModelLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateProduct";
            this.Text = "CreateProduct";
            this.Disposed += new System.EventHandler(this.CreateProduct_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BackButton;
        private Label CategoryLabel;
        private Label SerialModelLabel;
        private Label ProductNameLabel;
        private Label DescriptionLabel;
        private Label PriceLabel;
        private ComboBox CategoryBox;
        private TextBox SerialModelBox;
        private TextBox ProductNameBox;
        private TextBox ProductDescriptionBox;
        private TextBox ProductPriceBox;
        private Label PictureLabel;
        private PictureBox PictureBox;
        private Button UploadPictureButton;
        private Button CreateButton;
        private OpenFileDialog openFileDialog1;
        private PictureBox ErrBox2;
        private PictureBox ErrBox3;
        private PictureBox ErrBox4;
        private PictureBox ErrBox5;
        private PictureBox ErrBox6;
        private PictureBox ErrBox1;
    }
}