namespace OOP5.source.GUI.Forms
{
    partial class CommentsArchive
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ProductView = new System.Windows.Forms.ListView();
            this.BackButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ProductView
            // 
            this.ProductView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductView.Location = new System.Drawing.Point(0, 0);
            this.ProductView.MultiSelect = false;
            this.ProductView.Name = "ProductView";
            this.ProductView.Size = new System.Drawing.Size(768, 405);
            this.ProductView.TabIndex = 10;
            this.ProductView.UseCompatibleStateImageBehavior = false;
            this.ProductView.SelectedIndexChanged += new System.EventHandler(this.ProductView_SelectedIndexChanged);
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(0, 405);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(81, 56);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.AutoSize = true;
            this.ViewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ViewButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewButton.Location = new System.Drawing.Point(584, 405);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(184, 56);
            this.ViewButton.TabIndex = 12;
            this.ViewButton.Text = "View Product";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // CommentsArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 461);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ProductView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CommentsArchive";
            this.Text = "CommentsArchive";
            this.Disposed += new System.EventHandler(this.CommentsArchive_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ImageList imageList1;
        private ListView ProductView;
        private Button BackButton;
        private Button ViewButton;
    }
}