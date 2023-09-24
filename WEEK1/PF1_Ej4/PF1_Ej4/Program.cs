using System;

namespace PF1_Ej4 { 

    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un número de 4 dígitos sin decimales");
            num = int.Parse(Console.ReadLine());

            if (num > 999 && num < 10000)
            {
                int Resultado = 0;
                string Sumandos = "";

                for (int i = 0; i < 4; i++)
                {
                    int digito = num % 10;
                    Resultado += digito;
                    Sumandos += digito;

                    if (i < 4 - 1)
                        Sumandos += " + ";
                    num = num / 10;
                }
               Console.WriteLine($"Sumandos: {Sumandos} = {Resultado}");
            }
            else
                Console.WriteLine("El número ingresado no es válido. Ingrese un número de 4 dígitos");
        }
    }
}