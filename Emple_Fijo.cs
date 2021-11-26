using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BEmpresa
{
    class Emple_Fijo : Empleado
    {
        private int Año_Entrada;
        private int Año_Actual;
        private int Complemento=10;
        private int Sueldo_Base= 10;
        public void Ingresar()
        {
            Console.Clear();
            Console.Write("Ingrese el año que entro a la emplesa : ");
            int Año_Entrada = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el año en el que nos encontramos : ");
            int Año_Actual = int.Parse(Console.ReadLine());
            int Resta = Año_Actual - Año_Entrada;
            int Suma = Sueldo_Base + Complemento;
            int Mult = Suma * Resta;
            Console.WriteLine("Su sueldo es de :" + Mult);

        }
    }
}
