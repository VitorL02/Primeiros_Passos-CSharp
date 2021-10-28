using System;

namespace Operadores_Aritimeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordem_operacao = 3 +4 * 2;
            System.Console.WriteLine(ordem_operacao);

            int ordem_operacao2 = (3+4) * 2 ;
            System.Console.WriteLine(ordem_operacao2);

            int ordem_operacao3 = 17 % 2;
            System.Console.WriteLine(ordem_operacao3);

            double operacao_truncada = 10 / 8; //Sem utilizar o casting o compilador retorna uma variavel inteira pois entende que por serem passados dois valores inteiros o resultado deve ser inteiro
            System.Console.WriteLine(operacao_truncada);

            double operacao_alternativa = 10.0 / 8 ; //Entrega agora um resultado decimal pois foi informado que o 10 e um numero decimal com o 10.0
            System.Console.WriteLine(operacao_alternativa);

            double a = 1.0 , b = -4.0 , c= 3.0 ;

            double delta = Math.Pow(b,2) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a); //Math.sqrt = Função de raiz quadrada em C#
            System.Console.WriteLine(x1);
            System.Console.WriteLine(x2);
        }
    }
}
