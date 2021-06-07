using System;

namespace TP1_EJ6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenass");
            Console.Title = "Conversión de Grados";

            double Reaumur, Fahrenheit, Celcius;

            Console.Write("Ingrese la cantidad de Grados Celcius: ");
            Celcius = Convert.ToSingle(Console.ReadLine());

            Reaumur = 0.8 * Celcius;
            Fahrenheit = (1.8 * Celcius) + 32;

            Console.WriteLine($"{Celcius} grados celcius equivalen a {Reaumur} grados Reaumur y {Fahrenheit} grados Fahrenheit" );

        
        }
    }
}
