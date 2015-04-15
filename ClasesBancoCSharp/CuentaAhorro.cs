using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBancoCSharp
{
    public class CuentaAhorro:Cuenta
    {
        public CuentaAhorro(Moneda moneda)
            :base(moneda)
        {
        }
    }
}
