using Tabuleiro;

namespace Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Board tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
