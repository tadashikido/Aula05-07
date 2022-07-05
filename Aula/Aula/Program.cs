using System;

namespace Aula
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write(TextoInvertido("estou estudando programação"));
        }

        public static string TextoInvertido(string texto)
        {
            var invertido = "";

            //for (var i = texto.Length - 1; i >= 0; i--)
            //{
            //    invertido = invertido + texto[i];
            //}

            var j = texto.Length - 1;
            while (j >= 0)
            {
                invertido = invertido + texto[j];
                j--;
            }
            //var invertido = texto[8] + texto[7] + texto[6];

            return invertido;
        }
    }
}
