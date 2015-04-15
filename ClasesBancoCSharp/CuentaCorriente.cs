using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBancoCSharp
{
    public class CuentaCorriente:Cuenta
    {
        public CuentaCorriente(Moneda moneda)
            : base(moneda)
        {
        }
    }
}
