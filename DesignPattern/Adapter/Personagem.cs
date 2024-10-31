using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Personagem : IAcao
    {
        public void Andar(string jogador)
        {
            Console.WriteLine(jogador + " ANDOU PARA FRENTE!");
        }

        public void Atirar()
        {
            Console.WriteLine("Atirou no jogo!"); 
        }
    }
}
