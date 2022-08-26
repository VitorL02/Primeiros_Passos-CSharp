using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio do circulo");
            double raio = double.Parse(Console.ReadLine());
            double areaCirculo = Math.Pow(raio, 2.0) * 3.14159;
            Console.WriteLine($"A area da circunferencia é: {areaCirculo}");

        }
    }
}
