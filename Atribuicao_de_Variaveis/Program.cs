using System;

namespace Atribuicao_de_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
             int atribuicao1 = 10;
            Console.WriteLine(atribuicao1);
                //Vatriaveis de atribuição acumulativa,usa o valor antigo(Realiza uma soma,divisão,multiplicação etc) como o valor apos  a variavel
            atribuicao1 +=2;
            System.Console.WriteLine(atribuicao1);

            atribuicao1 *=3;
            System.Console.WriteLine(atribuicao1);

            string atribuicao_string = "ABDC"; //Variaveis de atribuicao acumulativa funcionam em strings
            System.Console.WriteLine(atribuicao_string);

            atribuicao_string+= " Vitor";
            System.Console.WriteLine(atribuicao_string);
        
        }
    }
}
