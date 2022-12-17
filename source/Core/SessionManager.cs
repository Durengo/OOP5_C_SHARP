using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: ADD CFG.

namespace OOP5.source.Core
{
    using OOP5.source.Log;
    using OOP5.source.User;
    using OOP5.source.Database;

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

        // Currently Logged In User
        public User currentUser = null;

        // private int UserId = -1;
        public Logger ClientHistory = null;
        private bool ClientLogClosed = false;
        public bool BirthdayDiscount = false;

        private SessionManager()
        {
            ClientHistory = new Logger(new SimpleTextFileLog("ClientHistory.txt"));
            ClientHistory.Log("CLIENT INITIALIZED");
        }

        ~SessionManager()
        {
            Shutdown();
        }

        public bool Login(string name, string pass)
        {
            if (
                DatabaseInstance.ShopDatabase.CountWhereTimes(
                    "Users",
                    "Username = '" + name + "'",
                    1
                ) != 1
            )
            {
                return false;
            }
            List<string> item = DatabaseInstance.ShopDatabase.SelectItem(
                "Users",
                "Username, Password, UserType",
                "Username = '" + name + "'"
            );
            if (name == item[0])
            {
                if (
                    name == item[0]
                    && pass == item[1]
                    && User.StringToAccountType(item[2]) != AccountType.ANONYMOUS
                )
                {
                    currentUser = DatabaseInstance.UserDB.SelectUser(name);
                    CheckForBirthdayDiscount();
                    ClientHistory.Log(
                        "CLIENT LOGGED IN AS "
                            + name
                            + " | ACCOUNT TYPE = "
                            + currentUser.UserAccountType
                    );
                    return true;
                }
            }
            return false;
        }

        private void CheckForBirthdayDiscount()
        {
            var date = new DateOnly(
                DateTime.Now.Year,
                currentUser.BirthDate.Month,
                currentUser.BirthDate.Day
            );
            var d1 = new DateOnly(date.Year, date.Month, date.Day - 7);
            var d2 = new DateOnly(date.Year, date.Month, date.Day + 7);
            var nowDate = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (nowDate >= d1 && nowDate <= d2)
            {
                BirthdayDiscount = true;
            }
            else
            {
                BirthdayDiscount = false;
            }
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
            if (
                DatabaseInstance.ShopDatabase.CountWhereTimes(
                    "Users",
                    "Username = '" + username + "'",
                    1
                ) != 0
            )
            {
                return false;
            }
            if (imagePath == "")
            {
                DatabaseInstance.UserDB.AddUser(username, password, name, surname, birthday);
            }
            else
            {
                DatabaseInstance.UserDB.AddUser(
                    username,
                    password,
                    imagePath,
                    name,
                    surname,
                    birthday
                );
            }
            return true;
        }

        public void Shutdown()
        {
            if (!ClientLogClosed)
            {
                ClientHistory.Log("CLIENT TERMINATED APPLICATION");
                ClientLogClosed = true;
            }
            for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            {
                SessionManager.Instance.openForms[
                    SessionManager.Instance.openForms.Count - 1 - i
                ].Close();
            }
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
            Application.Exit();
            Environment.Exit(0);
        }

        public void UpdateCurrentUser()
        {
            currentUser = DatabaseInstance.UserDB.SelectUser(currentUser.Username);
        }

        public void Logout()
        {
            ClientHistory.Log("USER " + currentUser.Username + " LOGGED OUT");
            BirthdayDiscount = false;
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
