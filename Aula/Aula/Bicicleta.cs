<<<<<<< HEAD
﻿using System;
using Aula;

namespace Aula
{
    internal class Bicicleta : Veiculo
    {
        public Bicicleta(string marca, string modelo,string cor, double aro, double relacao) : base(marca, modelo, cor)
        {

            Aro = aro;
            Relacao = relacao;
            Valor = CalcValor();
        }


        public double Aro { get; set; }
        public double Relacao { get; set; }
        public double Valor { get; }

        private double CalcValor()
        {
            if (Aro < 29)
            {
                return Aro * Relacao * 1.5;
            }
            else
            {
                return Aro * Relacao * 4;
            }
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerando a Bike na ladeira!!");
        }

        public override void MostreInfo()
        {
            base.MostreInfo();

            Console.WriteLine($"Aro: {this.Aro}, \n" +
                              $"Relacao: {this.Relacao}, \n" +
                              $"Valor: {this.Valor}");
            Console.WriteLine();

        }
    }
}
=======
﻿using System;
using Aula;

namespace Aula
{
    internal class Bicicleta : Veiculo
    {
        public Bicicleta(string marca, string modelo, double aro, double relacao) : base(marca, modelo)
        {

            Aro = aro;
            Relacao = relacao;
            Valor = CalcValor();
        }


        public double Aro { get; set; }
        public double Relacao { get; set; }
        public double Valor { get; }

        private double CalcValor()
        {
            if (Aro < 29)
            {
                return Aro * Relacao * 1.5;
            }
            else
            {
                return Aro * Relacao * 4;
            }
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerando a Bike na ladeira!!");
        }

        public override void MostreInfo()
        {
            base.MostreInfo();

            Console.WriteLine($"Aro: {this.Aro}, \n" +
                              $"Relacao: {this.Relacao}, \n" +
                              $"Valor: {this.Valor}");
            Console.WriteLine();

        }
    }
}
>>>>>>> 7f5ca1499c4bf30736b779329a94c2afac531b4f
