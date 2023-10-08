using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_023__3__text_editor
{
    internal class Program
    {
        public static void WhiteText(string arquivo, string text, bool transcrever) {
            try {
                StreamWriter gravar = new StreamWriter(arquivo, transcrever);
                gravar.WriteLine(text);
                gravar.Close();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            
        }

        public static void ShowText(string arquivo) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            string line = "";

            try {
                StreamReader text = new StreamReader(arquivo);

                line = text.ReadLine();

                // quando não tiver linhas para ler ele irá retornar null
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = text.ReadLine();
                }

                text.Close();

            } catch (Exception ex) {
                Console.WriteLine("Erro: Arquivo não existe ou está em branco");
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
        }

        public static int ShowMenu() {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("[ 0 ] - sair\n[ 1 ] - abrir/criar arquivo\n[ 2 ] - Exibir texto");
            Console.WriteLine("[ 3 ] - sobrescrever texto\n[ 4 ] - adicionar novo texto");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.Write("qual sua opção? ");
            int opt = Convert.ToInt32(Console.ReadLine());

            return opt;
        }
        static void Main(string[] args)
        {
            int opt = 1;

            string arquivo = "", text = "";

            while (opt != 0) {
                opt = ShowMenu();
                Console.Clear();

                switch (opt) {
                    case 1:
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.Write("digite o nome do arquivo: ");
                        arquivo = Console.ReadLine();

                        break;

                    case 2:
                        ShowText(arquivo);
                        break;
                    case 3:
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                        Console.Write("digite o seu texto: ");
                        text = Console.ReadLine();

                        WhiteText(arquivo, text, false);
                        ShowText(arquivo);
                        break;

                    case 4:
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                        Console.Write("digite o seu texto: ");
                        text = Console.ReadLine();

                        WhiteText(arquivo, text, true);
                        ShowText(arquivo);
                        break;
                }
            }
        }
    }
}