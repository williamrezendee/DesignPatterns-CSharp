using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._2_InvestimentStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Investimento conservador = new Conservador();
            Investimento moderado = new Moderado();
            Investimento arrojado = new Arrojado();

            Saldo saldo = new Saldo(1000);
            RealizadorDeInvestimentos realizador = new RealizadorDeInvestimentos();

            realizador.RealizaInvestimento(saldo, conservador);
            realizador.RealizaInvestimento(saldo, moderado);
            realizador.RealizaInvestimento(saldo, arrojado);
        }
    }
}
