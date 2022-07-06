using System;
using System.Linq;

namespace Aula
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.Write(TextoInvertido("estou estudando programação"));
            //Console.WriteLine(IsPalindromo2("ovo"));
            //Console.WriteLine(IsPalindromo2("bala"));
            //Console.WriteLine(CamelCase("Gosto de estudar  PROgramação "));

            //Console.WriteLine(CamelCase2("Gosto de estudar  PROgramação "));

            var valor1 = new Objeto(2);

            Funcao(valor1);

            Console.WriteLine(valor1.Valor);
        }

        public static void Funcao(Objeto valor)
        {
            valor.Valor = 4;
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

        public static bool IsPalindromo(string texto)
        {
            var isPalindromo = true;

            for (var i = 0; i < texto.Length / 2; i++)
            {
                if (texto[i] != texto[texto.Length - 1 - i])
                {
                    isPalindromo = false;
                    break;
                }
            }

            return isPalindromo;
        }

        public static bool IsPalindromo2(string texto)
        {
            return TextoInvertido(texto) == texto;
        }

        public static string CamelCase(string texto)
        {
            var camelCase = "";

            bool achouEspaco = false;
            for (var i = 0; i < texto.Length; i++)
            {
                camelCase = texto[i] != ' ' ? achouEspaco ? camelCase + Char.ToUpper(texto[i]) : camelCase + Char.ToLower(texto[i]) : camelCase;
                achouEspaco = texto[i] == ' ';
            }

            return camelCase;
        }

        public static string CamelCase2(string texto)
        {
            var camelCase = "";

            var vetor = texto.Split(" ");

            foreach (var palavra in vetor)
            {
                if (palavra != "")
                    camelCase += char.ToUpper(palavra[0]) + palavra.Substring(1).ToLower();
            }

            return camelCase;
        }

        //"Gosto      
        //de
        //estudar
        //
        //PROgramação
        //"
        //["Gosto", "de", "estudar", "PROgramação"]
    }
}
