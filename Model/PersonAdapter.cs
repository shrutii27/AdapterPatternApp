using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Model
{
    //adapts the existing person class
    internal class PersonAdapter : IPersonInfo
    {
        private Person person;
        public PersonAdapter(string firstName, string lastName)
        {
            person = new Person { FirstName = firstName, LastName = lastName };
        }

        public string GetFirstName()
        {
            return person.FirstName;
        }
        public string GetLastName()
        {
            return person.LastName;
        }
         public void PrintFullName()
        {
            person.DisplayFullName();
        }
    } 
}

