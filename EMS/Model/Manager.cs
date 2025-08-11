using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Model
{
    internal class Manager : Employee
    {
        public int TeamSize;

        public override double CalculateSalary()
        {
            Salary += GetSalaryOnTeamSize();
            return Salary;
        }

        private double GetSalaryOnTeamSize()
        {
            double bonusSalary = 0.0;

            if (TeamSize < 10)
            {
                bonusSalary = 15000;
            }
            else if (TeamSize < 20)
            {
                bonusSalary = 20000;
            }

            return bonusSalary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("TeamSize: " + TeamSize);
            Console.WriteLine("Salary: " + Salary);
        }
    }
}
