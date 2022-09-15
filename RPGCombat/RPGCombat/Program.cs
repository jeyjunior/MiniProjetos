using RPGCombat.GerenciamentoDoJogo;
using RPGCombat.Jogadores;
using RPGCombat.Inimigos;
using RPGCombat.Personagens;
using System;
using System.Collections.Generic;

namespace RPGCombat
{
    //.Net 5.0
    public class Program
    {
        static void Main(string[] args)
        {
            int? _menuInicial = null;
            int? _menuPersonagem = null;
            int? _menuGameOver = null;

            bool _jogoPrincipal = false;
            bool _combateIniciado = false;

            var jogador = InstanciarPersonagens.InstanciarJogador();
            
            do
            {
                //MENU INICIAL
                while (_menuInicial == null)
                {
                    Console.WriteLine(" RPG COMBAT");
                    Console.WriteLine(" ---------------------");
                    _menuInicial = Menu.ExibirMenu("Iniciar Jogo");
                    Console.Clear();

                    _menuPersonagem = null;
                }

                //MENU PERSONAGEM
                while (_menuPersonagem == null)
                {
                    Console.Clear();

                    Console.WriteLine(" INFORMAÇÕES DO PERSONAGEM ");
                    Console.WriteLine(" -------------------------- ");
                    InformacaoDoObjeto.Informacoes("Jogador", jogador);

                    Console.WriteLine(" -------------------------- ");
                    Console.WriteLine(" OPÇÕES: \n");
                    _menuPersonagem = Menu.ExibirMenu("Lutar");

                    _combateIniciado = false;
                }

                //gerar inimigo aleatorio
                Random r = new();
                var inimigo = InstanciarPersonagens.IntanciarInimigosAleatorios(r.Next(1, InstanciarPersonagens.totalInimigos + 1));

                //COMBATE
                while (!_combateIniciado)
                {
                    _combateIniciado = Combate.IniciarCombate(jogador, inimigo);
                }

                //GAME OVER
                if (jogador.Vida > 0) {
                    _menuPersonagem = null;
                }
                else
                {
                    while(_menuGameOver == null)
                    {
                        _menuGameOver = Menu.ExibirMenu("Reiniciar Jogo");

                        _menuInicial = null;
                        _jogoPrincipal = false;
                    }
                }

                Console.Clear();
            }
            while (!_jogoPrincipal);
        }
    }
}
