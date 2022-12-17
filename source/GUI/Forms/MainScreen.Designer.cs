namespace OOP5.source.GUI.Forms
{
    partial class MainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton1 = new System.Windows.Forms.Button();
            this.exitButton1 = new System.Windows.Forms.Button();
            this.shopButton1 = new System.Windows.Forms.Button();
            this.registerButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to PC E-Shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // loginButton1
            // 
            this.loginButton1.AutoSize = true;
            this.loginButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginButton1.Location = new System.Drawing.Point(0, 420);
            this.loginButton1.Name = "loginButton1";
            this.loginButton1.Size = new System.Drawing.Size(784, 47);
            this.loginButton1.TabIndex = 1;
            this.loginButton1.Text = "Log In";
            this.loginButton1.UseVisualStyleBackColor = true;
            this.loginButton1.Click += new System.EventHandler(this.loginButton1_Click);
            // 
            // exitButton1
            // 
            this.exitButton1.AutoSize = true;
            this.exitButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton1.Location = new System.Drawing.Point(0, 514);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(784, 47);
            this.exitButton1.TabIndex = 3;
            this.exitButton1.Text = "Exit";
            this.exitButton1.UseVisualStyleBackColor = true;
            this.exitButton1.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // shopButton1
            // 
            this.shopButton1.AutoSize = true;
            this.shopButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shopButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shopButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shopButton1.Location = new System.Drawing.Point(0, 373);
            this.shopButton1.Name = "shopButton1";
            this.shopButton1.Size = new System.Drawing.Size(784, 47);
            this.shopButton1.TabIndex = 4;
            this.shopButton1.Text = "Open Shop";
            this.shopButton1.UseVisualStyleBackColor = true;
            this.shopButton1.Click += new System.EventHandler(this.shopButton1_Click);
            // 
            // registerButton1
            // 
            this.registerButton1.AutoSize = true;
            this.registerButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.registerButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton1.Location = new System.Drawing.Point(0, 467);
            this.registerButton1.Name = "registerButton1";
            this.registerButton1.Size = new System.Drawing.Size(784, 47);
            this.registerButton1.TabIndex = 5;
            this.registerButton1.Text = "Register";
            this.registerButton1.UseVisualStyleBackColor = true;
            this.registerButton1.Click += new System.EventHandler(this.registerButton1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.shopButton1);
            this.Controls.Add(this.loginButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton1);
            this.Controls.Add(this.exitButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Disposed += new System.EventHandler(this.MainScreen_Closing);

        }

        #endregion

        private Label label1;
        private Button loginButton1;
        private Button exitButton1;
        private Button shopButton1;
        private Button registerButton1;
    }
}