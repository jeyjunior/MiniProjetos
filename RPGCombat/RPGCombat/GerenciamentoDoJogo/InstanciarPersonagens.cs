using RPGCombat.Inimigos;
using RPGCombat.Jogadores;
using RPGCombat.Personagens;
using System;
using System.Collections.Generic;

namespace RPGCombat.GerenciamentoDoJogo
{
    public static class InstanciarPersonagens
    {
        public static int totalInimigos = 3;

        //Opção Instanciar um inimigo de forma "aleatoria"
        public static Personagem IntanciarInimigosAleatorios(int num)
        {
            switch (num)
            {
                case 1:
                    return InstanciarSlime();
                case 2:
                    return InstanciarOrc();
                case 3:
                    return InstanciarGoblin();
                default:
                    //Sempre vai instanciar algo
                    return InstanciarSlime();
            }
        }

        //Opção de instanciar individualmente
        public static Jogador InstanciarJogador()
        {
            return new Jogador("Humano", 10000, 510, 15);
        }
        public static Slime InstanciarSlime()
        {
            return new Slime("Slime", 30, 1010, 4);
        }        
        public static Orc InstanciarOrc()
        {
            return new Orc("Orc", 50, 2000, 6);
        }
        public static Goblin InstanciarGoblin()
        {
            return new Goblin("Goblin", 60, 1500, 10);
        }

    }
}
