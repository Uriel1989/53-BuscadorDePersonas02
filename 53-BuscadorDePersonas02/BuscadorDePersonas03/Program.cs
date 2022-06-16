using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BuscadorDePersonas03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ListadoDeNombres = new string[5];

            Console.WriteLine("Ingrese 5 nombres para guardar en el listado:");

            for (int i=0; i < ListadoDeNombres.Length; i++)
            {
                ListadoDeNombres[i] = Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("Los nombres han sido ingresados, se les han asignado un numero desde el 0 hasta el 4 de acuerdo a su orden de entrada");
            Console.WriteLine("Ingrese un numero para que se muestre el nombre que busca o ingrese -1 para cerrar:");

            int NumeroDeNombre = Convert.ToInt32(Console.ReadLine());

            
                while (NumeroDeNombre != -1)
                {
                    for (int i = 0; i < ListadoDeNombres.Length; i++)
                    {
                        if (i == NumeroDeNombre)
                        {
                            Console.WriteLine("El numero ingresado da como resultado: " + ListadoDeNombres[i]);
                        }
                    }
                    Console.WriteLine("Ingrese otro numero para ver otro nombre de la lista:");
                    NumeroDeNombre = Convert.ToInt32(Console.ReadLine());

                }
            

            //while (NumeroDeNombre != -1)
            //{
            //    for (int i = 0; i < ListadoDeNombres.Length; i++)
            //    {
            //        if (i == NumeroDeNombre)
            //        {
            //            Console.WriteLine("El numero ingresado da como resultado: " + ListadoDeNombres[i]);
            //        }
            //    }
            //    Console.WriteLine("Ingrese otro numero para ver otro nombre de la lista:");
            //    NumeroDeNombre = Convert.ToInt32(Console.ReadLine());

            //}
            //for (int i=0; i<ListadoDeNombres.Length; i++)
            //{
            //    if (i== NumeroDeNombre)
            //    {
            //        Console.WriteLine("El numero ingresado da como resultado: " + ListadoDeNombres[i]);
            //    }
            //}

            Console.ReadKey();
        }
    }
}
