using RPGCombat.Personagens;


namespace RPGCombat.Jogadores
{
    public class Jogador : Habilidades
    {
        public Jogador(string racaPersonagem) : base(racaPersonagem)
        {
            //Valores serão de acordo com sua profissao (Guerreiro, Arqueiro, Mago)
            SetAtributosInicialDaRaca(100, 50, 10);
        }

        public override void SetAtributosInicialDaRaca(int vida, int mana, int atk)
        {
            Vida = vida;
            Mana = mana;
            Atk = atk;
        }

        
    }
}
