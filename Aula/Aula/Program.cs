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
            

<<<<<<< HEAD
=======
            var carro1 = new Carro("Fiat", "Uno", 75, 1200);

            var bike1 = new Bicicleta("Sense", "RockEvo", 26, 27);

            var moto1 = new Moto("Yamaha", "R15", "Preta", 155);
            
            moto1.MostreInfo();

>>>>>>> 7f5ca1499c4bf30736b779329a94c2afac531b4f
            



        }
    }
}