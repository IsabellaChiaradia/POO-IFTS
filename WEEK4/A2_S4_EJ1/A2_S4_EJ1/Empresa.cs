using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_S4_EJ1
{
    class Empresa
    {
        private string nombreEmpresa;
        private Empleado empleado1;

        public Empresa(string nombreEmpresa)
        {
            this.nombreEmpresa = nombreEmpresa;
        }

        public Empleado Empleado1
        {
            get { return empleado1; }
            set { this.empleado1 = value; }
        }

        public void printInfo()
        {
            Console.WriteLine($"Nombre Empresa: {nombreEmpresa}");
            Console.WriteLine("Empleado: ");
            empleado1.printInfo();
        }
    }
}
