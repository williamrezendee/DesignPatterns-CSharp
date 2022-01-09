using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._2_InvestimentStrategy
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaInvestimento(Saldo saldo, Investimento investimento)
        {
            double resultado = saldo.Valor + investimento.Calcula(saldo);
            Console.WriteLine(resultado);
        }
    }
}
