using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Model
{
    internal class Intern : Employee
    {
        public string MentorName;

        public override double CalculateSalary()
        {
            Salary = 15000;

            return Salary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Name: " +  Name);
            Console.WriteLine("MentorName: " + MentorName);
            Console.WriteLine("Salary: " + Salary);
        }
    }
}
