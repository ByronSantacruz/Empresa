using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BEmpresa
{
    class Emple_Temporal : Empleado
    {
        private string F_Ingreso;
        private string F_Salida;

        public void Ingresar_Fecha()
        {
            Console.Clear();
            Console.Write("Ingrese la fecha de ingreso: ");
            string F_Ingreso = Console.ReadLine();
            Console.Write("Ingrese la fecha de salida: ");
            string F_Salida = Console.ReadLine();
            Console.WriteLine("Usted tiene un sueldo fijo de $30");
        }
    }
}
