using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_S4_EJ1
{
    class Test
    {
        static void Main()
        {
            Empresa empresa = new Empresa("Arcor");

            Empleado empleado = new Empleado("Lucas Rodriguez", 29, "Jefe de planta");

            empresa.Empleado1 = empleado;
            empresa.printInfo();
        }
    }
}
