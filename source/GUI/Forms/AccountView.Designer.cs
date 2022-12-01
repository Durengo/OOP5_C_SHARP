namespace OOP5.source.GUI.Forms
{
    partial class AccountView
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
            this.label1 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.surnameDisplay = new System.Windows.Forms.TextBox();
            this.nameDisplay = new System.Windows.Forms.TextBox();
            this.usernameDisplay = new System.Windows.Forms.TextBox();
            this.passwordDisplay = new System.Windows.Forms.TextBox();
            this.birthdayDisplay = new System.Windows.Forms.TextBox();
            this.passwordShow = new System.Windows.Forms.CheckBox();
            this.avatarLabel1 = new System.Windows.Forms.Label();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.imageButton = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(0, 500);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(784, 61);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 500);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(51, 177);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(116, 32);
            this.passwordLabel.TabIndex = 35;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(41, 136);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(126, 32);
            this.usernameLabel.TabIndex = 34;
            this.usernameLabel.Text = "Username:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameLabel.Location = new System.Drawing.Point(36, 53);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(131, 32);
            this.surnameLabel.TabIndex = 33;
            this.surnameLabel.Text = "Last Name:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(33, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(134, 32);
            this.nameLabel.TabIndex = 32;
            this.nameLabel.Text = "First Name:";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthdayLabel.Location = new System.Drawing.Point(12, 95);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(155, 32);
            this.birthdayLabel.TabIndex = 36;
            this.birthdayLabel.Text = "Date of Birth:";
            // 
            // surnameDisplay
            // 
            this.surnameDisplay.AccessibleName = "";
            this.surnameDisplay.Enabled = false;
            this.surnameDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameDisplay.Location = new System.Drawing.Point(173, 53);
            this.surnameDisplay.Name = "surnameDisplay";
            this.surnameDisplay.ReadOnly = true;
            this.surnameDisplay.Size = new System.Drawing.Size(150, 35);
            this.surnameDisplay.TabIndex = 38;
            this.surnameDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameDisplay
            // 
            this.nameDisplay.AccessibleName = "";
            this.nameDisplay.Enabled = false;
            this.nameDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameDisplay.Location = new System.Drawing.Point(173, 12);
            this.nameDisplay.Name = "nameDisplay";
            this.nameDisplay.ReadOnly = true;
            this.nameDisplay.Size = new System.Drawing.Size(150, 35);
            this.nameDisplay.TabIndex = 37;
            this.nameDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.AccessibleName = "";
            this.usernameDisplay.Enabled = false;
            this.usernameDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameDisplay.Location = new System.Drawing.Point(173, 135);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.ReadOnly = true;
            this.usernameDisplay.Size = new System.Drawing.Size(150, 35);
            this.usernameDisplay.TabIndex = 40;
            this.usernameDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordDisplay
            // 
            this.passwordDisplay.AccessibleName = "";
            this.passwordDisplay.Enabled = false;
            this.passwordDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordDisplay.Location = new System.Drawing.Point(173, 176);
            this.passwordDisplay.Name = "passwordDisplay";
            this.passwordDisplay.ReadOnly = true;
            this.passwordDisplay.Size = new System.Drawing.Size(150, 35);
            this.passwordDisplay.TabIndex = 41;
            this.passwordDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordDisplay.UseSystemPasswordChar = true;
            // 
            // birthdayDisplay
            // 
            this.birthdayDisplay.AccessibleName = "";
            this.birthdayDisplay.Enabled = false;
            this.birthdayDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthdayDisplay.Location = new System.Drawing.Point(173, 94);
            this.birthdayDisplay.Name = "birthdayDisplay";
            this.birthdayDisplay.ReadOnly = true;
            this.birthdayDisplay.Size = new System.Drawing.Size(150, 35);
            this.birthdayDisplay.TabIndex = 39;
            this.birthdayDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordShow
            // 
            this.passwordShow.AutoSize = true;
            this.passwordShow.Location = new System.Drawing.Point(173, 217);
            this.passwordShow.Name = "passwordShow";
            this.passwordShow.Size = new System.Drawing.Size(108, 19);
            this.passwordShow.TabIndex = 42;
            this.passwordShow.Text = "Show Password";
            this.passwordShow.UseVisualStyleBackColor = true;
            this.passwordShow.CheckedChanged += new System.EventHandler(this.passwordShow_CheckedChanged);
            // 
            // avatarLabel1
            // 
            this.avatarLabel1.AutoSize = true;
            this.avatarLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avatarLabel1.Location = new System.Drawing.Point(384, 11);
            this.avatarLabel1.Name = "avatarLabel1";
            this.avatarLabel1.Size = new System.Drawing.Size(162, 32);
            this.avatarLabel1.TabIndex = 45;
            this.avatarLabel1.Text = "Profile Picture";
            // 
            // avatarBox
            // 
            this.avatarBox.BackColor = System.Drawing.SystemColors.Control;
            this.avatarBox.ImageLocation = "";
            this.avatarBox.Location = new System.Drawing.Point(400, 53);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(128, 128);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox.TabIndex = 43;
            this.avatarBox.TabStop = false;
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(427, 187);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(75, 23);
            this.imageButton.TabIndex = 44;
            this.imageButton.Text = "Change";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // changePassword
            // 
            this.changePassword.Location = new System.Drawing.Point(173, 242);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(115, 23);
            this.changePassword.TabIndex = 46;
            this.changePassword.Text = "Change Password";
            this.changePassword.UseVisualStyleBackColor = true;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.avatarLabel1);
            this.Controls.Add(this.avatarBox);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.passwordShow);
            this.Controls.Add(this.surnameDisplay);
            this.Controls.Add(this.nameDisplay);
            this.Controls.Add(this.usernameDisplay);
            this.Controls.Add(this.passwordDisplay);
            this.Controls.Add(this.birthdayDisplay);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AccountView";
            this.Text = "AccountView";
            this.Disposed += new System.EventHandler(this.AccountView_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BackButton;
        private Label label1;
        private Label passwordLabel;
        private Label usernameLabel;
        private Label surnameLabel;
        private Label nameLabel;
        private Label birthdayLabel;
        private TextBox surnameDisplay;
        private TextBox nameDisplay;
        private TextBox usernameDisplay;
        private TextBox passwordDisplay;
        private TextBox birthdayDisplay;
        private CheckBox passwordShow;
        private Label avatarLabel1;
        private PictureBox avatarBox;
        private Button imageButton;
        private Button changePassword;
        private OpenFileDialog openFileDialog1;
    }
}