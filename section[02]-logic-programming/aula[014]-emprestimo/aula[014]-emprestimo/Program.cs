using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_014__emprestimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool empregado = false;
            bool fiador = false;
            string entrada = "";

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Você possui um fiador? (S/N): ");
            entrada = Console.ReadLine();

            if (entrada == "S") {
                fiador = true;
            }

            Console.Write("Você está empregado? (S/N): ");
            entrada = Console.ReadLine();

            if (entrada == "S")
            {
                empregado = true;
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            if (empregado || fiador) {
                Console.WriteLine("Seu imprestimo foi APROVADO parabens!!!");
            } else {
                Console.WriteLine("Seu imprestimo foi NEGADO!!!");
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
        }
    }
}
