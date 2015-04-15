using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClasesBancoCSharp;

namespace BancoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1;
            Cliente cliente1 = new Cliente();

            Console.WriteLine("Ingrese su nombre");
            cliente1.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            cliente1.Apellido = Console.ReadLine();

            Console.WriteLine("Se creará cuenta (0 = soles, 1 = dolares)");
            Moneda moneda = int.Parse(Console.ReadLine()) == 1 ? Moneda.Soles : Moneda.Dolares;
            cuenta1 = cliente1.CrearCuenta(moneda);

            Console.WriteLine("Ingrese monto a depositar");
            decimal monto = decimal.Parse(Console.ReadLine());
            Deposito deposito1 = new Deposito(monto, moneda);
            deposito1.Ejecutar(cuenta1);

            Console.WriteLine("Cuenta {0}", cuenta1.NumeroCuenta);
            Console.WriteLine("Aperturada en {0}", cuenta1.FechaApertura);
            Console.WriteLine("Moneda {0}", cuenta1.Moneda);
            Console.WriteLine("Saldo {0:F}", cuenta1.Saldo);
            Console.WriteLine("ToString {0}", cuenta1.ToString());
            Console.ReadLine();

        }
    }
}
