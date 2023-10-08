using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_018__while_tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, cont = 1;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.Write("Digite um numero para ver sua tabuada: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            while (cont <= 10) {
                Console.WriteLine("{0} x {1} = {2}", num, cont, (num * cont));
                cont++;
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
        }
    }
}
