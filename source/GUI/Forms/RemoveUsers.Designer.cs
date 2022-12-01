namespace OOP5.source.GUI.Forms
{
    partial class RemoveUsers
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
            this.userList = new System.Windows.Forms.ListBox();
            this.removeButton1 = new System.Windows.Forms.Button();
            this.backButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userList.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 37;
            this.userList.Location = new System.Drawing.Point(0, 0);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(784, 361);
            this.userList.TabIndex = 0;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // removeButton1
            // 
            this.removeButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.removeButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeButton1.Location = new System.Drawing.Point(0, 239);
            this.removeButton1.Name = "removeButton1";
            this.removeButton1.Size = new System.Drawing.Size(784, 61);
            this.removeButton1.TabIndex = 4;
            this.removeButton1.Text = "Remove";
            this.removeButton1.UseVisualStyleBackColor = true;
            this.removeButton1.Click += new System.EventHandler(this.removeButton1_Click);
            // 
            // backButton1
            // 
            this.backButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton1.Location = new System.Drawing.Point(0, 300);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(784, 61);
            this.backButton1.TabIndex = 3;
            this.backButton1.Text = "Back";
            this.backButton1.UseVisualStyleBackColor = true;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // RemoveUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.removeButton1);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.userList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RemoveUsers";
            this.Text = "RemoveUsers";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox userList;
        private Button removeButton1;
        private Button backButton1;
    }
}