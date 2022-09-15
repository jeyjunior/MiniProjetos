
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

        public Personagem(string racaPersonagem) {
            RacaPersonagem = racaPersonagem;
        }

        public abstract void SetAtributosInicialDaRaca(int vida, int mana, int atk);


    }
}
