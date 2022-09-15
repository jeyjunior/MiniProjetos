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

        private static int turno = 0;

        public static bool IniciarCombate(Jogador jogador, Habilidades inimigo) {

            bool fimCombat = false;



            do
            {
                Console.Clear();
                turno++;
                Console.WriteLine("  INFORMAÇÕES DO COMBATE ");
                Console.WriteLine("  ----------------------  ");
                Console.WriteLine($"  Turno: {turno}");
                Console.WriteLine("  ----------------------  ");
                InformacaoDoObjeto.Informacoes("Jogador", jogador);
                InformacaoDoObjeto.Informacoes(inimigo.RacaPersonagem, inimigo);
                Console.WriteLine("  ----------------------  ");
                AcaoJogador(jogador, inimigo);
                AcaoInimigo(jogador, inimigo);



                if(inimigo.Vida <= 0)
                {
                    fimCombat = true;
                    Console.WriteLine("\n  Você derrotou o inimigo");
                }
                else if(jogador.Vida <= 0)
                {
                    fimCombat = true;
                    Console.WriteLine("\n  VOCÊ MORREU!!!");
                }

                Console.WriteLine("\n  Continuar");
                Console.ReadLine();

                if(fimCombat) turno = 0;
                return fimCombat;
            }
            while (!fimCombat);
            
        }

        private static void AcaoJogador(Habilidades jogador, Habilidades inimigo)
        {

            Console.WriteLine("  Escolha sua habilidade:");
            for (int i = 0; i < jogador.HabilidadesPersonagem.Length; i++)
            {
                Console.WriteLine($"  {i + 1}. {jogador.HabilidadesPersonagem[i]}");
            }



            int? hPersonagem = null;
            while(hPersonagem == null)
            {

                Console.Write("\n  Digite: ");
                hPersonagem = jogador.UsarHabilidade(Console.ReadLine(), "Você");
            }

            if (hPersonagem != 0)
            {
                inimigo.Vida -= (int)hPersonagem;
            }

        }

        private static void AcaoInimigo(Habilidades jogador, Habilidades inimigo)
        {
            Random r = new();

            int? hInimigo = inimigo.UsarHabilidade(r.Next(1, inimigo.HabilidadesPersonagem.Length + 1).ToString(), inimigo.RacaPersonagem);

            if (hInimigo != 0)
            {
                jogador.Vida -= (int)hInimigo;
            }
        }

    }
}
