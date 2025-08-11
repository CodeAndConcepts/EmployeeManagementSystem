using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Model
{
    internal class Developer : Employee
    {

        public string ProgrammingLanguage;

        public override double CalculateSalary()
        {
            Salary += GetBonusOnProgrammingLanguage();
            return Salary;
        }

        private double GetBonusOnProgrammingLanguage()
        {
            double bonusSalary = 0.0;

            switch (ProgrammingLanguage)
            {
                case "C#":
                    bonusSalary = 2000;
                    break;
                case "C++":
                    bonusSalary = 1000;
                    break;
                default: break;
            }

            return bonusSalary;
        }

        public override void DisplayInfo() 
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Language: " + ProgrammingLanguage);
            Console.WriteLine("Salary: " + Salary);
        }
    }
}
