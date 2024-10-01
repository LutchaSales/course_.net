using System;
using Aula;


namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var veiculo1 = new Veiculo("Air Bus", "A-320");       
            

            var carro1 = new Carro("Fiat", "Uno", 75, 1200);

            var bike1 = new Bicicleta("Sense", "RockEvo", 26, 27);

            var moto1 = new Moto("Yamaha", "R15", "Preta", 155);
            
            moto1.MostreInfo();

            



        }
    }
}