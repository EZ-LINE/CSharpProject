using System;

namespace Ejercicio_triángulo_de_Pascal_en_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = 0;
            int[] array = new int[1];

            Console.WriteLine("Bienvenido, por favor ingrese el número de pisos: ");
            floors = Convert.ToInt16(Console.ReadLine());

            //Declaramos un ciclo for que va a hacer un recorrido dependiendo de
            //del dato ingresado en la variable floors.
            for (int i = 1; i <= floors; i ++)
            {
                /*Colocamos otro array y ponemos la variable i del ciclo for
                  que será el tamaño que tendrá el array cada vez que el 
                  ciclo for se ejecute.*/

                int[] pascal = new int[i];

                //Anidamos otro ciclo for.
                //Este va en decremento, para poder formar el triángulo.
                for(int j = floors; j < i; j --)
                {
                    Console.Write(" ");
                }
                //Ciclo for para generar la suma de las cifras.
                for (int k = 0; k < i; k ++)
                {
                    //Condición que evalúa la variable del ciclo.
                    if (k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        //Sumamos los números que están en cada posición del arreglo
                        // para formar el triángulo.
                        pascal[k] = array[k] + array[k - 1];
                    }
                    Console.Write("[" + pascal[k] + "]");
                }
                array = pascal;
                Console.WriteLine(" ");
            }

            Console.ReadLine();

        }
    }
}
