using System;

namespace RPGCombat.GerenciamentoDoJogo
{
    public static class Menu
    {
        public static int? ExibirMenu(string nomeAcaoUm)
        {

            Console.Clear();
            Console.WriteLine(" RPG COMBAT");
            Console.WriteLine(" ---------------------");
            Console.WriteLine($" 1. {nomeAcaoUm}\n 2. Sair");
            Console.Write(" \nDigite o número da ação desejada: ");

            string key = Console.ReadLine();

            switch (key)
            {
                case "1":
                    return 1;
                case "2":
                    Environment.Exit(0);
                    return 2;
                default:
                    return null;
            }
        }        
        
        public static int? ExibirMenu(string nomeAcaoUm, string nomeAcaoDois)
        {

            Console.Clear();
            Console.WriteLine(" RPG COMBAT");
            Console.WriteLine(" ---------------------");
            Console.WriteLine($" 1. {nomeAcaoUm}\n 2. {nomeAcaoDois}\n 2. Sair");
            Console.Write(" \nDigite o número da ação desejada: ");

            string key = Console.ReadLine();

            switch (key)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    Environment.Exit(0);
                    return 3;
                default:
                    return null;
            }
        }
    }
}
