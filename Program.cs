using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Olá {name}!");
            Console.Write("Digite o ano do seu nascimento: ");
            string years = Console.ReadLine();
            int year = int.Parse(years);
            int age = 2022 - year;
            Console.WriteLine($"Você tem {age} anos.");


        }
    }

   
}
