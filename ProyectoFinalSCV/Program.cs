using System;

namespace ProyectoFinalSCV
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            Console.WriteLine("----- MENU DE OPCIONES -----");
            Console.WriteLine("1 - SUMA");
            Console.WriteLine("2 - RESTA");
            Console.WriteLine("3 - MULTIPLICACION");
            Console.WriteLine("4 - DIVISION");
            Console.WriteLine(" 5 - SALIR");
            Console.WriteLine();
            Console.WriteLine("Elija una opción: ");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    double a, b;
                    Console.WriteLine("--- SUMA ---");
                    Console.WriteLine("Ingrese el primer número: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número:");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"El resultado de la suma es: {a+b}");
                    break;
                case 2:
                    double c, d;
                    Console.WriteLine("--- RESTA ---");
                    Console.WriteLine("Ingrese el primer número: ");
                    c = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número:");
                    d = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"El resultado de la suma es: {c - d}");
                    break;
                case 3:
                    double e, f;
                    Console.WriteLine("--- MULTIPLICACION ---");
                    Console.WriteLine("Ingrese el primer número: ");
                    e = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número:");
                    f = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"El resultado de la suma es: {e-f}");
                    break;
                    break;
                default:
                    break;
            }
        }
    }
}
