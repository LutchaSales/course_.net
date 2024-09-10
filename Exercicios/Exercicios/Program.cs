using System;

namespace Exercicios 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Informe seu nome: ");
            p1.Nome = Console.ReadLine();

            Console.WriteLine("Informe sua Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu nome: ");
            p2.Nome = Console.ReadLine();

            Console.WriteLine("Informe sua Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if( p1.Idade > p2.Idade)
            {
                Console.WriteLine(p1.Nome + " É mais velho(a) que " + p2.Nome);
            }
            else
            {
                Console.WriteLine(p2.Nome + " É mais velho(a) que " + p1.Nome);

            }
        }
    }
}