using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace dotNET_module_9_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Иван", 25, 300000, 1000000);

            Developer developer = new Developer("Андрей", 28, 400000, 200);

            Console.WriteLine("Информация о менеджере:");
            manager.GetInfo();

            double managerAnnualSalary = manager.CalculateAnnualSalary(); // Расчет годовой зарплаты для менеджера
            Console.WriteLine($"Годовая зарплата менеджера: {managerAnnualSalary}");


            Console.WriteLine();


            Console.WriteLine("Информация о разработчике:");
            developer.GetInfo();
            double developerAnnualSalary = developer.CalculateAnnualSalary(); // Расчет годовой зарплаты для разработчика
            Console.WriteLine($"Годовая зарплата разработчика: {developerAnnualSalary}");
        }
    }
}
