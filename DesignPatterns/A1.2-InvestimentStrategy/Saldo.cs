using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._2_InvestimentStrategy
{
    public class Saldo
    {
        public double Valor { get; private set; }

        public Saldo(double valor)
        {
            Valor = valor;
        }
    }
}
