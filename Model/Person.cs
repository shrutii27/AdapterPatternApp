using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Model
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void DisplayFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
