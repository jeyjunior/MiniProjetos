using RPGCombat.Personagens;
using System;

namespace RPGCombat.Inimigos
{
    public class Slime : Habilidades
    {
        public Slime(string racaPersonagem) : base(racaPersonagem)
        {
            Random r = new Random();
            SetAtributosInicialDaRaca(r.Next(15,30), r.Next(5,10), 1);
        }

        public override void SetAtributosInicialDaRaca(int vida, int mana, int atk)
        {
            Vida = vida;
            Mana = mana;
            Atk = atk;
        }

        //regras atributos do slime
    }
}
