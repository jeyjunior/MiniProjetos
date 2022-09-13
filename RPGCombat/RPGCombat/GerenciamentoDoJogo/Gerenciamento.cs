using System;

namespace RPGCombat.GerenciamentoDoJogo
{
    public class Gerenciamento
    {
        private bool _menuInicial = false;
        private bool _jogoPrincipal = false; 
        public void Game()
        {
            do
            {
                //MENU INICIAL
                while (!_menuInicial)
                {
                    _menuInicial = Menu.ExibirMenu("Iniciar Jogo");
                }


                Console.ReadLine();
            }
            while (!_jogoPrincipal);
        }


        

    }
}
