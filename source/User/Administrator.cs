using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.User
{
    class Administrator : User
    {
        public Administrator(
            string username,
            string password,
            string avatar,
            string name,
            string surname,
            DateOnly birthday
        ) : base(username, password, avatar, name, surname, birthday)
        {
            this.SetUserAccountType = AccountType.ADMINISTRATOR;
        }
        public Administrator(
            string username,
            string password,
            string name,
            string surname,
            DateOnly birthday
        ) : base(username, password, name, surname, birthday)
        {
            this.SetUserAccountType = AccountType.ADMINISTRATOR;
        }
        public Administrator(
            string username,
            string password,
            Bitmap avatar,
            string name,
            string surname,
            DateOnly birthday
        ) : base(username, password, avatar, name, surname, birthday)
        {
            this.SetUserAccountType = AccountType.ADMINISTRATOR;
        }
    }
}
