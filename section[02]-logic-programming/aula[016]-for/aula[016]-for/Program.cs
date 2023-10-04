using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_016__for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, cont = 0;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.Write("Digite um numero para ver sua tabuada: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            for (cont = 1; cont <= 10; cont++) {
                Console.WriteLine("{0} x {1} = {2}", num, cont, (num * cont));
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
        }
    }
}
