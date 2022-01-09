using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._2_InvestimentStrategy
{
    public class Arrojado : Investimento
    {
        public double Calcula(Saldo saldo)
        {
            int escolhido = new Random().Next(101);

            if (escolhido <= 20)
            {
                return saldo.Valor * 0.05;
            }
            else if (escolhido <= 30)
            {
                return saldo.Valor * 0.03;
            }
            else
            {
                return saldo.Valor * 0.006;
            }
        }
    }
}
