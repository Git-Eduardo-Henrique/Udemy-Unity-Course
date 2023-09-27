using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_005__imputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.Write("qual o seu nome: ");
            nome = Console.ReadLine();

            // {0} exibe a variavel, 0 é o indice
            Console.WriteLine("Olá {0} Seje bem vindo(a)!!", nome);
            Console.ReadKey();
        }
    }
}