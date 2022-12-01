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
    using OOP5.source.Core;

    public partial class CreateProduct : Form
    {
        private string ImageFullPath = "";
        private bool[] InternalConditions = new bool[6];
        private bool[] DBconditions = new bool[2];
        public CreateProduct()
        {
            InitializeComponent();
        }
        public void UpdateData()
        {
            ImageFullPath = "";

            InternalConditions[0] = false;
            InternalConditions[1] = false;
            InternalConditions[2] = false;
            InternalConditions[3] = false;
            InternalConditions[4] = false;
            InternalConditions[5] = false;
            DBconditions[0] = false;
            DBconditions[1] = false;

            CategoryBox.ResetText();
            CategoryBox.Items.Clear();
            ErrBox1.Hide();

            SerialModelBox.Text = "";
            ErrBox2.Hide();

            ProductNameBox.Text = "";
            ErrBox3.Hide();

            ProductDescriptionBox.Text = "";
            ErrBox4.Hide();

            ProductPriceBox.Text = "";
            ErrBox5.Hide();

            PictureBox.Image = null;
            ErrBox6.Hide();

            for (int i = 0; i < SessionManager.Instance.DatabaseInstance.ProductTables.Count(); i++)
            {
                CategoryBox.Items.Add(SessionManager.Instance.DatabaseInstance.ProductTables[i]);
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[10].Hide();
            //ErrMsg.Hide();
            SessionManager.Instance.openForms[4].Show();
        }
        private void CreateProduct_Closing(object sender, EventArgs e)
        {
            for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            {
                SessionManager.Instance.openForms[SessionManager.Instance.openForms.Count - 1 - i].Close();
            }
        }

        private void UploadPictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "image files |*.png;*.jpg;*.jpeg;*.bmp";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;
                PictureBox.ImageLocation = selectedFile;
                ImageFullPath = selectedFile;
            }
        }

        private bool ErrorCheck()
        {
            // Category Box 0
            if (CategoryBox.SelectedIndex == -1)
            {
                InternalConditions[0] = true;
                ErrBox1.Show();
            }
            // Serial Model 1
            if (SerialModelBox.Text == "")
            {
                InternalConditions[1] = true;
                ErrBox2.Show();
            }
            if (!InternalConditions[1])
            {
                while (DBconditions[0] == false)
                {
                    for (int i = 0; i < SessionManager.Instance.DatabaseInstance.ProductTables.Count(); i++)
                    {
                        var list = SessionManager.Instance.DatabaseInstance.ShopDatabase.SelectAllOneValue(SessionManager.Instance.DatabaseInstance.ProductTables[i], "SerialModel");
                        for (int j = 0; j < list.Count(); j++)
                        {
                            if (list.Contains(SerialModelBox.Text))
                            {
                                DBconditions[0] = true;
                                ErrBox2.Show();
                            }
                        }
                    }
                    break;
                }
            }
            // Product Name 2
            if (ProductNameBox.Text == "")
            {
                InternalConditions[2] = true;
                ErrBox3.Show();
            }
            // Description 3
            if (ProductDescriptionBox.Text == "")
            {
                InternalConditions[3] = true;
                ErrBox4.Show();
            }
            // Price 4
            if (ProductPriceBox.Text == "")
            {
                InternalConditions[4] = true;
                ErrBox5.Show();
            }
            if (!InternalConditions[4])
            {
                try
                {
                    float.Parse(ProductPriceBox.Text);
                }
                catch
                {
                    DBconditions[1] = true;
                    ErrBox5.Show();
                }
            }
            // Picture 5
            if (ImageFullPath == "")
            {
                InternalConditions[5] = true;
                ErrBox6.Show();
            }

            if (InternalConditions[0] || InternalConditions[1] ||
                InternalConditions[2] || InternalConditions[3] ||
                InternalConditions[4] || InternalConditions[5] ||
                DBconditions[0] || DBconditions[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            InternalConditions[0] = false;
            InternalConditions[1] = false;
            InternalConditions[2] = false;
            InternalConditions[3] = false;
            InternalConditions[4] = false;
            InternalConditions[5] = false;
            DBconditions[0] = false;
            DBconditions[1] = false;
            ErrBox1.Hide();
            ErrBox2.Hide();
            ErrBox3.Hide();
            ErrBox4.Hide();
            ErrBox5.Hide();
            ErrBox6.Hide();
            if (!ErrorCheck())
            {
                SessionManager.Instance.DatabaseInstance.ProductDB.AddProduct(CategoryBox.Text, SerialModelBox.Text, ProductNameBox.Text,
                            ProductDescriptionBox.Text, float.Parse(ProductPriceBox.Text), ImageFullPath);
                MessageBox.Show("Created New Product And Added To Database!");
                UpdateData();
            }
        }

        private void ErrBox1_Click(object sender, EventArgs e)
        {
            if (InternalConditions[0])
            {
                PopUpError popup = new PopUpError("Must Select A Category!");
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
        }

        private void ErrBox2_Click(object sender, EventArgs e)
        {
            if (InternalConditions[1])
            {
                PopUpError popup = new PopUpError("Serial Model Field Cannot Be Empty!");
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
            else if (DBconditions[0])
            {
                PopUpError popup = new PopUpError("Serial Model Already Exists In Database!");
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
        }

        private void ErrBox3_Click(object sender, EventArgs e)
        {
            if (InternalConditions[2])
            {
                PopUpError popup = new PopUpError("Product Name Field Cannot Be Empty!");
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
        }

        private void ErrBox4_Click(object sender, EventArgs e)
        {
            if (InternalConditions[3])
            {
                PopUpError popup = new PopUpError("Description Field Cannot Be Empty!");
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
        }

        private void ErrBox5_Click(object sender, EventArgs e)
        {
            if (InternalConditions[4])
            {
                PopUpError popup = new PopUpError("Price Field Cannot Be Empty!");
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
            else if (DBconditions[1])
            {
                PopUpError popup = new PopUpError("Price Field Cannot Be Converted To A Number!");
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
        }

        private void ErrBox6_Click(object sender, EventArgs e)
        {
            if (InternalConditions[4])
            {
                PopUpError popup = new PopUpError("Must Provide An Image!");
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
        }
    }
}
