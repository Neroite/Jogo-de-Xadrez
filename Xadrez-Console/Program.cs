using System;
using Tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Board Tab = new Board(8, 8);

                Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new Posicao(0, 0));
                Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new Posicao(1, 3));
                Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new Posicao(0, 2));

                Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new Posicao(3, 5));


                Tela.ImprimirTabuleiro(Tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}