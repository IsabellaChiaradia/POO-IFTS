using System;

namespace PF1_Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            double VARIABLE_1;
            double Resultado;

            Console.WriteLine("Ingrese el valor del producto");
            VARIABLE_1 = double.Parse(Console.ReadLine());
            Resultado = (VARIABLE_1 * 15) / 100;
            Console.WriteLine(Resultado);
        }
    }
}
