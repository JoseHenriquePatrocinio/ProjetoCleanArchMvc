using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('f',8);
            Console.WriteLine(pos);


            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();

            

        }
    }
}