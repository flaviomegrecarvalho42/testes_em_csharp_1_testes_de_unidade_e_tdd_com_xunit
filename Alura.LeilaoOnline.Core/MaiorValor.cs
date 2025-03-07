﻿using System.Linq;

namespace Alura.LeilaoOnline.Core
{
    public class MaiorValor : IModalidadeAvaliacao
    {
        public Lance Avaliar(Leilao leilao)
        {
            return leilao.Lances.DefaultIfEmpty(new Lance(null, 0))
                                .OrderBy(l => l.Valor)
                                .LastOrDefault();
        }
    }
}
