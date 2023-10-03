using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_009__calcular_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int atual = DateTime.Now.Year;
            int nasc = 0;
            int idade = 0;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Digite seu ano de nascimento: ");
            nasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            if (nasc <= atual) {
                idade = atual - nasc;

                Console.WriteLine("Sua idade atual em {0} é de: {1} ano(s)", atual, idade);
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            } else {
                Console.WriteLine("Digite um ano de nascimento valido");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            }

            Console.ReadKey();
        }
    }
}
