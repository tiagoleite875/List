using exerciciolist;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace exercicio {
    class Program {
        static void Main(string[] args) {

            Console.Write("how many employees will be registred: ");
            int n = int.Parse(Console.ReadLine());

            List<Employees> funcionario = new List<Employees>();

            for ( int i = 1; i <= n; i++) {
                Console.WriteLine("Employees "+ i + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionario.Add(new Employees(id, name, salary));
            }
            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int idcode = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Employees emp = funcionario.Find(x => x.Id == idcode);
            if ( emp != null) {
                emp.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This is doe not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("nova lista: ");
            foreach (Employees obj in funcionario) {
                Console.WriteLine(obj);
            }
        }
    }
}