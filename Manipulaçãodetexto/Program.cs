using System;

namespace Manipulaçãodetexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um nome");
            var textoAntigo = Console.ReadLine();
            Console.WriteLine(textoAntigo.Replace(" ", ";"));

            
            
        }
    }
}
