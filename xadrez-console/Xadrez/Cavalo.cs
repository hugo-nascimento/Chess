﻿using tabuleiro;

namespace Xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override bool[,] MovimentosPossiveis()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "C";
        }
    }
}
