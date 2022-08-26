using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"Triangulo = {(A*C)/2}");
            Console.WriteLine($"Circulo = {Math.Pow(C,2) * 3.14159 }");
            Console.WriteLine($"Trapezio = {((A + B) * C) / 2}");
            Console.WriteLine($"QUADRADO = {B * B}");
            Console.WriteLine($"Retangulo = {A * B}");

        }
    }
}
