using System;

namespace Tipos_de_métodos_en_C_sharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenidos.");
            Console.ReadLine();

            //MÉTODOS PRIVADOS QUE NO RETORNAN ELEMENTOS.
            privateMethod();

            //*Creo objeto de la clase 'Program' para invocar al método privado.
            //Se crea una nueva instancia de la clase 'Program'.
            var data = new Program();
            //Luego, a partir de esta nueva instancia, ejecuto el método.
            data.privateMethod2();

            //MÉTODOS PÚBLICOS Y QUE RETORNAN ALGÚN TIPO DE DATO.
            //También necesito crear un objeto de la clase 'Program' para poder 
            //invocar a este método.
            var data2 = new Program();
            data2.publicMethod();

            //Imprimo en consola el dato de tipo string devuelto por el método.
            //ReturnData es un método privado.
            var data3 = new Program();
            Console.WriteLine(data3.returnData());
            Console.ReadLine();

            //Otra forma, es creando una variable local.
            string name = data3.returnData();
            Console.WriteLine(name);
            Console.ReadLine();
        }
        //MODIFICADOR private Y MÉTODOS QUE NO RETORNAN ELEMENTOS.
        //Al colocar la palabra "private", le comunico al compilador de que el método
        //será PRIVADO, es decir, sólo se puede acceder y/o ejecutar desde la clase en
        //la cual ha sido declarado.
        //Este método, se puede invocar desde el Main, ya que, claramente, está dentro de la misma clase.
        //Al invocar al metodo privado desde el Main(static), debo convertir al mismo en static también,
        //por lo tanto añado la palabra 'static' entre 'private' y 'void'.
        private static void privateMethod() 
        {
            Console.Write("Este es un método privado, sólo se puede acceder\ndesde la clase en la que fue creado.");
            Console.ReadLine();
        }
        //Si no quiero agregar la palabra 'static' en el método privado.
        //Debo crear un objeto de la clase dentro del Main*
        private void privateMethod2() 
        {
            Console.WriteLine("Este es otro método privado, sólo se está probando otra forma de invocarlo.");
            Console.ReadLine();
        }

        //MODIFICADOR public Y MÉTODOS QUE RETORNAN UN TIPO DE DATO.
        //Al colocar la palabra "public" creo un método que podrá ser utilizado dentro de cualquier
        //clase que se ejecute en el programa.
        public void publicMethod() 
        {
            Console.WriteLine("Este es un método público, se puede acceder desde cualquier clase dentro del programa.");
            Console.ReadLine();
        }

        //Se crea un método privado que retornará un tipo de dato, en este caso, un string.
       private string returnData() 
        {
            return "Esta frase, se imprime invocando un método.\nEs devuelta por retorno.";
        }
    }
}
