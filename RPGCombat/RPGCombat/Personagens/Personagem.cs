
using System;
using System.Collections.Generic;


namespace RPGCombat.Personagens
{
    public abstract class Personagem
    {
        public int Vida { get; set; }
        public int Mana { get; set; }
        public int Atk { get; set; }

        public string RacaPersonagem { get; private set; }

        //Skills
        private List<string> minhasHabilidadesFisicas = new List<string>();
        private List<string> minhasHabilidadesMagicas = new List<string>();
        private List<string> minhasHabilidadesSuporte = new List<string>();
        public List<string> MinhasHabilidadesDeAtaqueFisico { get => minhasHabilidadesFisicas; private set => minhasHabilidadesFisicas = value; }
        public List<string> MinhasHabilidadesDeAtaqueMagico { get => minhasHabilidadesMagicas; private set => minhasHabilidadesMagicas = value; }
        public List<string> MinhasHabilidadesDeSuporte { get => minhasHabilidadesSuporte; private set => minhasHabilidadesSuporte = value; }

        public Personagem(string racaPersonagem, int vidaMax, int manaMax, int atkMax) {
            RacaPersonagem = racaPersonagem;

            Random r = new();

            if(racaPersonagem != "Humano")
            {
                Vida = r.Next(vidaMax/2, vidaMax);
                Mana = r.Next(manaMax/2, manaMax);
                Atk = r.Next(atkMax/2, atkMax);
            }
            else
            {
                Vida = vidaMax;
                Mana = manaMax;
                Atk = atkMax;
            }

            SetMinhasHabilidades();
        }

        public abstract void SetMinhasHabilidades();
    }
}
