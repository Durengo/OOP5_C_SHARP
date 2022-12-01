namespace OOP5.source.GUI.Forms
{
    partial class DebugMenu
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
            this.dbUserList = new System.Windows.Forms.ListView();
            this.ChangeDBButton1 = new System.Windows.Forms.Button();
            this.jsonLabel = new System.Windows.Forms.Label();
            this.selection = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.ConnectionStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dbUserList
            // 
            this.dbUserList.Location = new System.Drawing.Point(572, 77);
            this.dbUserList.Name = "dbUserList";
            this.dbUserList.Size = new System.Drawing.Size(182, 111);
            this.dbUserList.TabIndex = 11;
            this.dbUserList.UseCompatibleStateImageBehavior = false;
            // 
            // ChangeDBButton1
            // 
            this.ChangeDBButton1.Location = new System.Drawing.Point(679, 45);
            this.ChangeDBButton1.Name = "ChangeDBButton1";
            this.ChangeDBButton1.Size = new System.Drawing.Size(75, 23);
            this.ChangeDBButton1.TabIndex = 10;
            this.ChangeDBButton1.Text = "ChangeDB";
            this.ChangeDBButton1.UseVisualStyleBackColor = true;
            // 
            // jsonLabel
            // 
            this.jsonLabel.AutoSize = true;
            this.jsonLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jsonLabel.Location = new System.Drawing.Point(47, 352);
            this.jsonLabel.Name = "jsonLabel";
            this.jsonLabel.Size = new System.Drawing.Size(190, 54);
            this.jsonLabel.TabIndex = 9;
            this.jsonLabel.Text = "jsonLabel";
            // 
            // selection
            // 
            this.selection.AutoSize = true;
            this.selection.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selection.Location = new System.Drawing.Point(101, 77);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(180, 54);
            this.selection.TabIndex = 8;
            this.selection.Text = "selection";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versionLabel.Location = new System.Drawing.Point(305, 291);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(184, 54);
            this.versionLabel.TabIndex = 7;
            this.versionLabel.Text = "VERSION";
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.AutoSize = true;
            this.ConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConnectionStatus.Location = new System.Drawing.Point(236, 189);
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.Size = new System.Drawing.Size(345, 54);
            this.ConnectionStatus.TabIndex = 6;
            this.ConnectionStatus.Text = "NO CONNECTION";
            // 
            // DebugMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 461);
            this.Controls.Add(this.dbUserList);
            this.Controls.Add(this.ChangeDBButton1);
            this.Controls.Add(this.jsonLabel);
            this.Controls.Add(this.selection);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.ConnectionStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DebugMenu";
            this.Text = "DebugMenu";
            this.Disposed += new System.EventHandler(this.DebugMenu_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView dbUserList;
        private Button ChangeDBButton1;
        private Label jsonLabel;
        private Label selection;
        private Label versionLabel;
        private Label ConnectionStatus;
    }
}