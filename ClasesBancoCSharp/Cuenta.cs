using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBancoCSharp
{
    public enum Moneda
    {
        Soles,
        Dolares
    }

    public enum EstadoCuenta
    {
        Activa,
        Bloqueada,
        Cerrada
    }

    public class Cuenta
    {
        private int _numeroCuenta;
        private Moneda _moneda;
        private DateTime _fechaApertura;
        private EstadoCuenta _estado;
        private decimal _saldo;

        public int NumeroCuenta
        {
            get { return this._numeroCuenta; }
        }
        public Moneda Moneda
        {
            get { return this._moneda; }
        }
        public DateTime FechaApertura
        {
            get { return this._fechaApertura; }
        }
        public EstadoCuenta Estado
        {
            get { return this._estado; }
        }
        public decimal Saldo {
            get { return this._saldo; }
        }

        public Cuenta(Moneda moneda) {
            this._numeroCuenta = 0;
            this._moneda = moneda;
            this._fechaApertura = DateTime.Now;
            this._estado = EstadoCuenta.Activa;
            this._saldo = 0;
        }

        public void SumarSaldo(decimal monto)
        {
            this._saldo += monto;
        }

        public void RestarSaldo(decimal monto)
        {
            this._saldo -= monto;
        }

        public decimal ConsultarSaldo()
        {
            return this.Saldo;
        }

        public override string ToString()
        {
            return String.Format("Cuenta {0} con saldo {1}", this._numeroCuenta, this._saldo);
        }
    }
}
