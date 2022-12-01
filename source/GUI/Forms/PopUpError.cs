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
    public partial class PopUpError : Form
    {
        public PopUpError(string text)
        {
            InitializeComponent();
            errText.Text = text;
        }

        private void errText_Click(object sender, EventArgs e) { }

        private void okButton_Click(object sender, EventArgs e) { }
    }
}
