using Xadres___Console.Tabuleiro;

namespace Xadres___Console.Xadres
{
    public class Rei:Peca
    {
        public Rei(Tabuleiro.Tabuleiro tab, Cor cor): base(cor , tab)
        {

        }

        public override string? ToString()
        {
            return "R";
        }
    }
}
