using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Char_e_Texto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            //character
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2020;
            Console.WriteLine(titulo);

            Console.ReadLine();

        }
    }
}
