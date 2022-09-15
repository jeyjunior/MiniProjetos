using RPGCombat.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombat.Inimigos
{
    public class Goblin : Habilidades
    {
        public Goblin(string racaPersonagem, int vida, int mana, int atk) : base(racaPersonagem, vida, mana, atk)
        {
        }
    }
}
