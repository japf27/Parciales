using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ejercicio2
    {
        int num, num1, num2;
        public void Ejer2()
        {
            Console.WriteLine("Division de numeros enteros");
            Console.WriteLine("A continuacion ingrese el primer numero a dividir");
            num1 = int.Parse(Console.ReadLine());

            if (num1 == 0)
            {
                Console.WriteLine("Dividir 0 entre cualquier numero es 0");

            }
            else
            {
                if (num1>0)
                {
                    Console.WriteLine("A continuacion ingrese el segundo numero");
                    num2 = int.Parse(Console.ReadLine());

                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: no se puede dividir entre cero");

                    }
                    else
                    {
                        if (num2 > 0)
                        {
                            num = num1/num2;
                            Console.WriteLine("El resultado de la division de los numeros anteriores es: "+num);
                        }
                    }
                }
            }
        }
    }
}
