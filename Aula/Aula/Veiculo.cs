using System;
<<<<<<< HEAD
using Aula;
=======
using Aula;          
>>>>>>> 7f5ca1499c4bf30736b779329a94c2afac531b4f


namespace Aula
{
    internal class Veiculo
    {
        public Veiculo(string marca, string modelo, string cor)
        {
            Marca = marca;
            Modelo = modelo;
<<<<<<< HEAD
            Cor = cor;
=======
           
        }

        private string Marca { get; set; }
>>>>>>> 7f5ca1499c4bf30736b779329a94c2afac531b4f

        }

        public Veiculo(string marca, string modelo, string cor1, string cor2) { 
            Marca = marca;
            Modelo = modelo;
            Cor = cor1;
            Cor = cor2;
            
        }

        private string Marca { get; set; }
        public string Modelo { get; set; }
<<<<<<< HEAD
        public string Cor { get; set; }


=======
      
>>>>>>> 7f5ca1499c4bf30736b779329a94c2afac531b4f

        public virtual void Acelerar()
        {
            Console.WriteLine("Acelerando veículo!");
        }

        public virtual void MostreInfo()
        {
            Console.Write($"Marca: {this.Marca}, \n" +
                            $"Modelo: {this.Modelo}, \n");
        }

<<<<<<< HEAD
        public virtual void MostreInfo(string cor1, string cor2)
        {
            Console.Write($"Marca: {this.Marca}, \n" +
                            $"Modelo: {this.Modelo}, \n" +
                            $"Primeira Cor: {cor1}, \n" +
                            $"Segunda Cor: {cor2}");
        }


=======
       
>>>>>>> 7f5ca1499c4bf30736b779329a94c2afac531b4f
    }
}
