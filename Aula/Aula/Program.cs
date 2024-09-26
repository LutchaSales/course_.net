using System;


namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro("Fiat", "Argo", 98, 1350);

            Carro carro2 = new Carro("Hyundai", "Creta", 135, 1520);


            Carro.MostrarInfo(carro1);

            carro2.MostreInfo();
        }
    }
}