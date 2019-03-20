using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ejercicio1
    {
        public void Ejer1()
        {
            int num, num1, num2;
            Console.WriteLine("Multiplicacion de numeros enteros");
            Console.WriteLine("a continuacion ingrese el primer numero a multiplicar");

            num1 = int.Parse(Console.ReadLine());

            if (num1 ==0)
            {
                Console.WriteLine("El producto de 0 por cualquier numero es 0");
            }
            else
            {
                if (num1>0)
                {
                    Console.WriteLine("A continuacion ingrese el segundo numero");
                    num2 = int.Parse(Console.ReadLine());
                    if (num2==0)
                    {
                        Console.WriteLine("El producto de 0 por cualquier numero es 0");
                    }
                    else
                    {
                        if (num2>0)
                        {
                            num = num1 * num2;
                            Console.WriteLine("El resultado de esta multiplicacion es: "+num);
                        }
                    }
                }
            }

        }

    }
}
