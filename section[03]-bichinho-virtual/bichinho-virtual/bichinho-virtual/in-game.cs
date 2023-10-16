using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bichinho_virtual
{
    internal class in_game
    {
        public static int show_menu(string name, int alimentado, int limpo, int feliz) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("{0}, seu bichinho virtual :D", name);
            Console.WriteLine("nivel alimentado : {0}\nnivel limpo : {1}", alimentado, limpo);
            Console.WriteLine("nivel felicidade : {0}", feliz);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Opções: [ 0 ] - sair | [ 1 ] - brincar");
            int opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            return opt;
        }
    }
}
