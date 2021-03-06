using System;
using Xadres___Console.Tabuleiro;

namespace Xadres___Console.Xadres
{
    internal class PosicaoXadres
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadres(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }
        public Posicao toPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string? ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
