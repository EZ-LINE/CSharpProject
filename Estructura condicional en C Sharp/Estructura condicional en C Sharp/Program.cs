using System;

namespace Estructura_condicional_en_C_Sharp
{
    class Program
    {
        static void Main()
        {
            //ESTRUCTURA if Y OPERADORES CONDICIONALES.
            int numberOne = 69;
            int numberTwo = 77;
            double numberThree = 45;
            double numberFour = 21;
            var data = numberFour > numberThree;

            if(numberOne != numberTwo && numberThree > numberFour) 
            {
                Console.WriteLine("Verdadero.");
                Console.ReadLine();
            }

            if (numberOne > numberTwo || numberThree > numberFour) 
            {
                Console.WriteLine("Existen verdades a medias.");
                Console.ReadLine();
            }

            if (!data) 
            {
                Console.WriteLine("Falso.");
                Console.ReadLine();
            }

            //ESTRUCTURa else QUE ACOMPAÑA A LA ESTRUCTURA if.

            var data2 = numberTwo < numberOne;

            if (data2)
            {
                Console.WriteLine($"Verdadero, {numberTwo} es menor que {numberOne}.");
            }
            else 
            {
                Console.WriteLine($"Falso, {numberTwo} es mayor que {numberOne}.");
            }

            Console.ReadLine();

            //ESTRUCTURAS CONDICIONALES ANIDADAS.

            if (data)
            {
                Console.WriteLine($"Verdadero, {numberFour} es menor que {numberThree}.");
            }
            else 
            {
                if (data2)
                {
                    Console.WriteLine($"Verdadero, {numberTwo} es menor que {numberOne}.");
                }
                else 
                {
                    Console.WriteLine("Si llegaste hasta acá, sos más mentiroso que Pinocho.");
                }
            }

            Console.ReadLine();

            //EL OPERADOR CONDICIONAL.

            string condition;
            string condition2;
            string condition3;

            if (!data)
            {
                condition = "Falso.";
            }
            else 
            {
                condition = "Verdadero.";
            }

            Console.WriteLine("Condición: {0}",condition);
            Console.ReadLine();

            //Simplificado con operador condicional:

            condition2 = data2 ? "Es verdad!!!" : "Flor de mentira!!!";

            Console.WriteLine("Condición 2: {0}",condition2);
            Console.ReadLine();

            condition3 = numberTwo > numberThree ? "Oh sí, es cierto!!!" : "Otra vez con mentirillas!!!";

            Console.WriteLine("Condición 3: {0}", condition3);
            Console.ReadLine();
        }
    }
}
