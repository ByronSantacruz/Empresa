using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BEmpresa
{
    class Empleado
    {
        private string Nombres;
        private string Apellidos;
        private int Edad;
        private string Departamento;

        public Empleado()
        {
        }
        public Empleado(string Nombres, string Apellidos, int Edad, string departamento)
        {
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
            this.Departamento = departamento;
        }
        public string getNombres()
        {
            return Nombres;
        }
        public void setNombres(string nombres)
        {
            this.Nombres = nombres;
        }
        public string getApellidos()
        {
            return Apellidos;
        }
        public void setApellidos(string Apellidos)
        {
            this.Apellidos = Apellidos;
        }
        public void Escoga_Tipo()
        {
            int Emple;
            Console.WriteLine("Elija que tipo de empleado es: \nEmpleado temporal-----1 \nEmpleado fijo-----2 \nEmpleado por hora-----3");
            Emple = int.Parse(Console.ReadLine());
            if (Emple == 1)
            {
                Console.WriteLine("Usted a escogido empleado temporal");
                Emple_Temporal emple_Temporal = new Emple_Temporal();
                emple_Temporal.Ingresar_Fecha();
            }
            else if (Emple == 2)
            {
                Console.WriteLine("Usted a escogido empleado fijo");
                Emple_Fijo emple_Fijo = new Emple_Fijo();
                emple_Fijo.Ingresar();
            }
            else if (Emple == 3)
            {
                Console.WriteLine("Usted a escogido empleado por hora");
                Emple_Hora emple_Hora = new Emple_Hora();
                emple_Hora.Calcular();
            }
        }
    }
}
