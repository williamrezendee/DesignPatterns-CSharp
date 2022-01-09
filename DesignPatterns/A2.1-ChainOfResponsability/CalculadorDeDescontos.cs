using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2._1_ChainOfResponsability
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto desconto1 = new DescontoPorCincoItens();
            IDesconto desconto2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto desconto3 = new DescontoPorVendaCasada();
            IDesconto desconto4 = new SemDesconto();

            desconto1.Proximo = desconto2;
            desconto2.Proximo = desconto3;
            desconto3.Proximo = desconto4;

            return desconto1.Desconta(orcamento);
        }
    }
}
