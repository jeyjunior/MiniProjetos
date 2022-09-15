
using System;
using System.Collections.Generic;


namespace RPGCombat.Personagens
{
    public abstract class Personagem
    {
        public int Vida { get; set; }
        public int Mana { get; set; }
        public int Atk { get; set; }

        public string RacaPersonagem { get; private set; }

        public Personagem(string racaPersonagem, int vidaMax, int manaMax, int atkMax) {
            RacaPersonagem = racaPersonagem;

            Random r = new();

            if(racaPersonagem != "Humano")
            {
                Vida = r.Next(vidaMax/2, vidaMax);
                Mana = r.Next(manaMax/2, manaMax);
                Atk = r.Next(atkMax/2, atkMax);
            }
            else
            {
                Vida = vidaMax;
                Mana = manaMax;
                Atk = atkMax;
            }
        }

        protected Personagem(string racaPersonagem)
        {
            RacaPersonagem = racaPersonagem;
        }
    }
}
