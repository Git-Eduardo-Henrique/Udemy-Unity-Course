using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_010__par_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Digite um numero inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0){
                Console.WriteLine("o numero {0} é PAR", num);
            } else {
                Console.WriteLine("o numero {0} é IMPAR", num);
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.ReadKey();
        }
    }
}
