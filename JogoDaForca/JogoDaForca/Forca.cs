using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    public class Forca
    {
        public Forca(string _palavra)
        {
            Palavra = _palavra;
        }

        private string palavra = "";

        private int tamanhoPalavra;
        private char[] palavraParaDescobrir;

        private int letrasAcertadas = 0;
        private bool ganhou = false;


        public string Palavra
        {
            get 
            { 
                return palavra;
            }
            set
            {
                palavra = value;
                tamanhoPalavra = value.Length;
                palavraParaDescobrir = new char[tamanhoPalavra];
            }
        }
        public bool Ganhou
        {
            get { return ganhou; }
        }

        public void VerificarLetra(char letra)
        {
            int tamanho = 0;

            foreach (char n in palavra)
            {

                if (n == letra)
                {
                    palavraParaDescobrir[tamanho] = letra;
                    letrasAcertadas++;

                    break;
                }

                tamanho++;
            }
        }
        public void ExibirLetrasEncontrada()
        {
            for (int i = 0; i < tamanhoPalavra; i++)
            {
                if (palavraParaDescobrir[i] != 0)
                {
                    Console.Write($" {palavraParaDescobrir[i]} ");
                }
                else
                {
                    Console.Write(" _ ");
                }
            }
        }
        public void VerificarSeAcertouPalavra()
        {
            if (letrasAcertadas == tamanhoPalavra)
            {
                ganhou =  true;
            }
            else
            {
                ganhou = false;
            }
        }

    }
}
