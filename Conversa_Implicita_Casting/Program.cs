using System;

namespace Conversa_Implicita_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversão implicita :

            float primeira_convercao = 4.75f;

            double recebe_convercao = primeira_convercao;

            System.Console.WriteLine(recebe_convercao); 

            // double inverte_convercao = 5.1 ;
            // float recebe_inverte_convercao = inverte_convercao; Não e permitido realizar essa conversão pois a linguaguem entende que será uma perca de dados

             double inverte_convercao = 5.1 ;
             float recebe_inverte_convercao = (float) inverte_convercao;  // Casting,informa o tipo de dado que sera passado na variavel informando assim que a perca de dados e permitida
             System.Console.WriteLine(recebe_inverte_convercao);

             double double_convercao_inteiro =  5.1;
             int inteiro = (int) double_convercao_inteiro;

             System.Console.WriteLine(inteiro); //No caso dessa conversão ouve perca de dados
            
            int primeiro_inteiro = 5;
            int segundo_inteiro = 2;

            double resultado = primeiro_inteiro / segundo_inteiro; //Sem um casting realiza divisão com resposta somente de inteiro
            System.Console.WriteLine(resultado);

            double resultado_casting = (double) primeiro_inteiro /segundo_inteiro;
            System.Console.WriteLine(resultado_casting);

        }
    }
}
