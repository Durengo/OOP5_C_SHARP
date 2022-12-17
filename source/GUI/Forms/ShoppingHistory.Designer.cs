namespace OOP5.source.GUI.Forms
{
    partial class ShoppingHistory
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
            this.ViewButton = new System.Windows.Forms.Button();
            this.ExportToJsonButton = new System.Windows.Forms.Button();
            this.ShoppingHistoryView = new System.Windows.Forms.ListBox();
            this.TotalProfitTextBox = new System.Windows.Forms.TextBox();
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
            // ViewButton
            // 
            this.ViewButton.AutoSize = true;
            this.ViewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ViewButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewButton.Location = new System.Drawing.Point(0, 367);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(768, 47);
            this.ViewButton.TabIndex = 12;
            this.ViewButton.Text = "View Product";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // ExportToJsonButton
            // 
            this.ExportToJsonButton.AutoSize = true;
            this.ExportToJsonButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExportToJsonButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExportToJsonButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExportToJsonButton.Location = new System.Drawing.Point(0, 320);
            this.ExportToJsonButton.Name = "ExportToJsonButton";
            this.ExportToJsonButton.Size = new System.Drawing.Size(768, 47);
            this.ExportToJsonButton.TabIndex = 13;
            this.ExportToJsonButton.Text = "Export To JSON";
            this.ExportToJsonButton.UseVisualStyleBackColor = true;
            this.ExportToJsonButton.Click += new System.EventHandler(this.ExportToJsonButton_Click);
            // 
            // ShoppingHistoryView
            // 
            this.ShoppingHistoryView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShoppingHistoryView.FormattingEnabled = true;
            this.ShoppingHistoryView.ItemHeight = 15;
            this.ShoppingHistoryView.Location = new System.Drawing.Point(0, 0);
            this.ShoppingHistoryView.Name = "ShoppingHistoryView";
            this.ShoppingHistoryView.ScrollAlwaysVisible = true;
            this.ShoppingHistoryView.Size = new System.Drawing.Size(768, 289);
            this.ShoppingHistoryView.TabIndex = 15;
            this.ShoppingHistoryView.SelectedIndexChanged += new System.EventHandler(this.ShoppingHistoryView_SelectedIndexChanged);
            // 
            // TotalProfitTextBox
            // 
            this.TotalProfitTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotalProfitTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalProfitTextBox.Location = new System.Drawing.Point(0, 291);
            this.TotalProfitTextBox.Name = "TotalProfitTextBox";
            this.TotalProfitTextBox.ReadOnly = true;
            this.TotalProfitTextBox.Size = new System.Drawing.Size(768, 29);
            this.TotalProfitTextBox.TabIndex = 16;
            this.TotalProfitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShoppingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 461);
            this.Controls.Add(this.TotalProfitTextBox);
            this.Controls.Add(this.ShoppingHistoryView);
            this.Controls.Add(this.ExportToJsonButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShoppingHistory";
            this.Text = "ShoppingHistory";
            this.Disposed += new System.EventHandler(this.ShoppingHistory_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BackButton;
        private Button ViewButton;
        private Button ExportToJsonButton;
        private ListBox ShoppingHistoryView;
        private TextBox TotalProfitTextBox;
    }
}