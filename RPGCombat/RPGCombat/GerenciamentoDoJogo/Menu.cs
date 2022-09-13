using System;

namespace RPGCombat.GerenciamentoDoJogo
{
    public static class Menu
    {
        public static bool ExibirMenu(string nameAction)
        {

            Console.Clear();
            Console.WriteLine(" RPG COMBAT");
            Console.WriteLine(" ---------------------");
            Console.WriteLine($" 1. {nameAction}\n 2. Sair");
            Console.Write(" \nDigite o número da ação desejada: ");

            string key = Console.ReadLine();

            switch (key)
            {
                case "1":
                    return true;
                case "2":
                    Environment.Exit(0);
                    return false;
                default:
                    return false;
            }
        }
    }
}
