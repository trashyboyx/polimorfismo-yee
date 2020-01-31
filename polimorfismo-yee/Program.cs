using polimorfismo_yee.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace polimorfismo_yee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listOfEmployees = new List<Employee>(); 

            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfEmployees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additional));
                }
                else
                {
                    listOfEmployees.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            listOfEmployees.ForEach(employee =>
            {
                Console.WriteLine(employee.Name + " - $" + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            });
        }
    }
}
