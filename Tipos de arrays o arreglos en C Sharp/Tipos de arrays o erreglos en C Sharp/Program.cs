using System;

namespace Tipos_de_arrays_o_arreglos_en_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAY DE TIPO string.

            string[] names = new string[5];

            //Almaceno datos en el array.
            names[0] = "Ezequiel";
            names[1] = "Juan Pablo";
            names[2] = "Lucas";
            names[3] = "Nicolás";
            names[4] = "Occhipinti";

            //Creo otro array inicializado con los datos.
            //De esta manera, puedo poer la cantidad de datos que quiera.
                                   //pos 0   pos 1    pos2     pos 3      pos 4 ...  ...  ...
            string[] vegetables = { "Papa","Batata","Choclo","Zapallo","Zanahoria" };

            //Imprimo el largo de la cadena.
            Console.WriteLine("Largo del array: {0}", names.Length);
            Console.ReadLine();

            //Imprimo una posición del array.
            Console.WriteLine("Último elemento del array: {0}", names[4]);
            Console.ReadLine();

            //Imprimo todos los elemntos del array.
            Console.WriteLine($"El team estrella: \n {names[0]} \n {names[1]} \n {names[2]} \n {names[3]} \nArtista invitado: \n The great {names[4]}");
            Console.ReadLine();

            Console.WriteLine($"Verdulería 'PELÁ EL NABO'.\n{vegetables[0]}\n{vegetables[1]}\n{vegetables[2]}\n{vegetables[3]}\n{vegetables[4]}\nMANDALE FRUTA!!!");
            Console.ReadLine();

            //ARRAY DE TIPO int.

            int[] numbers = new int[5];

            //Almaceno datos.
            numbers[0] = 45;
            numbers[1] = 69;
            numbers[2] = 21;
            numbers[3] = 77;
            numbers[4] = 78;

            Console.WriteLine("Este nombre: " + names[0] + " " + "gusta disfrutar de las buenas " + numbers[2]);
            Console.ReadLine();

            //Creo array y lo inicializo con datos por defecto.

            int[] prices = { 30, 40, 50, 50, 40};

            //Imprimo el largo de la cadena.
            Console.WriteLine("Largo del array: {0}", prices.Length);
            Console.ReadLine();

            //Imprimo una posición del array.
            Console.WriteLine("Tercer elemento del array: {0}", prices[2]);
            Console.ReadLine();

            //ARREGLOS MULTIDIMENSIONALES.

            //ARRAY BIDIMENSIONAL.
            //Utilizo la coma para indicar que voy a crear un array con columnas y filas.
            //En este caso, voy a contener 5 filas y 2 columnas.
            //Lo inicializo directamente con las filas y columnas, ATENCIÓN A LAS LLAVES!!!
            double[,] rareNumbers = new double[5, 2] { { 6,3.5 },{ 6.5, 4 },{ 7, 4.5 },{ 7.5, 5 },{ 8, 5.5 } };

            //Imprimo matriz con 1ra y última fila y los números enteros.
            Console.WriteLine($"Resultado matriz:\n{rareNumbers[0,0]} {rareNumbers[0,1]}\n" +
                $"    {rareNumbers[1,1]}\n{rareNumbers[2,0]}\n    {rareNumbers[3,1]}\n" +
                $"{rareNumbers[4,0]} {rareNumbers[4,1]}");
            Console.ReadLine();

            //ARRAY TRIDIMENSIONAL.
            //Utilizo las comas para indicar la creación de un array multidimensional.
            //En este caso, habrá 2 filas, que contendrán 2 columnas que contendrán 3 datos...
            //Lo inicializamos de entrada.
            //Tengo las llaves necesarias para inicializar el array, dentro las llaves para crear
            //las filas, dentro las que crean las columnas y, a su vez, los datos dentro de cada posición.
            double[,,] threeDimensions = new double[2, 2, 3] { { { 1.5, 2.5, 3.5 } , { 4, 5, 6 } },{ { 4.5, 5.5, 6.5 } , { 10, 11, 12 } } };

            //Imprimo algunos elementos del array.
            Console.WriteLine("Algunos elementos del array: {0} ; {1} ; {2} ; {3} .-",threeDimensions[0,1,2],
                threeDimensions[1,0,2],threeDimensions[0,0,0],threeDimensions[1,1,1]);
            Console.ReadLine();
        }
    }
}
