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
        }
    }
}
