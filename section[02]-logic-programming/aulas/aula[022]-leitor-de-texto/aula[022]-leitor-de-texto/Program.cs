using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// biblioteca usada para manipular o texto
using System.IO;

namespace aula_022__leitor_de_texto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arquivo = args[0];
            string line = "";

            StreamReader sr = new StreamReader(arquivo);

            line = sr.ReadLine();

            // quando não tiver linhas para ler ele irá retornar null
            while (line != null) {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();
            Console.ReadKey();
        }
    }
}
