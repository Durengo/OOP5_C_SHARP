using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP5.source.GUI.Forms
{
    using source.Core;

    public partial class WriteComment : Form
    {
        public WriteComment()
        {
            InitializeComponent();
            ConfirmButton.Enabled = false;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            var Form = (ProductView)SessionManager.Instance.openForms[7];
            SessionManager.Instance.DatabaseInstance.CommentsDB.AddCommentItem(
                SessionManager.Instance.currentUser.Username,
                Form.Item.Type,
                Form.Item.Model,
                commentBox.Text,
                DateTime.Now
            );
            this.Dispose();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //this.Dispose();
        }

        private void err1_Click(object sender, EventArgs e)
        {
            PopUpError popup = new PopUpError("The password does not match the current password.");
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }

        private void err2_Click(object sender, EventArgs e)
        {
            PopUpError popup = new PopUpError("Some undefined error here.");
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }

        private void err3_Click(object sender, EventArgs e)
        {
            PopUpError popup = new PopUpError(
                "This password must be the same as the previous password."
            );
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }

        private void commentBox_TextChanged(object sender, EventArgs e)
        {
            if(commentBox.Text != "")
            {
                ConfirmButton.Enabled = true;
            }
        }
    }
}
