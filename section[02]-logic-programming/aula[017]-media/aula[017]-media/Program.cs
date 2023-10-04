using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_017__media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int user_num = 0, cont = 0;
            double num = 0, sum = 0, media = 0;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.Write("Quantos numeros deseja informar? ");
            user_num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            for (cont = 1; cont <= user_num; cont++) {
                Console.Write("Digite o {0}° numero: ", cont);
                num = Convert.ToDouble(Console.ReadLine());

                sum += num;
            }

            media = sum / user_num;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("A media destes {0} numeros é: {1}", user_num, media);

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
        }
    }
}
