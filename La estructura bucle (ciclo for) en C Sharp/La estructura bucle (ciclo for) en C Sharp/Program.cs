using System;

namespace La_estructura_bucle__ciclo_for__en_C_Sharp
{
    class Program
    {
        static void Main()
        {
            //BUCLE CICLO for.
            int i;
            string[] names = { "Arándano", "Frutilla", "Cassis", "Frambuesa" };

            for (i = 0; i < 10; i++) 
            {
                Console.WriteLine($"Iteración N°: {i + 1}");
            }

            Console.ReadLine();

            //En reversa.
            for (i = 10; i > 0; i--) 
            {
                Console.WriteLine($"Iteración N°: {i}");
            }

            Console.ReadLine();

            //Otro caso.
            for (i = 0; i < names.Length; i ++) 
            {
                Console.WriteLine("Rica fruta: {0}", names[i]);
            }

            Console.ReadLine();

            //LA ESTRUCTURA BUCLE CICLO foreach.
            foreach (var data in names)
            {
                Console.WriteLine("Rica fruta, rica: {0}", data);
            }

            Console.ReadLine();
        }
    }
}
