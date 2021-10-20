using System;

namespace Tipos_de_métodos_en_C_sharp_p_3
{
    class Program
    {
        //La sobrecarga de métodos constructores, consiste en crear varios métodos constructores, los cuales
        //harán un procedimiento totalmente distinto.
        public Program() 
        {
            Console.Write("                  BIENVENIDO!!!\nEste programa te permitirá conocer el nombre del amor\n" +
                "   de tu vida y la fecha del día en que conocerás\n        a esa persona que tanto deseas.");
            Console.ReadLine();
        }

        public Program(string name) 
        {
            var realName = name.ToCharArray();

            for (int i = 0; i < realName.Length; i++)
            {
                if (realName[i] == 0)
                {
                    char.ToUpper(realName[0]);
                }
                else 
                {
                    char.ToLower(realName[i]);
                }
            }

            foreach (var item in realName)
            {
                Console.WriteLine($"{item}");
            }

            //Convert.ToString(realName);

           // Console.WriteLine($"Hola {realName}!!! ¿Qué deseas conocer?\n (h)ombre o (m)ujer ");
        }

        public Program(string name,int age)
        {

        }

        //si los métodos constructores, reciben los mismos parámetros, se presenta un conflicto, ya que el compilador
        //desconoce cuál método se está invocando. Por eso mismo, se fueron agregando parámetros en los métodos anteriores
        //y, en este caso, se invertirá el orden de los mismos.
        public Program(int age, string name)
        {

        }

        static void Main()
        {
            //Sobrecarga de métodos constructores.
            Random random = new Random();

            new Program();

            Console.WriteLine("Por favor, ingresa tu nombre: ");
            string name = Console.ReadLine();
            
            new Program(name);

            string sex = Console.ReadLine();
            char first = sex[0];

            switch (first)
            {
                case 'h':
                break;
                default:
                break;
            }

        }
    }
}
