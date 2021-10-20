using System;

namespace IniciosEn.NETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //int year = 1929;

            //Convertir de string a entero:
            int year = Convert.ToInt16("1929");
            double decimals = 2.5;
            string message = "M won";
            // Al declarar con mayúsculas, invocamos estructuras que sirven para operar,
            // las variables se declaran en minúsculas.
            String greetings = "Hello Mr. Shelby! ";
            // decimal para obtener un número con coma, debo agregar M al final.
            decimal decimals2 = 1.7M;
            // float para obtener un número con coma, debo agregar F al final.
            float decimals3 = 4.55F;
            // bool sólo puede almacenar dos tipos de datos, false o true.
            bool parameter = false;
            // char Almacena sólo una letra y siempre se asigna con comillas simples.
            char letter = 'C';

            Console.WriteLine("Hello Mr. Shelby! " + year + " " + decimals + " " + message + " " + parameter);
            Console.WriteLine(greetings + "{0} {1} {2} {3}", year,decimals,message,decimals2);
            // Otra forma de imprimir:
            Console.WriteLine($"Hello Mr. Shelby! {year} {decimals} {message} {decimals3} {letter}");
            Console.ReadLine();

            // Otra forma de concatenar...
            // Console.WriteLine("Hello Mr. Shelby! {0}",year,                ...);
            //                       String   + pos 1er var(year){0} si,... {1}, ...{2}, etc.

            /*DECIMALES:
             * 
             * float 7 dígitos 32 bits.
             * double 15-16 dígitos 64 bits.
             * decimal 28-29 dígitos 128 bits.*/
        }
    }
}
