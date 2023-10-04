using AdapterPatternApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an adapter
            IPersonInfo personAdapter = new PersonAdapter("Shruti", "Amrutkar");

            //use adapted interface
            Console.WriteLine($"First Name: {personAdapter.GetFirstName()}");
            Console.WriteLine($"Last Name: {personAdapter.GetLastName()}");
            Console.WriteLine("Full Name: ");
            personAdapter.PrintFullName();
        }
    }
}
