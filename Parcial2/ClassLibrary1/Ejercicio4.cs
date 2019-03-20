using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ejercicio4
    {
        public void Ejer4()
        {
            int i = 0;
            int edad;
            Console.WriteLine("Ingrese las edades de los 5 alumnos");
          
            do
            {
                i = i + 1;
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Su edad es:"+edad);
            } while (i<5);
        }
    }
}
