using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Manager : Employee
    {
        double bonus;

        public Manager(string name, int age, double salary, double bonus) : base(name, age, salary)
        {
            this.bonus = bonus;
        }

        
        public override double CalculateAnnualSalary() // Переопределение метода CalculateAnnualSalary() для менеджера
        {
            double annualSalaryWithoutBonus = base.CalculateAnnualSalary(); 
            return annualSalaryWithoutBonus + bonus; // Возвращаем годовую зарплату с учетом бонуса
        }
    }
}
