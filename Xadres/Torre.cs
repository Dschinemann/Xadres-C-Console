using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadres___Console.Tabuleiro;

namespace Xadres___Console.Xadres
{
    public class Torre: Peca
    {
        public Torre(Tabuleiro.Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }

        public override string? ToString()
        {
            return "T";
        }
    }
}
