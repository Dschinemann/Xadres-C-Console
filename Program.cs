using Xadres___Console;
using Xadres___Console.Tabuleiro;
using Xadres___Console.Xadres;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.preto), new Posicao(0, 0));
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.preto), new Posicao(1, 9));
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.preto), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tabuleiro);
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadLine();
    }
}