using RPGCombat.Personagens;
using System;

namespace RPGCombat.Inimigos
{
    public class Slime : Habilidades
    {
        //regras atributos do slime
        public Slime(string racaPersonagem, int vida, int mana, int atk) : base(racaPersonagem, vida, mana, atk)
        {

        }
    }
}
