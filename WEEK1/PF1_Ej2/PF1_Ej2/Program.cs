using System;


namespace PF1_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Jurados = 3;
            String Nombre;
            double PuntajeFinal;

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
                    Console.WriteLine("El puntaje de " + Nombre + " es:" + PuntajeFinal);
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

