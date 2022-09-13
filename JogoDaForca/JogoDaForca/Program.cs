using System;

namespace JogoDaForca
{
    public class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine(" Bem Vindo(a) ao jogo da forca \n------------------------\n");
            Console.WriteLine(" Digite uma palavra: ");
            Forca forcaGame = new Forca(Console.ReadLine());

            while (!forcaGame.Ganhou)
            {
                Console.Clear();

                forcaGame.ExibirLetrasEncontrada();
                forcaGame.VerificarSeAcertouPalavra();

                if (forcaGame.Ganhou) break;


                Console.WriteLine("\n  Digite uma letra: ");
                try
                {
                    forcaGame.VerificarLetra(Convert.ToChar(Console.ReadLine()));
                }
                 catch (Exception ex)
                {
                    Console.WriteLine(" Digite uma unica letra");
                    Console.WriteLine($" Erro: {ex.Message}");
                    Console.WriteLine($" StackTrace: {ex.StackTrace}");
                    Console.WriteLine("\n\n Aperte qualquer tecla para continuar");
                    Console.ReadLine();
                }
            }

            #region Mensagem vitoria
            Console.WriteLine("\n\n GG!! Você acertou a palavra!!!!!");
            Console.WriteLine(" Parabéns, você ganhou!!!");
            Console.ReadLine();
            #endregion
        }
    }
}
