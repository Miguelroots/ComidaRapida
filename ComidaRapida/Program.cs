using System;

namespace ComidaRapida
{
    class Program
    {
        static void Main(string[] args)
        {
            const double hamburguesaPrecio = 5.0;
            const double papasPrecio = 2.5;
            const double bebidaPrecio = 1.5;

            Console.WriteLine("Cuantas hamburguesas desea? ");
            int numHamburguesas = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuantas papas desea?" );
            int numPapas = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuantas bebidas desea? ");
            int numBebidas = int.Parse(Console.ReadLine());

            double total = numHamburguesas * hamburguesaPrecio + numPapas * papasPrecio + numBebidas * bebidaPrecio;

            Console.WriteLine("VALOR A PAGAR: $" + total);
        }
    }
}