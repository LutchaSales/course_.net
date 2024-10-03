using System;
using Aula;

namespace Aula
{
    internal class Moto : Veiculo
    {
        public Moto (string marca, string modelo, string cor, double cilindradas) : base (marca, modelo, cor)
        {
            
            
            Cilindradas = cilindradas;
            

        }


      
        public double Cilindradas { get; set; }
        public double  Perigo { get; set; }


        public override void MostreInfo()
        {
            base.MostreInfo();
            Console.WriteLine($"Cor: {Cor} \n" +
                              $"Cilindradas: {Cilindradas}" );

            MostrePericulosidade();

        }

        public void  MostrePericulosidade()
        {
             
                if (Cilindradas >= 500)
                  {
                      Console.WriteLine("Sua Moto é de alta Cilindrada! Use os equipamentos de Proteção e mantenha-se seguro sempre!");
                }
                else
                {
                       Console.WriteLine("Sua moto não é tão potente, mesmo assim, use equipamentos de Proteção e mantenha-se seguro sempre! ");
                }
            
        }
    }

    
}


