using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peças
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Codigo da peça");
            int firstPieceCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças");
            int firstPieceQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da peça");
            double firstPieceValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o Codigo da segunda da peça");
            int secondPieceCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças");
            int secondPieceQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da peça");
            double secondPieceValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double totalValue = (firstPieceQuantity * firstPieceValue) + (secondPieceQuantity * secondPieceValue);
            Console.WriteLine($"VALOR A PAGAR = R${totalValue:F2}");
        }
    }
}
