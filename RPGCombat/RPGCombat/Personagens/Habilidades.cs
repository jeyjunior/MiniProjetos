using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombat.Personagens
{
    public abstract class Habilidades : Personagem
    {

        //Quando o retorno da skill é 0, ela simplesmente é executada sem interação com o oponente
        //Quando o retorno da skill é null, precisa escolher novamente uma opção
        //Qualquer número que retornar diferente dos descrito acima, executa uma skill com interação com o oponente


        protected Habilidades(string racaPersonagem, int vida, int mana, int atk) : base(racaPersonagem, vida, mana, atk)
        {

        }

        public string[] HabilidadesPersonagem { get; } = new string[3] { "Ataque Fisico", "Ataque Magico", "Curar" };

        public int? UsarHabilidade(string key, string nome)
        {
            switch (key)
            {
                case "1":
                    return AtaqueFisico(nome);
                case "2":
                    return AtaqueMagico(nome);
                case "3":
                    Curar(nome);
                    return 0;
                default:
                    return null;
            }
        }

        private int AtaqueFisico(string nome)
        {
            Console.WriteLine($"\n   {nome} realizou um ataque fisico -> Dano: {Atk * 1}");
            return Atk;
        }
        private int AtaqueMagico(string nome)
        {
            if(Mana >= 10)
            {
                Console.WriteLine($"\n   {nome} realizou um ataque magico -> Dano: {Atk * 2} | Mana: -10");
                Mana -= 10;
                return Atk * 2;
            }
            else
            {
                Console.WriteLine($"\n   {nome} tentou um ataque magico, mas falhou!!");
                return 0;
            }
        }
        private void Curar(string nome)
        {
            if(Mana >= 10)
            {
                Console.WriteLine($"\n   {nome} se curou -> Vida: +{Atk / 2} | Mana: -10");
                Mana -= 10;
                Vida += Atk / 2;
            }
            else
            {
                Console.WriteLine($"\n   {nome} tentou se curar, mas falhou!!");
            }
        }
    }
}
