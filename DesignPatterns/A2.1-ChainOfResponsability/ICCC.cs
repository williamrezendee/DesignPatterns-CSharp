using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2._1_ChainOfResponsability
{
    public class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000.0)
            {
                return orcamento.Valor * 0.05;
            }
            else if (orcamento.Valor >= 1000.0 && orcamento.Valor <= 3000.0)
            {
                return orcamento.Valor * 0.07;
            }
            return orcamento.Valor * 0.08 + 30.0;
        }
    }
}
