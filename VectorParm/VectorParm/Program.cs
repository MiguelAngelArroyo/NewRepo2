﻿using System;
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
            string[] nombre = new string[MAX];
            leer(x);
            imprimir(x);
            Console.WriteLine("");
            Console.WriteLine("");
            Ordenar(x);
            Console.WriteLine("Vector ordenar");
            imprimir(x);
            if (buscar(x, 15) == true)
                Console.WriteLine("\n15 Encontrado");
            else
                Console.WriteLine("\n15 no existe");
            if (buscar2(x, 23) == true)
                Console.WriteLine("\n15 Encontrado");
            else
                Console.WriteLine("\n15 no existe");
            //trabajoando con el vector de caracteres
            Console.WriteLine("\nIngrese los Nombres");
            leerNombres(nombre);
            imprimirNombres(nombre);
            Console.WriteLine("");
            Console.WriteLine("");
            OrdenarNombres(nombre);
            Console.WriteLine("Vector ordenar");
            imprimirNombres(nombre);

            Console.ReadKey();

        }
        public static void Ordenar(int[]x)
        {
            int aux = 0;
            for (int i = 0; i< x.Length;i++)
                for(int j=i+1;j < x.Length;j++)
                   if (x[i]>x[j])
                   { //ingresar el elemento del vector
                        aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                   }
                
            
        }
        public static void OrdenarNombres(string[] x)
        {
            string aux="";
            for ( int i=0 ; i < x.Length; i++)
                for (int j = i + 1; j < x.Length; j++)
                    if (String.Compare(x[i], x[j], StringComparison.Ordinal) > 0)
                    { //ingresar el elemento del vector
                        aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                    }


        }
        public static void leer(int[] x)
        {
            for (int i=0;i < MAX;i++)
            {
                Console.WriteLine("\nIngresa el elemento {0}", i + 1);
                x[i] = Int32.Parse(Console.ReadLine());  
            }
        }
        public static void leerNombres(string[] x)
        {
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("\nIngresa el Nombre {0}", i + 1);
                x[i] = (Console.ReadLine());
            }
        }
        public static void imprimir(int[] x)
        {
            foreach(int num in x)
            {
                Console.WriteLine("\nElemento {0}", num);
            }
        }
        public static void imprimirNombres(string[] x)
        {
            foreach (string num in x)
            {
                Console.WriteLine("\nNombre {0}", num);
            }
        }
        public static bool buscar(int[] x, int n )
        {
            bool encontrado = false;
            foreach (int num in x)
            {
                if (num == n)
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
            

        }
        public static bool buscar2(int []x, int y)
        {
            bool encontrado = false;
            int i = 0;
            while(i<MAX && encontrado == false)
            {
                if (x[i] == y)
                    encontrado = true;
                i++;
            }
            return encontrado;
        }
        

    }
}
