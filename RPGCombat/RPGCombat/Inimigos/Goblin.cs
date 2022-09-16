using RPGCombat.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombat.Inimigos
{
    public class Goblin : Personagem
    {
        public Goblin(string racaPersonagem, int vida, int mana, int atk) : base(racaPersonagem, vida, mana, atk)
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
