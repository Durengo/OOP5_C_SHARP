using OOP5.source.Core;
using OOP5.source.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Database
{
    using OOP5.source.Core;
    using OOP5.source.User;

    public class UserDatabase
    {
        public int UserCount = 0;
        public void Generate()
        {
            if (!SessionManager.Instance.SessionConfiguration.DatabaseFound)
            {
                GenerateUsersTable();
                GenerateUsers();
            }

            // Debug:
            // AddUser("seb", "ter", "data/images/avatar1.png", "Sebastian", "Termen", new DateOnly(2000, 03, 23));
            // RemoverUser("seb");
            // ModifyUserValue("test", "Username = 'test2'");
        }
        public void AddUser(string username, string password, string userImage, string name, string surname, DateOnly birthday)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.InsertItem(
                "Users",
                "UserType, Username, Password, UserImage, Name, Surname, DateOfBirth",
                "'Registered', '" +
                username + "', '" +
                password + "', '" +
                Base64.ConvertAndGetImageAsString(userImage) +
                "', '" + name +
                "', '" + surname +
                "', '" + birthday.ToString() + "'");
            UpdateUserCount();
        }
        public void AddUser(string username, string password, string name, string surname, DateOnly birthday)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.InsertItem(
                "Users",
                "UserType, Username, Password, UserImage, Name, Surname, DateOfBirth",
                "'Registered', '" +
                username + "', '" +
                password + "', '" +
                "'NULL'" +
                "', '" + name +
                "', '" + surname +
                "', '" + birthday.ToString() + "'");
            UpdateUserCount();
        }
        public void RemoverUser(string username)
        {
            // TODO: REMOVE OTHER RECORDS THAT BELONG TO THIS USER!
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.DeleteWhere("Wishlist", "Username", username);
            db.DeleteWhere("Users", "Username", username);
            UpdateUserCount();
        }
        public void ModifyUserValue(string username, string values)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.UpdateItem("Users", values, "Username = '" + username + "'");
        }
        public User SelectUser(string username)
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            List<string> item = db.SelectItem("Users", "UserType, Username, Password, UserImage, Name, Surname, DateOfBirth", "Username = '" + username + "'");
            var date = DateTime.Parse(item[6]);
            User selected;
            if (item[3] == "NULL")
            {
                if (item[0] == "Registered")
                {
                    selected = new Registered(item[1], item[2], item[4], item[5], new DateOnly(date.Year, date.Month, date.Day));
                }
                else
                {
                    selected = new Administrator(item[1], item[2], item[4], item[5], new DateOnly(date.Year, date.Month, date.Day));
                }
            }
            else
            {
                if (item[0] == "Registered")
                {
                    selected = new Registered(item[1], item[2], new Bitmap(Base64.Base64ToImage(item[3])), item[4], item[5], new DateOnly(date.Year, date.Month, date.Day));
                }
                else
                {
                    selected = new Administrator(item[1], item[2], new Bitmap(Base64.Base64ToImage(item[3])), item[4], item[5], new DateOnly(date.Year, date.Month, date.Day));
                }
            }
            return selected;
        }
        public void UpdateUserCount()
        {
            UserCount = SessionManager.Instance.DatabaseInstance.ShopDatabase.Count("Users");
        }
        private void GenerateUsersTable()
        {
            SessionManager.Instance.DatabaseInstance.ShopDatabase.CreateTable("Users",
                @"UserType TYPE,
                Username TEXT,
                Password TEXT,
                UserImage TEXT,
                Name TEXT,
                Surname TEXT,
                DateOfBirth DATE");
        }
        private void GenerateUsers()
        {
            var db = SessionManager.Instance.DatabaseInstance.ShopDatabase;
            db.InsertItem(
                "Users", "UserType, Username, Password, UserImage, Name, Surname, DateOfBirth",
                "'Registered', 'Dur', 'Dur', '" +
                Base64.ConvertAndGetImageAsString("data/images/avatar1.png") +
                "', 'Seb', 'Ter', '2000-03-23'");
            db.InsertItem(
                "Users", "UserType, Username, Password, UserImage, Name, Surname, DateOfBirth",
                "'Registered', 'test', 'test', '" +
                Base64.ConvertAndGetImageAsString("data/images/avatar2.jpg") +
                "', 'Testname', 'Testsurname', '2000-03-23'");

            string dt = new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day).ToString();
            db.InsertItem(
                "Users", "UserType, Username, Password, UserImage, Name, Surname, DateOfBirth",
                "'Administrator', 'admin', 'admin', '" +
                Base64.ConvertAndGetImageAsString("data/images/avatar3.jpg") + "', 'Admin', 'Admin', '"
                + dt + "'");
        }
    }
}
