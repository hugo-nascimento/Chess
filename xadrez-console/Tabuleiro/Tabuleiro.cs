using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int Colunas { get; set; }
        public Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[this.linhas, Colunas];

        }
    }
}
