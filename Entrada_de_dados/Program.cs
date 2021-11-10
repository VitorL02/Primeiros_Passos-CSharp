using System;

namespace Entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
           String vermelho = Console.ReadLine();
           String frase = Console.ReadLine();
           String azul = Console.ReadLine();
           String amarelo = Console.ReadLine();
           String cores = Console.ReadLine();

        //    String[] vetor_string = cores.Split(' '); //Split e uma função para "recortar strings"

            String[] vetor_string = Console.ReadLine().Split(' '); // Realiza a mesma função de declarar uma variavel,como na linha anterior,porem economiza memoria,por não necessariamente declarar uma variavel para receber os dados.
           String primeira_cor = vetor_string[0];
           String segunda_cor = vetor_string[1];
           String terceira_cor = vetor_string[2];



            System.Console.WriteLine("Você digitou : ");
           System.Console.WriteLine(frase);
           System.Console.WriteLine(vermelho);
           System.Console.WriteLine(azul);
           System.Console.WriteLine(amarelo);
           System.Console.WriteLine($"As tres cores digitadas são : {primeira_cor} , {segunda_cor}, {terceira_cor} "); // Utilizando a interpolação para retorno de dados na mesma linha

        }
    }
}
