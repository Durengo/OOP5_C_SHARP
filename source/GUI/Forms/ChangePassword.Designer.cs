namespace OOP5.source.GUI.Forms
{
    partial class ChangePassword
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
            this.changePass = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.currentPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.repeatPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.err1 = new System.Windows.Forms.PictureBox();
            this.err2 = new System.Windows.Forms.PictureBox();
            this.err3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err3)).BeginInit();
            this.SuspendLayout();
            // 
            // changePass
            // 
            this.changePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changePass.Location = new System.Drawing.Point(41, 126);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(75, 23);
            this.changePass.TabIndex = 0;
            this.changePass.Text = "Confirm";
            this.changePass.UseVisualStyleBackColor = true;
            this.changePass.Click += new System.EventHandler(this.changePass_Click);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back.Location = new System.Drawing.Point(164, 126);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // currentPass
            // 
            this.currentPass.Location = new System.Drawing.Point(113, 24);
            this.currentPass.Name = "currentPass";
            this.currentPass.Size = new System.Drawing.Size(159, 23);
            this.currentPass.TabIndex = 2;
            // 
            // newPass
            // 
            this.newPass.Location = new System.Drawing.Point(113, 53);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(159, 23);
            this.newPass.TabIndex = 3;
            // 
            // repeatPass
            // 
            this.repeatPass.Location = new System.Drawing.Point(113, 82);
            this.repeatPass.Name = "repeatPass";
            this.repeatPass.Size = new System.Drawing.Size(159, 23);
            this.repeatPass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Repeat Password:";
            // 
            // err1
            // 
            this.err1.BackColor = System.Drawing.Color.Red;
            this.err1.Location = new System.Drawing.Point(257, 24);
            this.err1.Name = "err1";
            this.err1.Size = new System.Drawing.Size(15, 15);
            this.err1.TabIndex = 41;
            this.err1.TabStop = false;
            this.err1.Click += new System.EventHandler(this.err1_Click);
            // 
            // err2
            // 
            this.err2.BackColor = System.Drawing.Color.Red;
            this.err2.Location = new System.Drawing.Point(257, 53);
            this.err2.Name = "err2";
            this.err2.Size = new System.Drawing.Size(15, 15);
            this.err2.TabIndex = 42;
            this.err2.TabStop = false;
            this.err2.Click += new System.EventHandler(this.err2_Click);
            // 
            // err3
            // 
            this.err3.BackColor = System.Drawing.Color.Red;
            this.err3.Location = new System.Drawing.Point(257, 82);
            this.err3.Name = "err3";
            this.err3.Size = new System.Drawing.Size(15, 15);
            this.err3.TabIndex = 43;
            this.err3.TabStop = false;
            this.err3.Click += new System.EventHandler(this.err3_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.err3);
            this.Controls.Add(this.err2);
            this.Controls.Add(this.err1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repeatPass);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.currentPass);
            this.Controls.Add(this.back);
            this.Controls.Add(this.changePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button changePass;
        private Button back;
        private TextBox currentPass;
        private TextBox newPass;
        private TextBox repeatPass;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox err1;
        private PictureBox err2;
        private PictureBox err3;
    }
}