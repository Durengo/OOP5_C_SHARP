namespace OOP5.source.GUI.Forms
{
    partial class Register
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageButton = new System.Windows.Forms.Button();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.passwordDisplay = new System.Windows.Forms.TextBox();
            this.usernameDisplay = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.dateDisplay = new System.Windows.Forms.TextBox();
            this.surnameDisplay = new System.Windows.Forms.TextBox();
            this.nameDisplay = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.MonthCalendar();
            this.backButton1 = new System.Windows.Forms.Button();
            this.registerButton1 = new System.Windows.Forms.Button();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.avatarLabel1 = new System.Windows.Forms.Label();
            this.nameErr1 = new System.Windows.Forms.PictureBox();
            this.surnameErr1 = new System.Windows.Forms.PictureBox();
            this.dateErr1 = new System.Windows.Forms.PictureBox();
            this.imagePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userCount = new System.Windows.Forms.Label();
            this.usernameErr = new System.Windows.Forms.Label();
            this.usernameSuc1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameErr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateErr1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(561, 192);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(75, 23);
            this.imageButton.TabIndex = 35;
            this.imageButton.Text = "Upload";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // avatarBox
            // 
            this.avatarBox.BackColor = System.Drawing.SystemColors.Control;
            this.avatarBox.ImageLocation = "";
            this.avatarBox.Location = new System.Drawing.Point(534, 58);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(128, 128);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox.TabIndex = 34;
            this.avatarBox.TabStop = false;
            // 
            // passwordDisplay
            // 
            this.passwordDisplay.AccessibleName = "";
            this.passwordDisplay.Enabled = false;
            this.passwordDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordDisplay.Location = new System.Drawing.Point(627, 398);
            this.passwordDisplay.Name = "passwordDisplay";
            this.passwordDisplay.ReadOnly = true;
            this.passwordDisplay.Size = new System.Drawing.Size(150, 35);
            this.passwordDisplay.TabIndex = 33;
            this.passwordDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordDisplay.UseSystemPasswordChar = true;
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.AccessibleName = "";
            this.usernameDisplay.Enabled = false;
            this.usernameDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameDisplay.Location = new System.Drawing.Point(471, 398);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.ReadOnly = true;
            this.usernameDisplay.Size = new System.Drawing.Size(150, 35);
            this.usernameDisplay.TabIndex = 32;
            this.usernameDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(38, 181);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(116, 32);
            this.passwordLabel.TabIndex = 31;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordBox
            // 
            this.passwordBox.AccessibleName = "";
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordBox.Location = new System.Drawing.Point(160, 180);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(134, 35);
            this.passwordBox.TabIndex = 30;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(28, 140);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(126, 32);
            this.usernameLabel.TabIndex = 29;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameBox
            // 
            this.usernameBox.AccessibleName = "";
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameBox.Location = new System.Drawing.Point(160, 139);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(134, 35);
            this.usernameBox.TabIndex = 28;
            // 
            // dateDisplay
            // 
            this.dateDisplay.AccessibleName = "";
            this.dateDisplay.Enabled = false;
            this.dateDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateDisplay.Location = new System.Drawing.Point(315, 398);
            this.dateDisplay.Name = "dateDisplay";
            this.dateDisplay.ReadOnly = true;
            this.dateDisplay.Size = new System.Drawing.Size(150, 35);
            this.dateDisplay.TabIndex = 27;
            this.dateDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // surnameDisplay
            // 
            this.surnameDisplay.AccessibleName = "";
            this.surnameDisplay.Enabled = false;
            this.surnameDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameDisplay.Location = new System.Drawing.Point(159, 398);
            this.surnameDisplay.Name = "surnameDisplay";
            this.surnameDisplay.ReadOnly = true;
            this.surnameDisplay.Size = new System.Drawing.Size(150, 35);
            this.surnameDisplay.TabIndex = 25;
            this.surnameDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameDisplay
            // 
            this.nameDisplay.AccessibleName = "";
            this.nameDisplay.Enabled = false;
            this.nameDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameDisplay.Location = new System.Drawing.Point(3, 398);
            this.nameDisplay.Name = "nameDisplay";
            this.nameDisplay.ReadOnly = true;
            this.nameDisplay.Size = new System.Drawing.Size(150, 35);
            this.nameDisplay.TabIndex = 24;
            this.nameDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameDisplay.TextChanged += new System.EventHandler(this.nameDisplay_TextChanged);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameLabel.Location = new System.Drawing.Point(23, 99);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(131, 32);
            this.surnameLabel.TabIndex = 22;
            this.surnameLabel.Text = "Last Name:";
            // 
            // surnameBox
            // 
            this.surnameBox.AccessibleName = "";
            this.surnameBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameBox.Location = new System.Drawing.Point(160, 98);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(134, 35);
            this.surnameBox.TabIndex = 21;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(20, 58);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(134, 32);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "First Name:";
            // 
            // nameBox
            // 
            this.nameBox.AccessibleName = "";
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(160, 57);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(134, 35);
            this.nameBox.TabIndex = 19;
            // 
            // datePicker
            // 
            this.datePicker.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.datePicker.Location = new System.Drawing.Point(315, 57);
            this.datePicker.MaxSelectionCount = 1;
            this.datePicker.Name = "datePicker";
            this.datePicker.TabIndex = 18;
            // 
            // backButton1
            // 
            this.backButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton1.Location = new System.Drawing.Point(0, 500);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(784, 61);
            this.backButton1.TabIndex = 36;
            this.backButton1.Text = "Back";
            this.backButton1.UseVisualStyleBackColor = true;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // registerButton1
            // 
            this.registerButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.registerButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton1.Location = new System.Drawing.Point(0, 439);
            this.registerButton1.Name = "registerButton1";
            this.registerButton1.Size = new System.Drawing.Size(784, 61);
            this.registerButton1.TabIndex = 37;
            this.registerButton1.Text = "Register";
            this.registerButton1.UseVisualStyleBackColor = true;
            this.registerButton1.Click += new System.EventHandler(this.registerButton1_Click);
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.AutoSize = true;
            this.birthdayLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthdayLabel1.Location = new System.Drawing.Point(330, 16);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(150, 32);
            this.birthdayLabel1.TabIndex = 38;
            this.birthdayLabel1.Text = "Date of Birth";
            // 
            // avatarLabel1
            // 
            this.avatarLabel1.AutoSize = true;
            this.avatarLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avatarLabel1.Location = new System.Drawing.Point(518, 16);
            this.avatarLabel1.Name = "avatarLabel1";
            this.avatarLabel1.Size = new System.Drawing.Size(162, 32);
            this.avatarLabel1.TabIndex = 39;
            this.avatarLabel1.Text = "Profile Picture";
            // 
            // nameErr1
            // 
            this.nameErr1.BackColor = System.Drawing.Color.Red;
            this.nameErr1.Location = new System.Drawing.Point(279, 58);
            this.nameErr1.Name = "nameErr1";
            this.nameErr1.Size = new System.Drawing.Size(15, 15);
            this.nameErr1.TabIndex = 40;
            this.nameErr1.TabStop = false;
            this.nameErr1.Click += new System.EventHandler(this.nameErr1_Click);
            // 
            // surnameErr1
            // 
            this.surnameErr1.BackColor = System.Drawing.Color.Red;
            this.surnameErr1.Location = new System.Drawing.Point(279, 99);
            this.surnameErr1.Name = "surnameErr1";
            this.surnameErr1.Size = new System.Drawing.Size(15, 15);
            this.surnameErr1.TabIndex = 41;
            this.surnameErr1.TabStop = false;
            this.surnameErr1.Click += new System.EventHandler(this.surnameErr1_Click);
            // 
            // dateErr1
            // 
            this.dateErr1.BackColor = System.Drawing.Color.Red;
            this.dateErr1.Location = new System.Drawing.Point(476, 202);
            this.dateErr1.Name = "dateErr1";
            this.dateErr1.Size = new System.Drawing.Size(15, 15);
            this.dateErr1.TabIndex = 42;
            this.dateErr1.TabStop = false;
            this.dateErr1.Click += new System.EventHandler(this.dateErr1_Click);
            // 
            // imagePath
            // 
            this.imagePath.AutoSize = true;
            this.imagePath.Location = new System.Drawing.Point(12, 9);
            this.imagePath.Name = "imagePath";
            this.imagePath.Size = new System.Drawing.Size(67, 15);
            this.imagePath.TabIndex = 43;
            this.imagePath.Text = "image path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "user count:";
            // 
            // userCount
            // 
            this.userCount.AutoSize = true;
            this.userCount.Location = new System.Drawing.Point(734, 9);
            this.userCount.Name = "userCount";
            this.userCount.Size = new System.Drawing.Size(13, 15);
            this.userCount.TabIndex = 45;
            this.userCount.Text = "x";
            // 
            // usernameErr
            // 
            this.usernameErr.AutoSize = true;
            this.usernameErr.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameErr.ForeColor = System.Drawing.Color.Red;
            this.usernameErr.Location = new System.Drawing.Point(237, 363);
            this.usernameErr.Name = "usernameErr";
            this.usernameErr.Size = new System.Drawing.Size(305, 32);
            this.usernameErr.TabIndex = 46;
            this.usernameErr.Text = "USERNAME ALREADY USED";
            this.usernameErr.Visible = false;
            // 
            // usernameSuc1
            // 
            this.usernameSuc1.AutoSize = true;
            this.usernameSuc1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameSuc1.ForeColor = System.Drawing.Color.LimeGreen;
            this.usernameSuc1.Location = new System.Drawing.Point(281, 363);
            this.usernameSuc1.Name = "usernameSuc1";
            this.usernameSuc1.Size = new System.Drawing.Size(212, 32);
            this.usernameSuc1.TabIndex = 47;
            this.usernameSuc1.Text = "USER REGISTERED!";
            this.usernameSuc1.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.usernameSuc1);
            this.Controls.Add(this.usernameErr);
            this.Controls.Add(this.userCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagePath);
            this.Controls.Add(this.dateErr1);
            this.Controls.Add(this.surnameErr1);
            this.Controls.Add(this.nameErr1);
            this.Controls.Add(this.avatarLabel1);
            this.Controls.Add(this.birthdayLabel1);
            this.Controls.Add(this.surnameDisplay);
            this.Controls.Add(this.nameDisplay);
            this.Controls.Add(this.avatarBox);
            this.Controls.Add(this.usernameDisplay);
            this.Controls.Add(this.passwordDisplay);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.dateDisplay);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.registerButton1);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.datePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Register";
            this.Text = "Register";
            this.Disposed += new System.EventHandler(this.Register_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameErr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateErr1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button imageButton;
        private PictureBox avatarBox;
        private TextBox passwordDisplay;
        private TextBox usernameDisplay;
        private Label passwordLabel;
        private TextBox passwordBox;
        private Label usernameLabel;
        private TextBox usernameBox;
        private TextBox dateDisplay;
        private TextBox surnameDisplay;
        private TextBox nameDisplay;
        private Label surnameLabel;
        private TextBox surnameBox;
        private Label nameLabel;
        private TextBox nameBox;
        private MonthCalendar datePicker;
        private Button backButton1;
        private Button registerButton1;
        private Label birthdayLabel1;
        private Label avatarLabel1;
        private PictureBox nameErr1;
        private PictureBox surnameErr1;
        private PictureBox dateErr1;
        private Label imagePath;
        private Label label1;
        private Label userCount;
        private Label usernameErr;
        private Label usernameSuc1;
    }
}