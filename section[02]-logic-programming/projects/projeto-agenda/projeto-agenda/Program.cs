using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_agenda
{
    internal class Program
    {
        public static void ShowData(string[] names, string[] emails, int cont_index) {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            for (int cont = 0; cont <= cont_index; cont++)
            {
                Console.WriteLine("index: {0}", cont);
                Console.WriteLine("nome: {0}\nemail: {1}", names[cont], emails[cont]);
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
            Console.ReadKey();
        }
        public static int ShowMenu() {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("[ 0 ] - Sair\n[ 1 ] - Exibir dados\n[ 2 ] - Adicionar dados");
            Console.WriteLine("[ 3 ] - Alterar dados\n[ 4 ] - Excluir dados\n[ 5 ] - localizar dados");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("sua opção: ");
            int opt = Convert.ToInt32(Console.ReadLine());

            return opt;
        }
        static void Main(string[] args)
        {
            string[] names = new string[200];
            string[] emails = new string[200];

            int opt = 1, cont_index = 0;

            names[0] = "Eduardo Henrique";
            emails[0] = "eduardosus@gmail.com";

            while (opt != 0) {
                opt = ShowMenu();

                switch (opt) {
                    case 1:
                        ShowData(names, emails, cont_index);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
            }

        }
    }
}
