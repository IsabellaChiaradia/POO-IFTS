using System;
using System.ComponentModel.Design;

namespace PF1_Ej3
{
    class Program
    {     
        static void Main(string[] args)
        {
            int Jurados = 3;
            double MinimoProxEtapa = 80;
            String Nombre;
            double PuntajeFinal;
            bool PasaProxEtapa; 

            Console.WriteLine("Ingrese el nombre del participante:");
            string input = Console.ReadLine().ToUpper();
            if (!string.IsNullOrEmpty(input))
            {
                Nombre = input;
                while (Nombre != "FIN")
                {
                    PuntajeFinal = 0;

                    for (int i = 1; i <= Jurados; i++)
                    {
                        Console.WriteLine("Ingrese el puntaje del jurado " + i + " para el participante: " + Nombre);
                        PuntajeFinal += double.Parse(Console.ReadLine());
                    }
                    PasaProxEtapa = MinimoProxEtapa < PuntajeFinal;
                    Console.WriteLine("El puntaje de " + Nombre + " es:" + PuntajeFinal);
                    if (PasaProxEtapa)                   
                        Console.WriteLine(Nombre + " pasó a la instancia final");
                    else
                        Console.WriteLine(Nombre + " NO pasó a la instancia final");
                    Console.WriteLine();
                    Console.WriteLine("Ingrese el nombre del participante:");
                    input = Console.ReadLine().ToUpper();
                    Nombre = input;
                }
            }
            else
            {
                Console.WriteLine("No se ha ingresado un valor válido");
            }
        }
    }
}

