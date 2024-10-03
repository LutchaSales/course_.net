using System;
using Aula;


namespace Aula
{
    internal class Veiculo
    {
        public Veiculo(string marca, string modelo, string cor)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;

        }

        public Veiculo(string marca, string modelo, string cor1, string cor2) { 
            Marca = marca;
            Modelo = modelo;
            Cor = cor1;
            Cor = cor2;
            
        }

        private string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }



        public virtual void Acelerar()
        {
            Console.WriteLine("Acelerando veículo!");
        }

        public virtual void MostreInfo()
        {
            Console.Write($"Marca: {this.Marca}, \n" +
                            $"Modelo: {this.Modelo}, \n");
        }

        public virtual void MostreInfo(string cor1, string cor2)
        {
            Console.Write($"Marca: {this.Marca}, \n" +
                            $"Modelo: {this.Modelo}, \n" +
                            $"Primeira Cor: {cor1}, \n" +
                            $"Segunda Cor: {cor2}");
        }


    }
}
