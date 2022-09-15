using System;


namespace RPGCombat.Personagens
{
    //Classe sem objetivo (ainda)
    public abstract class Profissao
    {
        public string[] ProfissoesPersonagem { get; protected set; }
        public string MinhaProfissao { get => ProfissoesPersonagem[escolhaProfissao];}
        private int escolhaProfissao;

        /*
        protected Profissao(Raca raca, int escolhaProfissao) : base(raca)
        {
            this.escolhaProfissao = escolhaProfissao;
        }
        */
        public abstract void SetProfissoesPersonagem(string p1, string p2, string p3);

    }
}
