using tabuleiro;

namespace Xadrez
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {}

        public override string ToString()
        {
            return "R";
        }
    }
}