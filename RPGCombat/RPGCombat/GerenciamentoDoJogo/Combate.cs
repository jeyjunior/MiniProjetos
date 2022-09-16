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

        public static bool IniciarCombate(Personagem jogador, Personagem inimigo) {

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

        private static void AcaoJogador(Personagem jogador, Personagem inimigo)
        {

            Console.WriteLine(" 1. Ataque Fisico | 2. Ataque Magico | 3. Suporte");
            
            int acao = 0;

            Console.Write("\n  Digite: ");
            acao = Convert.ToInt32( Console.ReadLine());


            if (acao == 1)
            {
                //Ataque (Somente dano no inimigo)
                UsarHabilidadeAtaqueFisico(jogador, inimigo);
            }
            else if(acao == 2)
            {
                //Magico (Dano inimigo e Você perde gasta mana)
                UsarHabilidadeAtaqueMagico(jogador, inimigo);
            }            
            else if(acao == 3)
            {
                //Suporte (Sem dano no inimigo e Você recupera vida ou mana)
                UsarHabilidadeSuporte(jogador, "Você");
            }
        }


        private static void UsarHabilidadeAtaqueFisico(Personagem personagem,Personagem oponente)
        {
            var skill = new ListaHabilidades();
            if (personagem.RacaPersonagem == "Humano")
            {
                for (int i = 0; i < personagem.MinhasHabilidadesDeAtaqueFisico.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {personagem.MinhasHabilidadesDeAtaqueFisico[i]}");
                }

                Console.WriteLine("Escolha sua habilidade");
                string key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                        oponente.Vida -= skill.UsarHabilidade(personagem.MinhasHabilidadesDeAtaqueFisico[0], "Você", personagem.Atk.ToString());
                        break;
                    case "2":
                        oponente.Vida -= skill.UsarHabilidade(personagem.MinhasHabilidadesDeAtaqueFisico[1], "Você", personagem.Atk.ToString());
                        break;
                    case "3":
                        oponente.Vida -= skill.UsarHabilidade(personagem.MinhasHabilidadesDeAtaqueFisico[2], "Você", personagem.Atk.ToString());
                        break;
                    default:
                        Console.WriteLine("Opção não existe! Perdeu sua vez!");
                        break;
                }
            }
            else
            {
                Random r = new Random();
                int i = r.Next(0, personagem.MinhasHabilidadesDeAtaqueFisico.Count);

                oponente.Vida -= skill.UsarHabilidade(personagem.MinhasHabilidadesDeAtaqueFisico[i], personagem.RacaPersonagem, personagem.Atk.ToString());
            }
        }        
        
        private static void UsarHabilidadeAtaqueMagico(Personagem personagem,Personagem oponente)
        {
            var skill = new ListaHabilidades();
            if (personagem.RacaPersonagem == "Humano")
            {
                for (int i = 0; i < personagem.MinhasHabilidadesDeAtaqueMagico.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {personagem.MinhasHabilidadesDeAtaqueMagico[i]}");
                }

                Console.WriteLine("Escolha sua habilidade");
                string key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                        oponente.Vida -= skill.UsarHabilidade(personagem.MinhasHabilidadesDeAtaqueMagico[0], "Você", personagem.Atk.ToString(), personagem.Mana.ToString());
                        
                        break;
                    case "2":
                        oponente.Vida -= skill.UsarHabilidade(personagem.MinhasHabilidadesDeAtaqueMagico[1], "Você", personagem.Atk.ToString(), personagem.Mana.ToString());
                        break;
                    case "3":
                        oponente.Vida -= skill.UsarHabilidade(personagem.MinhasHabilidadesDeAtaqueMagico[2], "Você", personagem.Atk.ToString(), personagem.Mana.ToString());
                        break;
                    default:
                        Console.WriteLine("Opção não existe! Perdeu sua vez!");
                        break;
                }
            }
            else
            {
                Random r = new Random();
                int i = r.Next(0, personagem.MinhasHabilidadesDeAtaqueMagico.Count);

                oponente.Vida -= skill.UsarHabilidade(personagem.MinhasHabilidadesDeAtaqueMagico[i], personagem.RacaPersonagem, personagem.Atk.ToString(), personagem.Mana.ToString());
            }

            personagem.Mana -= skill.ManaGasta;
        }
        private static void UsarHabilidadeSuporte(Personagem personagem, string nomeObj)
        {
            var skill = new ListaHabilidades();

            personagem.Vida += skill.UsarHabilidade(personagem.MinhasHabilidadesDeSuporte[0], nomeObj, personagem.Atk.ToString(), personagem.Mana.ToString());
            personagem.Mana -= skill.ManaGasta;
        }
        private static void AcaoInimigo(Personagem jogador, Personagem inimigo)
        {
            Random r = new Random();

            if(r.Next(1, 4) == 1)
            {
                UsarHabilidadeAtaqueFisico(inimigo, jogador);
            }
            else if(r.Next(1,4) == 2)
            {
                UsarHabilidadeAtaqueMagico(inimigo, jogador);
            }
            else if(r.Next(1,4) == 3)
            {
                UsarHabilidadeSuporte(inimigo, inimigo.RacaPersonagem);
            }
            else
            {
                UsarHabilidadeAtaqueFisico(inimigo, jogador);
            }
        }

    }
}
