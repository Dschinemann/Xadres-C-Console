using Xadres___Console.Tabuleiro;

namespace Xadres___Console
{
    public class Tela
    {

        public static void ImprimirTabuleiro(Tabuleiro.Tabuleiro tab)
        {
            for(int i=0; i<tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Getpeca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else {
                        Console.Write(tab.Getpeca(i, j) + " ");
                    }                            
                }
                Console.WriteLine();    
            }
        }
    }
}
