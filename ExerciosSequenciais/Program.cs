using System;



namespace ExerciosSequenciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero a ser somado");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero a ser somado");
            int secondNumber = int.Parse(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            Console.WriteLine($"A soma dos numeros = {sum}");

        }
    }
}
