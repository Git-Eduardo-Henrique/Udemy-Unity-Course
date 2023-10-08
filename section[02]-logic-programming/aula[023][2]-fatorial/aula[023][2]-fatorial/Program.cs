using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_023__2__fatorial
{
    internal class Program
    {
        public static int ExibirMenu() {
            int opt;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("[ 1 ] - Dividir numero inteiro");
            Console.WriteLine("[ 2 ] - Verificar numero primo");
            Console.WriteLine("[ 3 ] - Calcular fatorial");
            Console.WriteLine("[ 0 ] - Sair");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Qual sua opção: ");
            opt = Convert.ToInt32(Console.ReadLine());

            return opt;
        }
        public static void DividirNumeros(int num1, int num2) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("resto da divisão: {0}", num1 % num2);
        }

        public static void VeriPrimo(int num) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            int dividiu = 0;

            for (int cont = 1; cont <= num; cont++) { 
                if (num % cont == 0) {
                    dividiu++;
                }
            }

            if (dividiu == 2) {
                Console.WriteLine("O numero {0} é Primo", num);
            } else {
                Console.WriteLine("O numero {0} NÃO É Primo", num);
            }
        }

        public static void CalcFatorial(int num)
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("{0}! = ", num);

            int mult = num;

            for (int cont = num - 1; cont >= 1 ; cont--) {
                Console.Write("{0} x ", cont);
                mult *= cont;
            }
            Console.WriteLine("= {0}", mult);
        }

        static void Main(string[] args)
        {
            int opt = 1;

            while (opt != 0) {
                int num1, num2;
                Console.Clear();

                opt = ExibirMenu();

                Console.Clear();
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                if (opt == 1)
                {
                    Console.Write("Digite o primeiro numero: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o segundo numero: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    DividirNumeros(num1, num2);
                    Console.ReadKey();
                }
                else if (opt == 2)
                {
                    Console.Write("Digite o numero: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    VeriPrimo(num1);
                    Console.ReadKey();
                }
                else if (opt == 3)
                {
                    Console.Write("Digite o numero: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    CalcFatorial(num1);
                    Console.ReadKey();
                }
            }
            Console.ReadKey();
        }
    }
}
