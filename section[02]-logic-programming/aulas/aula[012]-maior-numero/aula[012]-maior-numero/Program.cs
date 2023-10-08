using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_012__maior_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, maior = 0;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("digite o primeiro numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            maior = n1;

            Console.Write("digite o segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n2 > maior) {
                maior = n2;
            }

            Console.Write("digite o terceiro numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n3 > maior)
            {
                maior = n3;
            }

            Console.Write("digite o quarto numero: ");
            n4 = Convert.ToInt32(Console.ReadLine());

            if (n4 > maior)
            {
                maior = n4;
            }

            Console.Write("digite o quarto numero: ");
            n5 = Convert.ToInt32(Console.ReadLine());

            if (n5 > maior)
            {
                maior = n5;
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("o maior numero digitado foi: {0}", maior);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.ReadKey();
        }
    }
}
