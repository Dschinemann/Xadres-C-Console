using Xadres___Console;
using Xadres___Console.Tabuleiro;
using Xadres___Console.Xadres;

public class Program
{
    public static void Main(string[] args)
    {
        Tabuleiro tabuleiro = new Tabuleiro(8, 8);
        tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.preto), new Posicao(0, 0));
        tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.preto), new Posicao(1, 3));
        tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.preto), new Posicao(2, 4));

        Tela.ImprimirTabuleiro(tabuleiro);
        Console.ReadLine();
    }
}