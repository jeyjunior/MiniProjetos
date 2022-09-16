using RPGCombat.Personagens;
using System;

namespace RPGCombat.Inimigos
{
    public class Orc : Personagem
    {
        public Orc(string racaPersonagem, int vida, int mana, int atk) : base(racaPersonagem, vida, mana, atk)
        {
        }

        public override void SetMinhasHabilidades()
        {
            var skills = new ListaHabilidades();
            MinhasHabilidadesDeAtaqueFisico.Add(skills.HabilidadeDeAtaqueFisico[0]);
            MinhasHabilidadesDeAtaqueFisico.Add(skills.HabilidadeDeAtaqueFisico[1]);
            MinhasHabilidadesDeAtaqueFisico.Add(skills.HabilidadeDeAtaqueFisico[2]);

            MinhasHabilidadesDeAtaqueMagico.Add(skills.HabilidadeDeAtaqueMagico[0]);
            MinhasHabilidadesDeAtaqueMagico.Add(skills.HabilidadeDeAtaqueMagico[1]);
            MinhasHabilidadesDeAtaqueMagico.Add(skills.HabilidadeDeAtaqueMagico[2]);

            MinhasHabilidadesDeSuporte.Add(skills.HabilidadeDeSuporte[0]);
        }
    }
}
