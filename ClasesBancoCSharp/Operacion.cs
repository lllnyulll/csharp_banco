using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBancoCSharp
{
    public abstract class Operacion
    {
        protected int Numero { get; set; }
        protected DateTime Fecha { get; set; }
        protected Moneda Moneda { get; set; }
        protected decimal Monto { get; set; }

        public virtual string Consultar() { return ""; }
        public abstract bool Ejecutar(Cuenta cuenta);

    }
}
