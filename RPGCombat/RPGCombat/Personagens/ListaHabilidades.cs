using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombat.Personagens
{
    public class ListaHabilidades
    {
        public List<string> HabilidadeDeAtaqueFisico { get; } = new List<string> {
            "Socar",
            "AtaqueComGarras",
            "AtirarFlecha",
        };
        public List<string> HabilidadeDeAtaqueMagico { get; } = new List<string> {
            "BolaDeFogo",
            "LancaDeGelo",
            "Relampago",
        };


        public List<string> HabilidadeDeSuporte { get; } = new List<string> {
            "Curar"
        };



        public int ValorDeRetornoDaHabilidade { get; set; }
        public int ManaGasta { get; set; }


        public int UsarHabilidade(string nomeDaMagia, string nomeObj, string value)
        {
            string[] param = new string[] { nomeObj, value };
            MethodInfo invocarMetodo = GetType().GetMethod(nomeDaMagia);
            Console.WriteLine(invocarMetodo.Invoke(this, param));
            return ValorDeRetornoDaHabilidade;
        }
        public int UsarHabilidade(string nomeDaMagia, string nomeObj, string value, string mana)
        {
            string[] param = new string[] { nomeObj, value, mana };
            MethodInfo invocarMetodo = GetType().GetMethod(nomeDaMagia);
            Console.WriteLine(invocarMetodo.Invoke(this, param));
            return ValorDeRetornoDaHabilidade;
        }




        //Habilidades Fisicas 
        public string Socar(string nomeObj, string atk)
        {
            ValorDeRetornoDaHabilidade = Convert.ToInt32(atk);
            return$"\n   {nomeObj} socou o oponente -> Dano: {atk}";
        }
        public string AtaqueComGarras(string nomeObj, string atk)
        {
            ValorDeRetornoDaHabilidade = Convert.ToInt32(atk) + 4;
            return $"\n   {nomeObj} atacou usando suas garras -> Dano: {Convert.ToInt32(atk) + 4}";
        }        
        public string AtirarFlecha(string nomeObj, string atk)
        {
            ValorDeRetornoDaHabilidade = Convert.ToInt32(atk) - 1;
            return $"\n   {nomeObj} atirou uma flecha -> Dano: {Convert.ToInt32(atk) - 1}";
        }


        //Magias de Ataque
        public string BolaDeFogo(string nome, string atk, string mana)
        {
            if (Convert.ToInt16(mana) >= 15)
            {
                ManaGasta = 15;
                ValorDeRetornoDaHabilidade = Convert.ToInt16(atk) + 13;
                return $"\n   {nome} atirou uma Bola de Fogo -> Dano: {Convert.ToInt16(atk) + 13} | Mana: -15";
            }
            else
            {
                ValorDeRetornoDaHabilidade = 0;
                return  $"\n   {nome} tentou um ataque magico, mas falhou!!";
            }
        }
        public string LancaDeGelo(string nome, string atk, string mana)
        {
            if (Convert.ToInt16(mana) >= 7)
            {
                ManaGasta = 7;
                ValorDeRetornoDaHabilidade = Convert.ToInt16(atk) + 6;
                return $"\n   {nome} atirou uma Lança de Gelo -> Dano: {Convert.ToInt16(atk) + 6} | Mana: -7";
            }
            else
            {
                ValorDeRetornoDaHabilidade = 0;
                return $"\n   {nome} tentou um ataque magico, mas falhou!!";
            }
        }

        public string Relampago(string nome, string atk, string mana)
        {
            if (Convert.ToInt16(mana) >= 9)
            {
                ManaGasta = 9;
                ValorDeRetornoDaHabilidade = Convert.ToInt16(atk) + 9;
                return $"\n   {nome} usou relampago -> Dano: {Convert.ToInt16(atk) + 9} | Mana: -9";
            }
            else
            {
                ValorDeRetornoDaHabilidade = 0;
                return $"\n   {nome} tentou um ataque magico, mas falhou!!";
            }
        }



        //Magias de Suporte
        public string Curar(string nome, string atk, string mana)
        {
            if (Convert.ToInt16(mana) >= 10)
            {
                ManaGasta = 10;
                ValorDeRetornoDaHabilidade = Convert.ToInt16(atk) / 2;
                return $"\n   {nome} se curou -> Vida: +{Convert.ToInt16(atk) / 2} | Mana: -10";
            }
            else
            {
                ValorDeRetornoDaHabilidade = 0;
                return $"\n   {nome} tentou se curar, mas falhou!!";
            }
        }


    }
}
