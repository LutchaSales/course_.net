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

        public virtual void MostreInfo()
        {
            Console.Write($"Marca: {this.Marca}, \n" +
                            $"Modelo: {this.Modelo}, \n");
        }

       
    }
}
