using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Clientes : Pessoas
    {

        public override string ToString()
        {
            return Nome + " (" + NrCartao + ")";
        }

        public double getTotalCliente()
        {
            double total = 0;
            foreach (Compras c in Compras)
            {
                total += c.getTotalCompra();
            }
            return total;
        }
    }
}
