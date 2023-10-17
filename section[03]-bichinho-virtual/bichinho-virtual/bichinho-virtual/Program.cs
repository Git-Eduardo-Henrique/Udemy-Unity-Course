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
            int alimentado = 100, limpeza = 100, felicidade = 100, opt = -1;
            bool rodando = true;

            Random rand = new Random();

            in_game.veri_name(ref name);

            while (rodando) {
                opt = in_game.show_menu(rand, name, alimentado, limpeza, felicidade);

                in_game.change_status(rand, ref alimentado, ref limpeza, ref felicidade);

                switch (opt) {
                    case 0:
                        rodando = false;
                        break;
                    case 1:
                        felicidade += rand.Next(20);
                        if (felicidade > 100) {
                            felicidade = 100;
                        }
                        break;
                    case 2:
                        alimentado += rand.Next(20);
                        if (alimentado > 100) {
                            alimentado = 100;
                        }
                        break;
                    case 3:
                        limpeza += rand.Next(20);
                        if (limpeza > 100) {
                            limpeza = 100;
                        }
                        break;
                }
            }
        }
    }
}
