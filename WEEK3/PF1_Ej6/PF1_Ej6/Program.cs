using System;

namespace PF1_Ej6
{
    class Program
    {
        static void Main(string[] args) {
            string Nombre = ""; 
            string Nombre1 = "";
            string Nombre2 = "";
            string Nombre3 = "";
            double Capital1;
            double Capital2;
            double Capital3;
            double TotalCapital;

            Capital1 = 0;
            Capital2 = 0;
            Capital3 = 0;
            TotalCapital = 0;
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Ingrese el nombre del socio número " + i); 
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el capital del socio número " + i);
                double Capital = double.Parse(Console.ReadLine());
                if (i == 1)
                {
                    Nombre1 = Nombre;
                    Capital1 = Capital;
                    TotalCapital += Capital1;
                }
                else if (i == 2)
                {
                    Nombre2 = Nombre;
                    Capital2 = Capital;
                    TotalCapital += Capital2;
                }
                else
                {
                    Nombre3 = Nombre;
                    Capital3 = Capital;
                    TotalCapital += Capital3;
                }                
            }
            Console.WriteLine("El total aportado es: $" + TotalCapital);
            Console.WriteLine("El Socio " + Nombre1 + " es: " + Math.Round((Capital1 / TotalCapital) * 100, 2) + "%");
            Console.WriteLine("El Socio " + Nombre2 + " es: " + Math.Round((Capital2 / TotalCapital) * 100, 2) + "%");
            Console.WriteLine("El Socio " + Nombre3 + " es: " + Math.Round((Capital3 / TotalCapital) * 100, 2) + "%");
        }
    }
}
