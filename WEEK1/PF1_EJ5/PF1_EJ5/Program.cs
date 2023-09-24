using System;

namespace PF1_Ej5
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número sin decimales");
            string numStr = Console.ReadLine();

            if (int.TryParse(numStr, out int num))
            {
                int Resultado = 0;
                string Sumandos = "";

                for (int i = 0; i < numStr.Length; i++)
                {
                    int digito = int.Parse(numStr[i].ToString());
                    Resultado += digito;
                    Sumandos += digito;

                    if (i < numStr.Length - 1)
                    {
                        Sumandos += " + ";
                    }
                }
                Console.WriteLine($"Sumandos: {Sumandos} = {Resultado}");
            }
            else
                Console.WriteLine("El número ingresado no es válido. Ingrese un número de 4 dígitos");
        }
    }
}