﻿using RPGCombat.Personagens;
using System;

namespace RPGCombat.Inimigos
{
    public class Orc : Habilidades
    {
        public Orc(string racaPersonagem) : base(racaPersonagem)
        {
            Random r = new();
            SetAtributosInicialDaRaca(r.Next(30, 50), r.Next(5, 20), r.Next(1, 10));
        }

        public override void SetAtributosInicialDaRaca(int vida, int mana, int atk)
        {
            Vida = vida;
            Mana = mana;
            Atk = atk;
        }



        //regras atributos do orc
    }
}
