using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BirthdayNotifierWPF
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - Birthday.Year;

                if (today < Birthday.AddYears(age))
                    age--;
                return age;
            }
        }
        public int DaysRemaining
        {
            get
            {
                DateTime nextBirthday = Birthday.AddYears(Age + 1);

                TimeSpan timeSpan = nextBirthday - DateTime.Today;

                return Convert.ToInt32(timeSpan.TotalDays);
            }
        }
        public Person(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
