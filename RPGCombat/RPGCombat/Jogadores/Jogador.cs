using RPGCombat.Personagens;


namespace RPGCombat.Jogadores
{
    public class Jogador : Personagem
    {
        public Jogador(string racaPersonagem, int vidaMax, int manaMax, int atkMax) : base(racaPersonagem, vidaMax, manaMax, atkMax)
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
