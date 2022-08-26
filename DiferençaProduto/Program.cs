using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiferençaProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero a calcular o Produto");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero a calcular o Produto");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero a calcular o Produto");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto numero a calcular o Produto");
            int fourNumber = int.Parse(Console.ReadLine());
            int diff = (firstNumber * secondNumber - thirdNumber * fourNumber);
            Console.WriteLine($"Diferença = {diff}");
        }
    }
}
