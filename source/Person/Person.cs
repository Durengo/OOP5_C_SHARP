using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP5.source.Person
{
    public class Person
    {
        private string FirstName;
        private string LastName;
        private DateOnly DateOfBirth;
        private int CurrentAge = 0;

        public Person(string name, string surname, DateOnly dateOfBirth)
        {
            FirstName = name;
            LastName = surname;
            DateOfBirth = dateOfBirth;
            CalculateAge();
        }

        private void CalculateAge()
        {
            var day = DateTime.Today.Day - DateOfBirth.Day;
            var month = DateTime.Today.Month - DateOfBirth.Month;
            var year = DateTime.Today.Year - DateOfBirth.Year;
            if (day < 0)
                month--;
            if (month < 0)
                year--;
            CurrentAge = DateTime.Today.Year - year;
        }

        // Getters & Setters
        public string Name
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string Surname
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public DateOnly BirthDate
        {
            get { return DateOfBirth; }
            set { DateOfBirth = value; }
        }
        public int Age
        {
            get
            {
                CalculateAge();
                return CurrentAge;
            }
            private set
            {
                CurrentAge = value;
                CalculateAge();
            }
        }
    }
}
