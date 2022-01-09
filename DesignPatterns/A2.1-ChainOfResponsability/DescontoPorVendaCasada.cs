using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2._1_ChainOfResponsability
{
    class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        TestaCorrente testa = new TestaCorrente();

        public double Desconta(Orcamento orcamento)
        {
            if (testa.Existe("LAPIS", orcamento) && testa.Existe("CANETA", orcamento))
            {
                return orcamento.Valor * 0.05;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}
