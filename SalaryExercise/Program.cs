using System;
using System.Globalization;

namespace SalaryExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a matricula do Funcionario");
            int numberFunctionary = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o salario por hora do Funcionario");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas trabalhadas por hora do Funcionario");
            double hoursWorked = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double mouthSalary = hoursWorked * salary;
            Console.WriteLine($"Matricula Funcionario = {numberFunctionary}");
            Console.WriteLine($"Salary = U${mouthSalary:F2}");

        }
    }
}
