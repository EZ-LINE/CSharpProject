using System;

namespace Estructura_condicional_switch_en_C_Sharp
{
    class Program
    {
        static void Main()
        {
            //Instrucción de selección switch.
            var data = 5;

            switch (data)
            {
                case 5:
                    Console.WriteLine("Case: {0}", data);
                break;
                default:
                    Console.WriteLine("Case: {0}", "default");
                break;
            }
            Console.ReadLine();

            //switch con string.
            string name = "Bonfatti";

            switch (name)
            {
                case "Bofatti":
                    Console.WriteLine("Esto está bien hecho.");
                    break;
                default:
                    Console.WriteLine("MALFATTI!!!");
                    break;
            }
            Console.ReadLine();

            //switch expressions #1.
            var data2 = 2;
            var result = data2 switch
            {
                1 => "Ezequiel",
                2 => "Andrés",
                3 => "Juancho"
            };
            Console.WriteLine($"Opción: {data2}\nNombre: {result}.");
            Console.ReadLine();

            //switch expressions #2.
            var (a, b, option) = (2,6,"+");
            var result2 = option switch 
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b
            };
            Console.WriteLine($"Dato ingresado: {option} Resultado: {result2}");
            Console.ReadLine();
        }
    }
}
