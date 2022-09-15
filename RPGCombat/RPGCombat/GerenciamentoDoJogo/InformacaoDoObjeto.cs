using RPGCombat.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombat.GerenciamentoDoJogo
{
    public static class InformacaoDoObjeto
    {
        public static void Informacoes(string nomeDoObjeto, Habilidades objeto)
        {
            Console.WriteLine($"  {nomeDoObjeto}:");
            Console.WriteLine($"  Life: {objeto.Vida}");
            Console.WriteLine($"  Mana: {objeto.Mana}");
            Console.WriteLine($"  Atk: {objeto.Atk}\n");
        }

    }
}
