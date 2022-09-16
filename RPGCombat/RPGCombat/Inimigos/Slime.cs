using RPGCombat.Personagens;
using System;

namespace RPGCombat.Inimigos
{
    public class Slime : Personagem
    {
        public Slime(string racaPersonagem, int vidaMax, int manaMax, int atkMax) : base(racaPersonagem, vidaMax, manaMax, atkMax)
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
