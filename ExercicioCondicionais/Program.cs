using System;

namespace ExercicioCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Escreva uma idade");
            var idade = Console.ReadLine();
            var idadeConvertida = Convert.ToInt32(idade);

            if (idadeConvertida >= 13 && idadeConvertida < 19)
            {
                Console.WriteLine("Adolescente");

            }
            else if (idadeConvertida >= 19 && idadeConvertida <= 60)
            {
                Console.WriteLine("Adulto");

            }
            else if (idadeConvertida > 60)
            {
                Console.WriteLine("idoso");

            }
            else
            {
                Console.WriteLine("Criança");

            }







            

        }
    }
}
