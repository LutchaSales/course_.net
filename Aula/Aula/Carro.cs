

namespace Aula
{
    internal class Carro 
    {
        public Carro (string marca, string modelo, double cavalos, double peso) 
        { 
            Marca = marca;
            Modelo = modelo;
            Cavalos = cavalos;
            Peso = peso;
            Potencia = CalcPesoPotencia();
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Cavalos { get; set; }
        public double Peso { get; set; }

        public double Potencia { get; }

        private double CalcPesoPotencia()
        {
            return Peso / Cavalos;
        }

        public static void MostrarInfo(Carro carro)
        {
            Console.WriteLine($"Marca: {carro.Marca}, \n" +
                            $"Modelo: {carro.Modelo}, \n" +
                            $"Cavalos: {carro.Cavalos}, \n" +
                            $"Peso: {carro.Peso}, \n" +
                            $"A Potência do carro é: {(int)carro.Potencia}");
            Console.WriteLine();
        }

        public void MostreInfo()
        {
            Console.WriteLine($"Marca: {this.Marca}, \n" +
                            $"Modelo: {this.Modelo}, \n" +
                            $"Cavalos: {this.Cavalos}, \n" +
                            $"Peso: {this.Peso}, \n" +
                            $"A Potência do carro é: {(int)this.Potencia}");
            Console.WriteLine();
        }

        

    }

}
