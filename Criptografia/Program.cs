using System;

namespace Criptografia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a aplicacao de criptografia");
            Console.WriteLine("Informe a senha");

            var senha = Console.ReadLine();
            var senhaCriptografada = "";
            var random = new Random();
            for (int i = senha.Length; i >= 1; i--)
            {
                senhaCriptografada += senha[i - 1].ToString() + random.Next(9);
            }
            Console.WriteLine(senhaCriptografada);
            Console.ReadLine();
        }
    }
}
