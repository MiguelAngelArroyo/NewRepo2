using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorF
{
    class Program
    {
        static void Main(string[] args)
        {
            vector();
            Console.ReadKey();
        }
        public static void vector()

        {

            Console.WriteLine("\nELEMENTOS DEL VECTOR\n*******\n");

            int[] x = new int[9];

            int max = x[0], min = x[0];

            for (int i = 0; i < 9; i++)

            {

                Console.WriteLine("Ingrese el {0} valor", (i + 1));

                x[i] = int.Parse(Console.ReadLine());


                if (!(x[i] >= 1 && x[i] <= 1000))

                {

                    Console.WriteLine("Ingrese nuevamente el valor {0}", (i + 1));

                    x[i] = int.Parse(Console.ReadLine());

                }

            }

            for (int i = 0; i < 9; i++)

            {

                if (x[i] > max)


                    max = x[i];



                else if (x[i] < min)


                    min = x[i];

            }

            Console.WriteLine("El numero mayor es {0}:", max);

            Console.WriteLine("El numero menor es {0}:", min);

        }

    }
}
    

