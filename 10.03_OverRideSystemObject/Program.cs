using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._03_OverRideSystemObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ferda", "Mravenec");

            Console.WriteLine(employee.ToString());
            employee.
        }

        class Employee override : object
        {
            public string FirstName;
        public string LastName;

        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
    }
}
