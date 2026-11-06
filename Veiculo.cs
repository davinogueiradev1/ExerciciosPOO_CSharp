using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Veiculo
    {
        public decimal velocidade { get; private set; }
        public decimal novaVelocidade { get; private set; }

        public void registrarVelocidade(decimal velocidade)
        {
            if(velocidade >= 0 && velocidade<= 200)
            {
                Console.WriteLine($"A velocidade registrada foi de {velocidade}km/h.");
            }
            else if(velocidade > 200)
            {
                Console.WriteLine("A velocidade registrada é inválida devido ao seu valor superior ao limite do sistema(200km/h).\nPor favor, faça a alteração do valor.");
            }
            else if(velocidade < 0)
            {
                Console.WriteLine("A velocidade registrada é inválida devido ao seu valor negativo.\nPor favor, faça a alteração do valor.");
            }
        }

        public void alterarVelocidade(decimal novaVelocidade)
        {
            if(novaVelocidade >=0 && novaVelocidade <= 200)
            {
               velocidade = novaVelocidade; 
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }
    }

    
}