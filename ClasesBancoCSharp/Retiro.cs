using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBancoCSharp
{
    public class Retiro:Operacion
    {

        public Retiro(decimal monto, Moneda moneda)
        {
            this.Numero = 0;
            this.Fecha = DateTime.Now;
            this.Monto = monto;
            this.Moneda = moneda;
        }

        public override bool Ejecutar(Cuenta cuenta)
        {
            if (cuenta.Moneda == this.Moneda)
            {
                cuenta.RestarSaldo(this.Monto);
                return true;
            } else {
                return false;
            }
        }
    }
}
