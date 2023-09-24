using System;
using ConsoleApp1;

public class Test
{
    public static void Main()
    {
        Superheroe superheroe1 = new Superheroe("Batman", 90, 70, 0);
        Superheroe superheroe2 = new Superheroe("Superman", 95, 60, 70);

        string pelea1 = superheroe1.competir(superheroe2);
        string pelea2 = superheroe2.competir(superheroe1);

        Console.WriteLine("Resultado Batman VS Superman: " + pelea1);
        Console.WriteLine("Resultado Superman VS Batman: " + pelea2); 
    }
}