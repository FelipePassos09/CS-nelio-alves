using System;
using tabuleiro;
using Xadrez;

namespace MyImplementation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                
                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (tabuleiroExeception e)
            {
                Console.WriteLine(e.Message);
            }

            

        }
    }
}