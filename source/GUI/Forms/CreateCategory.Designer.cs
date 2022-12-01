namespace OOP5.source.GUI.Forms
{
    partial class CreateCategory
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TrueDisplayInDatabaseLabel = new System.Windows.Forms.Label();
            this.TrueDisplayTextBox = new System.Windows.Forms.TextBox();
            this.ErrMsg = new System.Windows.Forms.Label();
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
            // CreateButton
            // 
            this.CreateButton.AutoSize = true;
            this.CreateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateButton.Location = new System.Drawing.Point(0, 467);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(784, 47);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoryTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryTextBox.Location = new System.Drawing.Point(0, 41);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(784, 29);
            this.CategoryTextBox.TabIndex = 5;
            this.CategoryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CategoryTextBox.TextChanged += new System.EventHandler(this.CategoryTextBox_TextChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryLabel.Location = new System.Drawing.Point(0, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(784, 41);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "New Category Name";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrueDisplayInDatabaseLabel
            // 
            this.TrueDisplayInDatabaseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TrueDisplayInDatabaseLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TrueDisplayInDatabaseLabel.Location = new System.Drawing.Point(0, 70);
            this.TrueDisplayInDatabaseLabel.Name = "TrueDisplayInDatabaseLabel";
            this.TrueDisplayInDatabaseLabel.Size = new System.Drawing.Size(784, 73);
            this.TrueDisplayInDatabaseLabel.TabIndex = 7;
            this.TrueDisplayInDatabaseLabel.Text = "New Category Will Be Dsiplayed As Such In the Database";
            this.TrueDisplayInDatabaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrueDisplayTextBox
            // 
            this.TrueDisplayTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TrueDisplayTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TrueDisplayTextBox.Location = new System.Drawing.Point(0, 143);
            this.TrueDisplayTextBox.Name = "TrueDisplayTextBox";
            this.TrueDisplayTextBox.ReadOnly = true;
            this.TrueDisplayTextBox.Size = new System.Drawing.Size(784, 29);
            this.TrueDisplayTextBox.TabIndex = 8;
            this.TrueDisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ErrMsg
            // 
            this.ErrMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ErrMsg.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrMsg.Location = new System.Drawing.Point(0, 394);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(784, 73);
            this.ErrMsg.TabIndex = 9;
            this.ErrMsg.Text = "Category Already Exists!";
            this.ErrMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.TrueDisplayTextBox);
            this.Controls.Add(this.TrueDisplayInDatabaseLabel);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateCategory";
            this.Text = "CreateCategory";
            this.Disposed += new System.EventHandler(this.CreateCategory_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BackButton;
        private Button CreateButton;
        private TextBox CategoryTextBox;
        private Label CategoryLabel;
        private Label TrueDisplayInDatabaseLabel;
        private TextBox TrueDisplayTextBox;
        private Label ErrMsg;
    }
}