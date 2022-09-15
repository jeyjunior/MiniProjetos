using RPGCombat.Jogadores;
using RPGCombat.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombat.GerenciamentoDoJogo
{
    public static class Combate
    {


        public static void IniciarCombate(Jogador jogador) {

            int rodada = 1;
            bool fimCombat = false;

            //gerar inimigo aleatorio
            Random r = new();
            var inimigo = InstanciarPersonagens.IntanciarInimigosAleatorios(r.Next(1, InstanciarPersonagens.totalInimigos + 1));

            do
            {
                
                Console.WriteLine($"-Rodada: {rodada++}\n");
                InformacaoDoObjeto.Informacoes("Jogador", jogador);
                InformacaoDoObjeto.Informacoes(inimigo.RacaPersonagem, inimigo);

                AcaoJogador(jogador, inimigo);
                AcaoInimigo(jogador, inimigo, r);



                if(inimigo.Vida <= 0)
                {
                    fimCombat = true;
                    Console.WriteLine("Player Matou inimigo");
                }
                else if(jogador.Vida <= 0)
                {
                    fimCombat = true;
                    Console.WriteLine("Player MORREU");
                }

                Console.ReadLine();
                Console.Clear();
            }
            while (!fimCombat);
        }

        private static void AcaoJogador(Habilidades jogador, Habilidades inimigo)
        {
            Console.WriteLine("Escolha sua habilidade:");
            for (int i = 0; i < jogador.HabilidadesPersonagem.Length; i++)
            {
                Console.WriteLine($" {i + 1}. {jogador.HabilidadesPersonagem[i]}");
            }


            Console.Write("\nDigite: ");
            int hPersonagem = jogador.UsarHabilidade(Convert.ToInt16(Console.ReadLine()));

            if (hPersonagem != 0)
            {
                inimigo.Vida -= hPersonagem;
            }
        }

        private static void AcaoInimigo(Habilidades jogador, Habilidades inimigo, Random r)
        {
            int hInimigo = inimigo.UsarHabilidade(r.Next(1, inimigo.HabilidadesPersonagem.Length + 1));

            if (hInimigo != 0)
            {
                jogador.Vida -= hInimigo;
            }
        }



    }
}
