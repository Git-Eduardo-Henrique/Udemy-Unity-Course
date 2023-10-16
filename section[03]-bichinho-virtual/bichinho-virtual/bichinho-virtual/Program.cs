using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bichinho_virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int alimentado = 100;
            int limpeza = 100;
            int felicidade = 100;

            int opt = -1;

            if ( name == "") {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                Console.Write("Olá meu novo dono :D, Qual o meu nome? ", name);
                name = Console.ReadLine();

                Console.Clear();
            }
            
            while (true) {
                opt = in_game.show_menu(name, alimentado, limpeza, felicidade);

                switch (opt) {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }
        }
    }
}
