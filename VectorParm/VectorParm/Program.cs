using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorParm
{
    class Program
    {
        const int MAX = 10;
        static void Main(string[] args)
        {
            int[] x = new int[MAX];
            leer(x);
            imprimir(x);
            Console.ReadKey();

        }
        public static void leer(int[] x)
        {
            for (int i=0;i < MAX;i++)
            {
                Console.WriteLine("\nIngresa el elemento {0}", i + 1);
                x[i] = Int32.Parse(Console.ReadLine());

                    
            }
        }
        public static void imprimir(int[] x)
        {
            foreach(int num in x)
            {
                Console.WriteLine("\nElemento {0}", num);
            }
        }
        public static void devolver(int[] x )
        {
            int n = 0;
            Console.WriteLine("\nIngrese el numero {0}", n);
            n = Int32.Parse(Console.ReadLine());
            if (n = x[])
            {
                Console.WriteLine("Verdadero");
            }
            else
            {
                Console.WriteLine("Falso");
            }

        }
        

    }
}
