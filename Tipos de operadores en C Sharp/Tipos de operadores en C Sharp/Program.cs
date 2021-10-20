using System;

namespace Tipos_de_operadores_en_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES ARITMÉTICOS.
            int numberOne = 7;
            int numberTwo = 13;
            // var crea una variable local sin un tipo específico,
            // se convertirá en un tipo determinado dependiendo de 
            // lo que se le asigne o reciba. Se deben inicializar.
            // Sumar:
            var addition = numberOne + numberTwo;

            //Restar:
            int subtraction = numberTwo - numberOne;

            //Multiplicar:
            int multiplication = numberOne * numberTwo;

            //Dividir:
            float division = (float) numberOne / numberTwo;

            Console.WriteLine($"El resultado de la suma es: {addition}\nEl resultado de la resta es: {subtraction}\n" +
                $"El resultado de la multiplicación es: {multiplication}\nEl resultado de la división es: {division}");
            Console.ReadLine();

            //OPERADORES DE ASIGNACIÓN.
            //Operador de asignación por excelencia '='.
            int numberThree = 22;
            int numberFour = 17;

            //Operador de incremento, '+='
            numberThree += numberFour;
            Console.WriteLine($"Resultado operador de incremento: {numberThree}");
            Console.ReadLine();

            //Operador de decremento, '-='
            numberThree -= numberFour;
            Console.WriteLine($"Resultado operador de decremento: {numberThree}");
            Console.ReadLine();

            //Operador de producto, '*='
            numberThree *= numberFour;
            Console.WriteLine($"Resultado operador de producto: {numberThree}");
            Console.ReadLine();

            //Operador de división, '/='
            numberThree /= numberFour;
            Console.WriteLine($"Resultado operador de división: {numberThree}");
            Console.ReadLine();

            //Operador de busca de resto, '%='
            numberThree %= numberFour;
            Console.WriteLine($"Resultado operador de resto: {numberThree}");
            Console.ReadLine();

            //OPERADORES DE COMPARACIÓN, DE TIPOS Y RELACIONALES.
            int numberFive = 45;
            int numberSix = 33;
            //Operador de comparación menor que, '<'
            var compare = numberFive < numberSix;
            Console.WriteLine($"Resultado de comparación: {compare}");
            Console.ReadLine();

            //Operador de comparación mayor que, '>'
            var compare2 = numberFive > numberSix;
            Console.WriteLine($"Resultado de 2da comparación: {compare2}");
            Console.ReadLine();

            //Otros operadores, menor o igual '<=' y mayor o igual '>=';
            // también el operador de igualdad '==' y el distinto de '!='
        }
    }
}
