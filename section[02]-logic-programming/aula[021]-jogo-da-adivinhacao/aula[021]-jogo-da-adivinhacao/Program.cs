using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_021__jogo_da_adivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt = 1, cont = 0, index;
            string resp = "";
            Random rand = new Random();

            string[] lista_perg = {
                "Oque tem capa mas não voa.",
                "Sem sair do seu cantinho, é capaz de viajar ao redor do mundo.",
                "É feito de água, mas se for colocado dentro da água morrerá."
            };

            string[] lista_resp = {
                "Livro",
                "Selo",
                "Gelo"
            };

            while (opt != 0) {
                index = rand.Next(0, lista_perg.Length);

                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("{0}", lista_perg[index]);
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                Console.Write("Digite sua reposta: ");
                resp = Console.ReadLine();

                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.Clear();

                if (resp.ToUpper() == lista_resp[index].ToUpper()) {
                    Console.WriteLine("Resposta Correta!!!!");
                    cont++;
                } else {
                    Console.WriteLine("Resposta Errada!!!!");
                }

                Console.Write("digite 0 para sair? ");
                opt = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("voce acertou {0} vezes!!!", cont);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
        }
    }
}
