using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_008__divisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double resto = 0;
            double quociente = 0;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.Write("digite o primeiro numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite o segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            resto = num1 % num2;
            quociente = num1 / num2;

            Console.WriteLine("{0} / {1} = {2}", num1, num2, quociente);
            Console.WriteLine("resto: {0}", resto);

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
        }
    }
}
