using System;

namespace Manipulación_de_strings_en_C_Sharp
{
    class Program
    {
        static void Main()
        {
            //INMUTABILIDAD DE LOS OBJETOS string.
            //Son inmutables porque una vez asignados a la variable, ya no pueden modificarse.
            string firstName = "Ezequiel ";
            string secondName = "Andrés ";
            string thirdName = firstName;

            //Concatenar. (Al concatenar, no se pierde la inmutabilidad, ya que no modifica sino que añade).
            firstName += secondName;

            Console.WriteLine("Nombre completo: {0} {1} {2}", firstName,secondName,thirdName);
            Console.ReadLine();

            //FORMATO DE CADENAS.
            
            //Interpolación de cadenas.
            var person = (name: "Susana", surname: "Torio", age: 43); ;

            Console.WriteLine($"Nombre completo: {person.name} {person.surname} Edad: {person.age} años.");
            Console.ReadLine();

            //Formato compuesto.
            Console.WriteLine("Nombre completo: {0} {1}. Edad: {2} años.",person.name,person.surname,person.age);
            Console.ReadLine();

            //SUBCADENAS DE string.

            //Una subcadena, es cualquier secuencia de caracteres que está contenida dentro de una cadena.
            var course = "Curso de C# desde cero.";

            //Imprimir cadena desde la posición elegida hasta el final.
            Console.WriteLine("Subcadena: \n          {0}", course.Substring(9));
            Console.ReadLine();

            //Imprimir cadena desde una posición elegida, hasta otra posición elegida.
            Console.WriteLine("Subcadena 2: \n            {0}", course.Substring(0,11));
            Console.ReadLine();

            //Otro ejemplo:
            //Reemplazo objetos dentro de una cadena.
            //                  //Obj. a reemplazar, Obj. que lo reemplaza.
            var sub = course.Replace("desde cero.", ".netCore.");

            Console.Write("Caracteres reemplazados: \n                        {0}", sub);
            Console.ReadLine();

            //Quitar elementos de una cadena.
            //Selecciono el índice desde donde quiero quitar los elementos.
            Console.WriteLine(sub.Remove(5));
            Console.ReadLine();

            //Variante para remover caracteres desde... hasta... (funciona igual que en Substring).
            Console.WriteLine(course.Remove(5,12));
            Console.ReadLine();

            //ITERANDO LA CADENA DE TEXTO.

            //Busco la posición de un caracter dentro de la cadena de texto.
            //También puedo usar comillas simples para ingresar el caracter a buscar.
            var charPos = course.IndexOf("#");

            //Si quiero buscar una palabra, debo usar comillas dobles sí o sí. Ya que 
            // de lo contrario, interpretará a la misma como un caracter y provocará un error. 
            //De todas maneras, sólo se indica ña posición en la cual comienza la palabra.

            var wordInitPos = course.IndexOf("cero");

            Console.WriteLine($"Posición del caracter '#' dentro de la cadena 'course': {charPos}.");
            Console.ReadLine();

            Console.WriteLine($"La palabra 'cero' comienza en la posición: {wordInitPos}.");
            Console.ReadLine();

            //Convertir un string a un array de caracteres.
            var array = course.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"-{array[i]}-");
            }
            Console.ReadLine();

            //Comparación de strings. Usando variable auxiliar.
            //La función Equals, devuelve un valor booleano.
            var condition = person.Equals(course);

            Console.WriteLine($"\nEl string 'person' es igual a el string 'course': {condition}.");
            Console.ReadLine();

            //Obtengo cada caracter dentro del string e imprimo uno a uno por consola.
            foreach (var item in course)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
