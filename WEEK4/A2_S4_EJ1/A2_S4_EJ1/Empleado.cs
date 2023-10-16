using System;

namespace A2_S4_EJ1
{
    class Empleado
    {
        private string nombre;
        private int edad;
        private string cargo;

        public Empleado (string nombre, int edad, string cargo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.cargo = cargo;
        }

        public void printInfo()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Cargo: {cargo}");
        }
    }
}
