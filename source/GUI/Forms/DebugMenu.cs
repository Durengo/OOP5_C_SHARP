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
    using System.Configuration;
    using System.Text.Json;

    public partial class DebugMenu : Form
    {
        public DebugMenu()
        {
            InitializeComponent();
            //SessionManager.Instance.UserDB.Generate();
            var db1 = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            //db1.Generate();
            jsonLabel.Text = SessionManager.Instance.SessionConfiguration.DatabaseFound.ToString();
            //jsonLabel.Text = SessionManager.Instance.SessionConfiguration.excpt;

            ConnectionStatus.Text = db1.ConnectionErr.ToString();
            if (db1.ConnectionState == false)
            {
                ConnectionStatus.Text = db1.ConnectionErr.ToString();
            }
            else
            {
                ConnectionStatus.Text = db1.ConnectionSuc;
                versionLabel.Text = db1.Version;
            }

            ConnectionStatus.Text = db1.ConnectionErr.ToString();
            ConnectionStatus.Text = db1.ConnectionErr.ToString();

            // for (int i = 0; i < SessionManager.Instance.UserCount; i++)
            // {
            //     List<string> items = db1.SelectItem("Users", "ID, UserType, Username, Password, Name, Surname, DateOfBirth", "ID = " + i);
            //     dbUserList.Items.Add(items[0]);
            // }



            //List<string> item = db1.SelectItem("Users", "ID, UserType, Username, Password, Name, Surname, DateOfBirth", "ID = 0");
            //string selected = "";
            //for(int i = 0; i < item.Count; i++)
            //{
            //    selected += item[i].ToString() + ", ";
            //}
            //selection.Text = selected;
        }

        private void DebugMenu_Closing(object sender, EventArgs e)
        {
            SessionManager.Instance.Shutdown();

            // for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            // {
            //     SessionManager.Instance.openForms[SessionManager.Instance.openForms.Count - 1 - i].Close();
            // }
        }

        private void ChangeDBButton1_Click(object sender, EventArgs e)
        {
            var x = SessionManager.Instance.SessionConfiguration.DatabaseFound;
            if (x)
            {
                SessionManager.Instance.SessionConfiguration.ChangeDatabase(false);
            }
            else
            {
                SessionManager.Instance.SessionConfiguration.ChangeDatabase(true);
            }
        }
    }
}
