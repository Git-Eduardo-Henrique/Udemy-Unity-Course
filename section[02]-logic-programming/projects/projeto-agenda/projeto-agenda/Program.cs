using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_agenda
{
    internal class Program
    {
        // ref = faz com que possa alterar a variavel original com a passada
        public static void InsertData(ref string[] names, ref string[] emails, ref int index) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("digite o nome: ");
            string name = Console.ReadLine();

            Console.Write("digite o email: ");
            string email = Console.ReadLine();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            int pos = LocateItems(emails, index, email);

            if ( pos == -1) {
                index++;
                names[index] = name;
                emails[index] = email;
                Console.WriteLine("nome adicionado no index {0}: {1}", index, names[index]);
                Console.WriteLine("email adicionado no index {0}: {1}", index, emails[index]);
                
            } else {
                Console.WriteLine("email já cadastrado!!!!");
            }
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
        public static void ChangeData(string[] names, string[] emails, int index) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Digite o email do contato: ");
            string email = Console.ReadLine();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            int pos = LocateItems(emails, index, email);

            if (pos != -1)
            {
                Console.Write("digite o novo nome: ");
                names[index] = Console.ReadLine();

                Console.Write("digite o novo email: ");
                emails[index] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Email errado ou não cadastrado!");
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
            
        }
        public static void DeleteData(ref string[] names, ref string[] emails, ref int index) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Digite o email do contato: ");
            string email = Console.ReadLine();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            int pos = LocateItems(emails, index, email);

            if (pos != -1)
            {
                Console.WriteLine("index {0} deletado {1} | {2}", pos, names[pos], emails[pos]);

                for (int i = pos; i < index - 1; i++)
                {
                    names[i] = names[i + 1];
                    emails[i] = emails[i + 1];
                }

                index--;
            }
            else
            {
                Console.WriteLine("Email errado ou não cadastrado!");
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
        }

        public static int LocateItems(string[] emails, int cont_index, string email) {
            int pos = -1;

            for (int cont = 0; cont <= cont_index; cont++) { 
                if (emails[cont] == email) {
                    pos = cont;
                }
            }

            return pos;
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
            string email = "";

            string[] names = new string[200];
            string[] emails = new string[200];

            int opt = 1, cont_index = -1, pos = -1;

            backup.archive = "data.txt";
            //backup.RecoverData();

            while (opt != 0) {
                opt = ShowMenu();

                switch (opt) {
                    case 1:
                        ShowData(names, emails, cont_index);
                        break;

                    case 2:
                        InsertData(ref names, ref emails, ref cont_index);
                        break;

                    case 3:
                        ChangeData(names, emails, cont_index);
                        break;

                    case 4:
                        DeleteData(ref names, ref emails, ref cont_index);
                        break;

                    case 5:
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.Write("Digite o email do contato: ");
                        email = Console.ReadLine();
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                        pos = LocateItems(emails, cont_index, email);

                        if (pos != -1) {
                            Console.WriteLine("index: {0}\nnome: {1}\nemail: {2}", pos, names[pos], emails[pos]);
                        } else {
                            Console.WriteLine("Email errado ou não cadastrado!");
                        }

                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.ReadKey();

                        break;
                }
            }

            backup.UpdateData(ref names, ref emails, ref cont_index);
        }
    }
}
