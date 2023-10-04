using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_019__numero_primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, cont = 1, dividiu = 0, exit = 1;

            while (exit != 0) {
                dividiu = 0;
          
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                Console.Write("Digite um numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                for (cont = 1; cont <= num; cont++) {
                    if (num % cont == 0)
                      {
                          dividiu++;
                      }
                }

                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                if (dividiu == 2) {
                    Console.WriteLine("O numero {0} É PRIMO!", num);
                }
                else {
                    Console.WriteLine("O numero {0} NÃO É PRIMO!", num);
                }
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.ReadKey();

                Console.Write("Digite 0 para sair: ");
                exit = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
            }
        }
    }
}
