using System;
using Aula;          


namespace Aula
{
    internal class Veiculo
    {
        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        private string Marca { get; set; }

        public string Modelo { get; set; }

        public virtual void Acelerar()
        {
            Console.WriteLine("Acelerando veículo!");
        }

        public static void MostrarInfo(Veiculo veiculo)
        {
            Console.WriteLine($"Marca: {veiculo.Marca}, \n" +
                            $"Modelo: {veiculo.Modelo}, \n");
                          
            Console.WriteLine();
        }

        public virtual void MostreInfo()
        {
            Console.Write($"Marca: {this.Marca}, \n" +
                            $"Modelo: {this.Modelo}, \n");
        }
    }
}
