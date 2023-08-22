using System;
using Tabuleiro;

namespace Xadrez_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Board Tab = new Board(8, 8);

            Tela.ImprimirTabuleiro(Tab);

            Console.ReadLine();
        }
    }
}