using System;

namespace Las_estructuras_while_y_do_while_en_C_Sharp
{
    class Program
    {
        static void Main()
        {
            //La estructura while.
            bool condition = true;
            int count = 1;

            while (condition)
            {
                if (count == 5)
                {
                    condition = false;
                }
                Console.WriteLine($"Ejecución del while: {count}");
                count++;
            }
            Console.ReadLine();

            //La estructura do while.
            count = 1;
            condition = true;
            do
            {
                if (count == 6)
                {
                    break;
                }
                Console.WriteLine($"Ejecución del do while: {count}");
                count++;
            } while (true);
            Console.ReadLine();
        }
    }
}
