using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._2_InvestimentStrategy
{
    public class Moderado : Investimento
    {
        public double Calcula(Saldo saldo)
        {
            int escolhido = new Random().Next(2);
            if (escolhido == 0)
            {
                return saldo.Valor * 0.025;
            }
            else
            {
                return saldo.Valor * 0.007;
            }
        }
    }
}
