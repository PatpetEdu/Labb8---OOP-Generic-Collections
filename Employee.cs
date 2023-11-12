using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8___OOP_Generic_Collections
{
    public class Employee
    {
        //properties for emloyees
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }  
        public virtual void PrintInfo() //Print Method for our employees based on the properties in Employee
        {
            Console.WriteLine($"Id: {Id} " +
                $"\nName: {Name}" +
                $"\nGender: {Gender}" +
                $"\nSalary: {Salary}");
            
        }

    }
}
