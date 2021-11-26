using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BEmpresa
{
    class Emple_Hora : Empleado
    {
        private int Precio_Hora;
        private int Horas_Trabajadas;

        public void Calcular()
        {
            Console.Clear();
            Console.Write(("Ingrese el precio de horas trabajadas: "));
            int Precio_Hora = int.Parse(Console.ReadLine());
            Console.Write(("Ingrese las horas trabajadas de este mes: "));
            int Horas_Trabajos= int.Parse(Console.ReadLine());
            int Calcular = Precio_Hora * Horas_Trabajos;
            Console.WriteLine("Su sueldo es de :" +Calcular);
        }
    }
}
