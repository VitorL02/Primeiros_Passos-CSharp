using System;
using System.Globalization;

namespace Exercicio_Fixacao_Saida_dados
{
    class Program
    {
        static void Main(string[] args)
        {
           string produto1= "Computador";
           string produto2 ="Mesa de escritorio";

           int idade = 30;
           int codigo = 5290;
           char genero = 'M';

            double preco1= 2100.01;
            double preco2 = 650.50;
            double medida = 53.234567;

            System.Console.WriteLine("Produtos");
            System.Console.WriteLine($"{produto1} cujo preço é $ {preco1:f2}");
            System.Console.WriteLine($"{produto2}, cujo preço e $ {preco2:f2}");
            System.Console.WriteLine($"Registro :{idade} anos de idade, codigo {codigo} e gênero {genero}" );
            System.Console.WriteLine($"Medida com 8 casas decimais: {medida:f8}");
            System.Console.WriteLine($"Arredondador (tres casa decimais): {medida:f3}");
            System.Console.WriteLine("Separador decimal invariant culture: {0}" , medida.ToString(CultureInfo.InvariantCulture));

        }
    }
}
