using PrimeiroExercicioAulaClasses;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite medidas triangulo a");
            x.a = double.Parse(Console.ReadLine(), CI);
            x.b = double.Parse(Console.ReadLine(), CI);
            x.c = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Digite medidas triangulo b");
            y.a = double.Parse(Console.ReadLine(), CI);
            y.b = double.Parse(Console.ReadLine(), CI);
            y.c = double.Parse(Console.ReadLine(), CI);

            double areax = x.Area();

            double areay = y.Area();

            Console.WriteLine("Area de x = " + areax.ToString("F4", CI));
            Console.WriteLine("Area de y = " + areay.ToString("F4", CI));

            if (areax > areay) {
                Console.WriteLine("Maior area: X");
            }
            else {
                Console.WriteLine("Maior area Y");
            }
        }
    }
}