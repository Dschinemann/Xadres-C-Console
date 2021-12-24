using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadres___Console.Tabuleiro
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linha, int coluna)
        {
            Linhas = linha;
            Colunas = coluna;
            Pecas = new Peca[linha, coluna];
        }
    }
}
