using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_agenda
{
    internal class Program
    {
        public static void ShowData(string[] names, string[] emails) {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("nomes: {0}\nemails: {1}", names, emails);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
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

            int opt = 1;

            while (opt != 0) {
                opt = ShowMenu();

                switch (opt) {
                    case 1:
                        ShowData(names, emails);
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
