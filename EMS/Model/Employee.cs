using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Model
{
    abstract class Employee
    {
        public int ID;

        public string Name;

        public string Department;

        public double Salary;

        protected Employee()
        {
            Salary = 80000;
        }
        public abstract double CalculateSalary();

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Employee List:");
        }
    }
}
