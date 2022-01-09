using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2._1_ChainOfResponsability
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}
