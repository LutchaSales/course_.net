using System;
using Aula;


namespace Aula
{
    internal class Carro : Veiculo
    {
        public Carro (string marca, string modelo, double cavalos, double peso) : base(marca, modelo)
        { 
            
            Cavalos = cavalos;
            Peso = peso;
            Potencia = CalcPesoPotencia();
        }

       
        
        public double Cavalos { get; set; }

        public double Peso { get; set; }

        public double Potencia { get; }

        private double CalcPesoPotencia()
        {
            return Peso / Cavalos;
        }

        public override void MostreInfo()
        {
            base.MostreInfo();

            Console.WriteLine($"Cavalos: {this.Cavalos}, \n" +
                              $"Peso: {this.Peso}, \n" +
                              $"Potência: {this.Potencia}");
            Console.WriteLine();
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerando carro!!!");
        }

       

        

    }

}
