using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayNotifierWPF
{
    public class PersonsAdministrator
    {
        public ObservableCollection<Person> Persons { get; set; }
        public Person NextPerson { get; set; }
        public DateTime Today
        {
            get
            {
                return DateTime.Now;
            }
        }
        public PersonsAdministrator()
        {
            Persons = new ObservableCollection<Person>();
        }
        private void FindNext()
        {
            var sortedPersons = Persons.OrderBy(o => o.Birthday);
            if (sortedPersons.Any())
                NextPerson = sortedPersons.First();
            else
                NextPerson = null;
        }
    }
}
