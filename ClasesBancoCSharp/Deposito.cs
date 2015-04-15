using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBancoCSharp
{
    public class Deposito:Operacion
    {
        public Deposito(decimal monto, Moneda moneda)
        {
            this.Numero = 0;
            this.Fecha = DateTime.Now;
            this.Monto = monto;
            this.Moneda = moneda;
        }

        public override bool Ejecutar(Cuenta cuenta)
        {
            if (cuenta.Moneda == this.Moneda )
            {
                cuenta.SumarSaldo(this.Monto);
                return true;
            } else {
                return false;
            }
        }
    }
}
