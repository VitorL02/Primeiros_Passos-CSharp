using System;
using System.Globalization;

namespace Exercicio_Entrada_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite seu nome completo");
            String nome = Console.ReadLine();
            System.Console.WriteLine("Quantos quartos sua casa possui");
            int quantidade_quartos = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o preço de um produto");
            double preco_produto = double.Parse(Console.ReadLine());

            String []  dados  = Console.ReadLine().Split(" ");
            System.Console.WriteLine("Digite em sequencia seu ultimo nome, idade , e sua altura");
            String ultimo_nome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2],CultureInfo.InvariantCulture);

            System.Console.WriteLine("Os dados informados são : ");
            
        }
    }
}
