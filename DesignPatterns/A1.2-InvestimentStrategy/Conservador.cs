using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._2_InvestimentStrategy
{
    public class Conservador : Investimento
    {
        public double Calcula(Saldo saldo)
        {
            return saldo.Valor * 0.08;
        }
    }
}
