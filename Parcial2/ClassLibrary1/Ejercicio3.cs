using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ejercicio3
    {
        string nombre  ;

        public void Ejer3()
        {
            
            Console.WriteLine("Ingrese el nombre de los 5 alumnos");

            for (int i = 0; i < 5; i++)
            {
                nombre = Console.ReadLine();
                Console.WriteLine("Su nombre es"+nombre);
            }

            
        }
        
        
    }
}
