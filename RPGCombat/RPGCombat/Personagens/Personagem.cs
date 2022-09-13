
using System;

namespace RPGCombat.Personagens
{
    public abstract class Personagem
    {
        public enum Raca { Humano, Orc };
        public Raca PersonagemRaca { get; private set; }

        public int Vida { get; set; }
        public int Mana { get; set; }
        public int Atk { get; private set; }


        public Personagem(Raca raca) {

            PersonagemRaca = raca;
            SetAtributosPorRaca();
        }

        private void SetAtributosPorRaca()
        {
            Random r = new Random();

            switch(PersonagemRaca){
                case Raca.Humano:

                    //100,30,20 ÷2
                    Atributos(r.Next(50,100), r.Next(15,30), r.Next(10,20));

                    break;
                case Raca.Orc:
                    //50,10,4 ÷2
                    Atributos(r.Next(25,50), r.Next(5,10), r.Next(2,4));

                    break;
            }
        }

        private void Atributos(int vida, int mana, int atk)
        {
            Vida = vida;
            Mana = mana;
            Atk = atk;
        }


        //public abstract int AtacarFisicamente();
        //public abstract void UsarMagia();
        //public abstract void Curar(int quantidadeCura);

    }
}
