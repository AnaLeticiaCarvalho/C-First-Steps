using System;

namespace Begining
{
    class program{
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome? "); //Não pula uma linha
            string nome = Console.ReadLine(); //Recebe a entrada do usuário

            Console.Write("Qual é a sua idade? "); //Não pula uma linha
            int idade = Convert.ToInt32(Console.ReadLine()); //Recebe a entrada do usuário

            Console.WriteLine("Seu nome é: " + nome + " Sua idade é: " + idade);  //Pula uma linha

            Console.Write("Qual é o seu salário? ");
            

            


        }
    }
}