using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombat.Personagens
{
    public abstract class Habilidades : Personagem
    {
        protected Habilidades(string racaPersonagem):base(racaPersonagem)
        {

        }

        public string[] HabilidadesPersonagem { get; } = new string[3] { "Ataque Fisico", "Ataque Magico", "Curar" };

        public int UsarHabilidade(int key)
        {
            switch (key)
            {
                case 1:
                    return AtaqueFisico();
                case 2:
                    return AtaqueMagico();
                case 3:
                    Curar();
                    return 0;
                default:
                    return 0;
            }
        }

        private int AtaqueFisico()
        {
            //Custo em mana(0) - Atk * 1
            Console.WriteLine($"\n {RacaPersonagem}: ");
            Console.WriteLine($" Realizou um ataque fisico:\n Total dano: {Atk * 1}\n Mana gasta: 0");

            return Atk;
        }
        private int AtaqueMagico()
        {
            //Custo em mana (10) - Atk * 2 
            Console.WriteLine($"\n {RacaPersonagem}: ");
            Console.WriteLine($" Realizou um ataque magico:\n Total dano: {Atk * 2}\n Mana gasta: 10");

            Mana -= 10;
            return Atk * 2;
        }
        private void Curar()
        {
            //Custo em mana (10) - Atk / 2
            Console.WriteLine($"\n {RacaPersonagem}: ");
            Console.WriteLine($" Se curou:\n Total cura: {Atk / 2}\n Mana gasta: 10");
            
            Mana -= 10;
            Vida += Atk / 2;

        }
    }
}
