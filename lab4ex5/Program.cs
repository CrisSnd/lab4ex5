using System;


namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n, apelati-o si afisati-i rezultatul.  .*/


            Console.Write("Numarul n = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Suma numerelor de la 1 la " + n + " " + "este: ");
            Console.WriteLine(SumaN(n));
        }

        static int SumaN(int n)
        {
            if (n <= 0)
            {
                return n;
            }
            return n + SumaN(n - 1);

        }
    }
}