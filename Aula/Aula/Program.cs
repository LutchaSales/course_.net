using System;
using Aula;


namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Veiculo bike1 = new Veiculo("Sense", "Rockevo", "azul", "vermelho");

            bike1.MostreInfo();
            Console.WriteLine();
            bike1.MostreInfo("vermelha", "Azul");
            

            



        }
    }
}