using System;
using TiendaEnLinea;

namespace Semana8
{
    class Test
    {
        static void Main(string[] args)
        {
            //instanciamos un objeto de clase alimento

            Alimento alimentoNP = new AlimentoNoPerecedero
            {
                Nombre = "Harina",
                Precio = 10.0m,
                Tipo = "Comun"
            };
            Alimento alimentoP = new AlimentoPerecedero
            {
                Nombre = "Yogurt",
                Precio = 350.0m,
                Tipo = "Perecedero",
                DiasParaCaducar = 4
            };            
        }
    }
}
