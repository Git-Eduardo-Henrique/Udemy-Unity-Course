using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_004__variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            text = "testando variaveis";

            Console.WriteLine(text);

            int num1;
            int num2;

            num1 = 2;
            num2 = 3;

            Console.WriteLine(num1 + " > " + num2 + " = " + (num1 > num2));
            Console.WriteLine(num1 + " < " + num2 + " = " + (num1 < num2));
            Console.WriteLine(num1 + " != " + num2 + " = " + (num1 != num2));
            Console.WriteLine(num1 + " == " + num2 + " = " + (num1 == num2));
        }
    }
}
