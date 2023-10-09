using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_agenda
{
    internal class Program
    {
        public static void InsertData(string name, string[] names, string email, string[] emails, int index) {
            names[index] = name;
            emails[index] = email;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("nome adicionado no index {0}: {1}", index, names[index]);
            Console.WriteLine("email adicionado no index {0}: {1}", index, emails[index]);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
        }
        public static void ShowData(string[] names, string[] emails, int cont_index) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            if (cont_index >= 0) {

                for (int cont = 0; cont <= cont_index; cont++)
                {
                    Console.WriteLine("index: {0}", cont);
                    Console.WriteLine("nome: {0}\nemail: {1}", names[cont], emails[cont]);
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                }
            } else {
                Console.WriteLine("Nenhum dado foi adicionado!");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            }
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

            Console.Clear();

            return opt;
        }
        static void Main(string[] args)
        {
            string name = "";
            string email = "";

            string[] names = new string[200];
            string[] emails = new string[200];

            int opt = 1, cont_index = -1;

            while (opt != 0) {
                opt = ShowMenu();

                switch (opt) {
                    case 1:
                        ShowData(names, emails, cont_index);
                        break;
                    case 2:
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.Write("digite o nome: ");
                        name = Console.ReadLine();

                        Console.Write("digite o email: ");
                        email = Console.ReadLine();
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                        cont_index++;

                        InsertData(name, names, email, emails, cont_index);
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
