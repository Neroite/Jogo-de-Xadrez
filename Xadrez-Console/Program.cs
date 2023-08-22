using System;
using Tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Board Tab = new Board(8, 8);

            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new Posicao (0, 0));
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new Posicao (1, 3));
            Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new Posicao (2, 4));

            Tela.ImprimirTabuleiro(Tab);

            Console.ReadLine();
        }
    }
}