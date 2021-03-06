﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimento { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimento = 0;
        }

        public void incrementarQteMovimento() {
            qteMovimento++;
        }

        public void decrementarQteMovimento()
        {
            qteMovimento--;
        }

        public bool existeMovimentosPossives()
        {
            bool[,] mat = movimentoPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public bool movimentoPossivel(Posicao pos)
        {
            return movimentoPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentoPossiveis();

    }
}
