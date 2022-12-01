using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: ADD CFG.

namespace OOP5.source.Core
{
    using OOP5.source.Log;
    using OOP5.source.Person;
    using OOP5.source.User;
    using OOP5.source.Database;
    using OOP5.source.Shop;
    using OOP5.source.Core;

    class SessionManager
    {
        private static SessionManager instance = null;
        private static readonly object padlock = new object();
        // Form Instances
        public List<Form> openForms = new List<Form>();
        // Configuration File
        public Config SessionConfiguration = new Config();
        // Database Manager Instance
        public DatabaseManager DatabaseInstance = new DatabaseManager();
        //public List<User> users = new List<User>();
        // Currently Logged In User
        public User currentUser = null;
        // private int UserId = -1;

        private SessionManager()
        {
        }

        public bool Login(string name, string pass)
        {
            if (DatabaseInstance.ShopDatabase.CountWhereTimes("Users", "Username = '" + name + "'", 1) != 1)
            {
                return false;
            }
            List<string> item = DatabaseInstance.ShopDatabase.SelectItem("Users", "Username, Password, UserType", "Username = '" + name + "'");
            if (name == item[0])
            {
                if (name == item[0] && pass == item[1] && User.StringToAccountType(item[2]) != AccountType.ANONYMOUS)
                {
                    currentUser = DatabaseInstance.UserDB.SelectUser(name);
                    //UserId = Int32.Parse(item[0]);
                    return true;
                }
            }
            return false;

            // for (int i = 0; i < users.Count; i++)
            // {
            //     if (
            //         name == users[i].Username
            //         && pass == users[i].Password
            //         && users[i].UserAccountType != AccountType.ANONYMOUS
            //     )
            //     {
            //         currentUser = users[i];
            //         UserId = i;
            //         return true;
            //     }
            // }
            // return false;
        }
        public bool CreateUser(
            string username,
            string password,
            string imagePath,
            string name,
            string surname,
            DateOnly birthday
        )
        {
            if (DatabaseInstance.ShopDatabase.CountWhereTimes("Users", "Username = '" + username + "'", 1) != 0)
            {
                return false;
            }
            if (imagePath == "")
            {
                DatabaseInstance.UserDB.AddUser(username, password, name, surname, birthday);
            }
            else
            {
                DatabaseInstance.UserDB.AddUser(username, password, imagePath, name, surname, birthday);
            }
            //UpdateUsers();
            return true;

            // for (int i = 0; i < users.Count; i++)
            // {
            //     if (users[i].Username == username)
            //     {
            //         return false;
            //     }
            // }
            // if(imagePath == "")
            // {
            // SessionManager.Instance.users.Add(
            //     new Registered(username, password, name, surname, birthday)
            // );
            // }
            // else{
            // SessionManager.Instance.users.Add(
            //     new Registered(username, password, imagePath, name, surname, birthday)
            // );
            // }
            // return true;
        }

        // public void UpdateUsers()
        // {

        // }
        public void UpdateCurrentUser()
        {
            currentUser = DatabaseInstance.UserDB.SelectUser(currentUser.Username);

        }

        public void Logout()
        {
            currentUser = null;
        }

        public bool isInstance()
        {
            if (instance == null)
                return false;
            return true;
        }

        public static SessionManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SessionManager();
                    }
                    return instance;
                }
            }
        }
    }
}
