using System;

namespace Variaveis_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            sbyte primeirobyte = 100;

            byte representacao_byte  = 126; //Não aceita valores negativos

            int maximo_valor_de_int = 2147483647;

            long variavel_long = 214748364777L; //O L no final representa que estamos trabalhando com uma variavel LongInt

            bool verdadeiro_falso = true;

            char unicode = '\u0041'; // O \u mostra que o char vai receber um unicode o exemplo aqui e da letra A
            char genero = 'F'; //Tipo de dado que carrega somente um unicode do caractere 
            float teste = 4.5f;
            string nome = "Vitor Lucas"; //So aceita aspas duplas, ele e imutavel
            object primeiro_objeto = "Teste";
            object segundo_objeto = 4.5f;

            // Retorna um valor minimo ou maximo de todos os tipos de variaveis, .max ou .minValue 
            int valor_minimo = int.MinValue; 
            int valor_maximo = int.MaxValue;
            decimal valor_maximo_decimal = decimal.MaxValue;
            decimal valor_minimo_decimal = decimal.MinValue;

            Console.WriteLine(primeirobyte);
            Console.WriteLine(representacao_byte);
            System.Console.WriteLine(maximo_valor_de_int);
            System.Console.WriteLine(variavel_long);
            System.Console.WriteLine(verdadeiro_falso);
            System.Console.WriteLine(genero);
            System.Console.WriteLine(unicode);
            System.Console.WriteLine(teste);
            System.Console.WriteLine(nome);
            System.Console.WriteLine(primeiro_objeto);
            System.Console.WriteLine(segundo_objeto);
            System.Console.WriteLine(valor_minimo);
            System.Console.WriteLine(valor_maximo);
            System.Console.WriteLine(valor_maximo_decimal);
            System.Console.WriteLine(valor_minimo_decimal);
        }
    }
}
