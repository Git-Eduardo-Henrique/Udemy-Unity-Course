using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_006__tabuada_melhorada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int numero;

            Console.Write("digite um numero para calcular sua tabuada: ");
            entrada = Console.ReadLine();
            
            // converte um valor para um int de 32bits
            numero = Convert.ToInt32(entrada);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Tabuada do {0}", numero);
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("{0} x 01 = {1}", numero, (numero * 1));
            Console.WriteLine("{0} x 02 = {1}", numero, (numero * 2));
            Console.WriteLine("{0} x 03 = {1}", numero, (numero * 3));
            Console.WriteLine("{0} x 04 = {1}", numero, (numero * 4));
            Console.WriteLine("{0} x 05 = {1}", numero, (numero * 5));
            Console.WriteLine("{0} x 06 = {1}", numero, (numero * 6));
            Console.WriteLine("{0} x 07 = {1}", numero, (numero * 7));
            Console.WriteLine("{0} x 08 = {1}", numero, (numero * 8));
            Console.WriteLine("{0} x 09 = {1}", numero, (numero * 9));
            Console.WriteLine("{0} x 10 = {1}", numero, (numero * 10));

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.ReadKey();
        }
    }
}
