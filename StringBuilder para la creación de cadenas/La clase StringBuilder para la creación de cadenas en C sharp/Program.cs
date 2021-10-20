using System;
using System.Text;

namespace StringBuilder_para_la_creación_de_cadenas
{
    class Program
    {
        static void Main()
        {
            //LA CLASE StringBuilder #1

            //Debi utilizar la biblioteca: System.Text;
            //Las cadenas de texto creadas por StringBuilder, son modificables; ya que esta
            //clase crea un buffer para la cadena de texto.
            var names = new StringBuilder("Ezequiel Andrés");
            Console.WriteLine(names.ToString());
            Console.ReadLine();

            //Modificar un caracter de la cadena.
            var names2 = new StringBuilder("Ezequiel Andrés");
            names2[13] = '*';
            Console.WriteLine(names2.ToString());
            Console.ReadLine();

            //Agregar datos a una cadena de texto.
            names.Append(" ");
            names.Append("Brutto.");
            Console.WriteLine(names.ToString());
            Console.ReadLine();

            //LA CLASE StringBuilder #2
            //Otra forma de agregar datos a una cadena.
            var names3 = new StringBuilder("Ezequiel");
            Console.WriteLine(names3.ToString());
            Console.ReadLine();

            names3.Append(" ").Append("Andrés").AppendLine().Append("Brutto.");
            Console.WriteLine(names3.ToString());
            Console.ReadLine();

            //Agregamos datos con distinto formato. En este caso, un entero.
            names3.AppendLine().AppendFormat("Edad {0} años.", 34);
            Console.Write(names3.ToString());
            Console.ReadLine();
        }
    }
}
