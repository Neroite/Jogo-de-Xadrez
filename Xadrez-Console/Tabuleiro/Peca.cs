
namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Board Tab { get; protected set; }

        public Peca(Posicao posicao, Board tabuleiro, Cor cor)
        {
            Posicao = posicao;
            Tab = tabuleiro;
            Cor = cor;
            QteMovimentos = 0;
        }

    }
}
