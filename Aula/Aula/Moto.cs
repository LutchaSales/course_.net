using System;
using System.Reflection.PortableExecutable;
using Aula;

namespace Aula
{
    internal class Moto : Veiculo
    {
        public Moto (string marca, string modelo, string cor, double cilindradas) : base (marca, modelo)
        {
            
            Cor = cor;
            Cilindradas = cilindradas;

        }


        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double Cilindradas { get; set; }


        public override void MostreInfo()
        {
            base.MostreInfo();
            Console.WriteLine($"Cor: {Cor} \n" +
                              $"Cilindradas: {Cilindradas}" );

        }
    }

    
}


