using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2._1_ChainOfResponsability
{
    public class TestaCorrente
    {
        public bool Existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
