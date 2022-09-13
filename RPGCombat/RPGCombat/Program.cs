using RPGCombat.GerenciamentoDoJogo;
using RPGCombat.Jogadores;
using RPGCombat.Inimigos;
using RPGCombat.Personagens;
using System;

namespace RPGCombat
{
    //.Net 5.0
    public class Program
    {
        static void Main(string[] args)
        {
            //Gerenciamento gerenciamento = new();
            //gerenciamento.Game();

            Jogador jogador = new(Personagem.Raca.Humano);
            Console.WriteLine($"Raça do personagem: {jogador.PersonagemRaca}");
            Console.WriteLine($"Life: {jogador.Vida}");
            Console.WriteLine($"Mana: {jogador.Mana}");
            Console.WriteLine($"Atk: {jogador.Atk}");            

            
            Jogador orc = new(Personagem.Raca.Orc);
            Console.WriteLine($"Raça do personagem: {orc.PersonagemRaca}");
            Console.WriteLine($"Life: {orc.Vida}");
            Console.WriteLine($"Mana: {orc.Mana}");
            Console.WriteLine($"Atk: {orc.Atk}");       
            


            
            Console.ReadLine();
        }
    }
}
