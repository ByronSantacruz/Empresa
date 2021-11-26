using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.getNombres();
            empleado.setNombres("Byron Alexander");
            empleado.getApellidos();
            empleado.setApellidos("Santacruz Saltos");
            Console.WriteLine("El empleado {0} {1} se ha bienvenido", empleado.getNombres(), empleado.getApellidos());
            empleado.Escoga_Tipo();
            Console.ReadLine();
        }
    }
}
