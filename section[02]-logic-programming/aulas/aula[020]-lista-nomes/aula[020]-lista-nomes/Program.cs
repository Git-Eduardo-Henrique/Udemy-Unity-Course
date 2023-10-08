using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_020__lista_nomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lista = new string[5];
            int cont = 0;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            
            for (cont = 0; cont < 5; cont++){
                Console.Write("digite o {0}° nome: ", cont+1, cont);
                lista[cont] = Console.ReadLine();
            }
            
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            for (cont = 0; cont < 5; cont++) {
                Console.WriteLine("{0}° nome: {1}", cont, lista[cont]);
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
        }
    }
}
