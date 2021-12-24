
namespace Xadres___Console.Tabuleiro
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linha, int coluna)
        {
            Linhas = linha;
            Colunas = coluna;
            pecas = new Peca[linha, coluna];
        }

        public Peca Getpeca(int linha, int colula) {
            return pecas[linha, colula];
        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }
    }
}
