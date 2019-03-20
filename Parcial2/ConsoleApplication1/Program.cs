using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("A continuacion");
            Console.WriteLine("Digite 1 si desea ver el primer ejercicio del parcial");
            Console.WriteLine("Digite 2 si desea ver el segundo ejercicio del parcial");
            Console.WriteLine("Digite 3 si desea ver el tercer ejercicio del parcial");
            Console.WriteLine("Digite 4 si desea ver el cuarto ejercicio del parcial");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Ejercicio1 E1 = new Ejercicio1();
                    E1.Ejer1();
                    break;
                case 2:
                    Ejercicio2 E2 = new Ejercicio2();
                    E2.Ejer2();
                    break;
                case 3:
                    Ejercicio3 E3 = new Ejercicio3();
                    E3.Ejer3();
                    break;
                case 4:
                    Ejercicio4 E4 = new Ejercicio4();
                    E4.Ejer4();
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion valida");
                    break;
            }

            Console.ReadKey();

        }
    }
}
