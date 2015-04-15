using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBancoCSharp
{
    public class Cliente
    {
        protected string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public List<Cuenta> Cuentas = new List<Cuenta>();

        public Cuenta CrearCuenta(Moneda moneda)
        {
            Cuenta nuevaCuenta = new Cuenta(moneda);
            this.Cuentas.Add(nuevaCuenta);
            return nuevaCuenta;
        }

        public void CerrarCuenta() {}
    }
}
