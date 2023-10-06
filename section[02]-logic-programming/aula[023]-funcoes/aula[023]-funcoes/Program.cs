using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_023__funcoes
{
    internal class Program
    {
        // public = função que pode ser usada em todo lugar
        // void = função que retorna "null"
        public static void ShowDate() {
            string data = DateTime.Now.Date.ToString();
            Console.WriteLine(data);
        }
        public static void ShowMessage(string name){
            Console.WriteLine("Seja bem vindo {0}", name);
        }
        public static int ReturnAge(int nasc)
        {
            int atual = DateTime.Now.Year;
            int idade = atual - nasc;
            return idade;
        }
        public static double sum_numbers(double n1, double n2)
        {
            return n1 + n2;
        }
        static void Main(string[] args)
        {
            int idade = ReturnAge(2004);

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Função que mostra uma data");
            ShowDate();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("Função que mostra um nome");
            ShowMessage("Eduardo");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("Função que mostra idade: {0} anos", idade);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("Função que soma dois numeros: {0}", sum_numbers(10, 20));
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.ReadKey();
        }
    }
}
