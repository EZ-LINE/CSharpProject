using System;

namespace Tipos_de_métodos_en_C_sharp_p_2
{
    class Program
    {
        //Creación de una variable global. Al ser creada dentro de la clase, la misma 
        //podrá ser utilizada dentro de cualquiera de los métodos dentro de la clase.
        //Por buena práctica, usamos el modificador 'private', lo cual permitirá que 
        //la variable pueda ser utilizada dentro de cualquier método dentro de la clase,
        //pero no fuera de la misma.
                        //private String names = "Andrés";

        //Variables globales y método que retorna datos de tipo string.
        private String text;
        private String watchUpper = " ";
        private String watchLower = " ";
        private int n;
        private string[] upperCase;
        private string[] lowerCase;
        private string[] tempUc;
        private string[] tempLc;

        //Creamos un método constructor de la clase, para inicializar las variables dentro de la misma.
        //Este método, se ejecutará cada vez que se invoque a la clase.
        //Se le pasa al método como parámetro el mismo nombre que el elemento 'text' para justificar
        //el uso de la palabra reservada 'this'.
        //Si no se quiere usar la palabra 'this', sólo hace falta cambiar el n ombre del parámetro o del elemento.
        //Los métodos constructores siempre se crean con la palabra 'public', estos métodos NO retornan nada.
        public Program(String text) 
        {
            this.text = text;
            n = text.Length;
            upperCase = new string[n];
            lowerCase = new string[n];
            tempUc = new string[n];
            tempLc = new string[n];
        }

        static void Main()
        {
            //Creamos una variable local, es decir, una variable a ser utilizada dentro del
            //método en el que fue creada.
                          //String name = "Ezequiel";

            //Variables globales y método que retorna datos de tipo string.

            Console.WriteLine("Por favor, ingrese un texto: ");
            string userText = Console.ReadLine();
            var data = new Program(userText);

            Console.Write($"El texto ingresado, cuenta con las siguientes:\n" +
                $"Letras mayúsculas: {data.capitalLetters()}.\n" +
                $"Letras minúsculas: {data.smallLetters()}.");
            Console.ReadLine();
        }

        private String capitalLetters() 
        {
            for (int i = 0; i < n; i++)
            {
                //'IsUpper' indica si un caracter Unicode está categorizado como una letra mayúscula.
                if (Char.IsUpper(text[i]))
                {
                    tempUc[i] = Convert.ToString(text[i]);
                }
            }

            for (int i = 0; i < tempUc.Length; i++)
            {
                if (tempUc[i] != null)
                {
                    upperCase[i] = tempUc[i];
                    watchUpper = $"{watchUpper},{upperCase[i]}";
                }
            }

            return watchUpper;
        }

        private String smallLetters() 
        {
            for (int i = 0; i < n; i++)
            {
                //'IsLower' indica si un caracter Unicode está categorizado como una letra minúscula.
                if (Char.IsLower(text[i]))
                {
                    tempLc[i] = Convert.ToString(text[i]);
                }
            }

            for (int i = 0; i < tempLc.Length; i++)
            {
                if (tempLc[i] != null)
                {
                    lowerCase[i] = tempLc[i];
                    watchLower = $"{watchLower},{lowerCase[i]}";
                }
            }

            return watchLower;
        }
    }
}
