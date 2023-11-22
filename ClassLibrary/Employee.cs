using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Employee
    {
        string name;
        int age;
        double salary;

        public Employee(string name, int age, double salary) //Конструктор для инициализации полей
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void GetInfo() //Вывод информации о сотруднике
        {
            Console.WriteLine($"Имя работника: {name}, Возраст: {age}, Заработная плата работника: {salary}");
        }

        public virtual double CalculateAnnualSalary() //Годовая зарплата
        {
            return salary * 12;
        }
    }
}
