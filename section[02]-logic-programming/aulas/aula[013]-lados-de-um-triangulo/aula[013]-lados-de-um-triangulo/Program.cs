using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_013__lados_de_um_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado1 = 0, lado2 = 0, lado3 = 0;
            bool cond1, cond2, cond3;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Digite o primeiro lado do triangulo: ");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo lado do triangulo: ");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro lado do triangulo: ");
            lado3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            cond1 = lado1 < lado2 + lado3;
            cond2 = lado2 < lado1 + lado3;
            cond3 = lado3 < lado1 + lado2;

            if (cond1 && cond2 && cond3) {
                Console.WriteLine("Esses lados podem formar um triangulo");
            } else {
                Console.WriteLine("Esses lados NÃO podem formar um triangulo");
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
        }
    }
}
