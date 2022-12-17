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

    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            //0
            SessionManager.Instance.openForms.Add(this);
            //1
            SessionManager.Instance.openForms.Add(new Login());
            //2
            SessionManager.Instance.openForms.Add(new Register());
            //3
            SessionManager.Instance.openForms.Add(new AccountView());
            //4
            SessionManager.Instance.openForms.Add(new PostLogin());
            //5
            SessionManager.Instance.openForms.Add(new RemoveUsers());
            //6
            SessionManager.Instance.openForms.Add(new Store());
            //7
            SessionManager.Instance.openForms.Add(new ProductView());
            //8
            SessionManager.Instance.openForms.Add(new Wishlist());
            //9
            SessionManager.Instance.openForms.Add(new CreateCategory());
            //10
            SessionManager.Instance.openForms.Add(new CreateProduct());
            //11
            SessionManager.Instance.openForms.Add(new RemoveProduct());
            //12
            SessionManager.Instance.openForms.Add(new ShoppingHistory());
            //13
            SessionManager.Instance.openForms.Add(new ShoppingCart());
            //14
            // SessionManager.Instance.openForms.Add(new DebugMenu());
            // SessionManager.Instance.openForms[14].Show();

            SessionManager.Instance.DatabaseInstance.Generate();

            //var Form = (ShoppingCart)SessionManager.Instance.openForms[13];
            //Form.ReloadData();
            //SessionManager.Instance.openForms[13].Show();
        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[0].Hide();
            SessionManager.Instance.openForms[1].Show();
        }

        private void registerButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[0].Hide();
            SessionManager.Instance.openForms[2].Show();
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.Shutdown();
        }

        private void shopButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[0].Hide();
            var Form = (Store)SessionManager.Instance.openForms[6];
            Form.ReloadData();
            SessionManager.Instance.openForms[6].Show();
        }

        private void MainScreen_Closing(object sender, EventArgs e)
        {
            SessionManager.Instance.Shutdown();
        }
    }
}
