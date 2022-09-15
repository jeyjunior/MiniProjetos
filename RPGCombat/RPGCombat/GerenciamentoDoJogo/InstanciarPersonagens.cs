using RPGCombat.Inimigos;
using RPGCombat.Jogadores;
using RPGCombat.Personagens;
using System;
using System.Collections.Generic;

namespace RPGCombat.GerenciamentoDoJogo
{
    public static class InstanciarPersonagens
    {
        public static int totalInimigos = 2;

        //Opção Instanciar um inimigo de forma "aleatoria"
        public static Habilidades IntanciarInimigosAleatorios(int num)
        {
            switch (num)
            {
                case 1:
                    return InstanciarOrc();
                case 2:
                    return InstanciarSlime();
                default:
                    //Sempre vai instanciar algo
                    return InstanciarOrc();
            }
        }

        //Opção de instanciar individualmente
        public static Jogador InstanciarJogador()
        {
            return new Jogador("Humano");
        }
        public static Orc InstanciarOrc()
        {
            return new Orc("Orc");
        }
        public static Slime InstanciarSlime()
        {
            return new Slime("Slime");
        }

    }
}
