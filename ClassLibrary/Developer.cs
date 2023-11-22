using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Developer : Employee
    {
        int linesOfCodePerDay;

        public Developer(string name, int age, double salary, int linesOfCodePerDay) : base(name, age, salary)
        {
            this.linesOfCodePerDay = linesOfCodePerDay;
        }

        public override double CalculateAnnualSalary()
        {
            double additionalIncomePerLineOfCode = 10; // Количество дополнительного дохода за каждую строку кода

            double baseAnnualSalary = base.CalculateAnnualSalary();
            double additionalIncome = linesOfCodePerDay * additionalIncomePerLineOfCode * 365; // Расчет дополнительного дохода за год

            return baseAnnualSalary + additionalIncome; // Годовая зарплата с учетом дополнительного дохода за строки кода
        }
    }
}
