using System;
using System.Globalization;

namespace Saida_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 18;
            double saldo = 550.3068478894;
            string nome = "Clara";

            System.Console.Write("Bom dia"); //Não realiza a quebra de linha
            System.Console.WriteLine("Bom dia!");
            System.Console.WriteLine("Como você está?");

            System.Console.WriteLine("------------");
            System.Console.WriteLine(genero);
            System.Console.WriteLine(idade);
            System.Console.WriteLine(nome);
            System.Console.WriteLine(saldo.ToString("F2"));   //Limita a somente dois caracteres o valor 
            System.Console.WriteLine(saldo.ToString("F4"));
            System.Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture)); //Ignora todas as formatações de sistema e usa o "." como separador
            System.Console.WriteLine("------------");
            System.Console.WriteLine("{0} tem {1} anos e tem saldo igual {2:F2} reais", nome, idade ,saldo); // Utiliza o placeHolder para mostrar as variaveis
            System.Console.WriteLine($"{nome} tem {idade} anos e tem o saldo igual {saldo:F2}"); //Utilizando agora a intepolação de variaveis 
            System.Console.WriteLine(nome + " tem " + idade + " anos e tem o saldo igual a " + saldo.ToString("f2")); //Concatenação de variaveis
        }
    }
}
