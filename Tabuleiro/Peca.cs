﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadres___Console.Tabuleiro
{
    public class Peca
    {
        public Posicao Posicao {get; set;}
        public Cor Cor {get; set;}
        public int QteMovimento { get; protected set; }
        public Tabuleiro Tab { get; set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QteMovimento = 0;
        }
    }
}
