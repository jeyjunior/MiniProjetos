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
            bool _jogoPrincipal = false;

            var jogador = InstanciarPersonagens.InstanciarJogador();
            
            do
            {
                //MENU INICIAL
                while (_menuInicial == null)
                {
                    _menuInicial = Menu.ExibirMenu("Iniciar Jogo");
                    Console.Clear();
                }


                Combate.IniciarCombate(jogador);
                
                Console.WriteLine("Aperte enter para iniciar proximo combate");
                Console.ReadLine();
            }
            while (!_jogoPrincipal);


            


            Console.ReadLine();
        }
    }
}
