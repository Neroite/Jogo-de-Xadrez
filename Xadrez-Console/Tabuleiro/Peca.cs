
namespace Tabuleiro
{
    internal abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Board Tab { get; protected set; }

        public Peca(Board tabuleiro, Cor cor)
        {
            Posicao = null;
            Tab = tabuleiro;
            Cor = cor;
            QteMovimentos = 0;
        }

        public void IncrementarQteMoviemntos()
        {
            QteMovimentos++;
        }

        public void DecrementarQteMoviemntos()
        {
            QteMovimentos--;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j<Tab.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara (Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
