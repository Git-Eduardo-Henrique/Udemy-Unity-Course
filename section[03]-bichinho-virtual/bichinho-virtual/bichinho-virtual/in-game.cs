using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace bichinho_virtual
{
    internal class in_game
    {
        public static void veri_name(ref string name) {
            if (name == "")
            {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                Console.Write("Olá meu novo dono :D, Qual o meu nome? ", name);
                name = Console.ReadLine();

                Console.Clear();
            }
        }
        public static void check_status(Random rand, int statu, string message) { 
            if (statu > 40 && statu < 60) {
                Console.WriteLine(message);
            }
        }
        public static string random_texts(Random rand, string[] texts) {
            return texts[rand.Next(texts.Length)];
        }
        public static int show_menu(Random rand, string name, int alimentado, int limpo, int feliz, string[] texts) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("_______________¶¶¶¶¶¶\r\n__________¶¶¶¶¶¶¶¶__¶¶\r\n_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶ ¶¶\r\n_¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n_¶¶ ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n___ ¶¶¶¶¶¶¶¶¶¶¶ [█]¶¶¶¶¶\r\n____¶¶¶¶¶ [█] ¶¶¶¶¶¶¶¶¶¶\r\n_____¶¶¶¶¶¶¶`▼´¶¶¶¶¶¶\r\n______¶¶¶¶¶¶¶·♥·¶¶¶¶¶\r\n__¤’¤’¤’¤’¤’¤’¤¶¶¶¶¶¶¤’¤’¤’¤’¤’¤’¤\r\n__¶¶¶¶¶’¤’¤’¤’¤’¤I T.’¤’¤’¤’¶¶¶¶¶¶\r\n¶¶¶¶¶¶¶¶¤’¤’¤’¤’¤’¤’¤’¤’¤¶¶¶¶¶¶¶¶\r\n¶¶____ ¶¶¶¶¶’¤’¤’¤’¤’¶¶¶¶¶____ ¶¶\r\n¶¶_____ ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶____¶¶\r\n_¶¶___¶¶¶¶¶________¶¶¶¶___¶¶\r\n__¶¶¶¶¶¶¶¶___________¶¶¶¶¶¶\r\n(♥)¤ª˜¨¨¨¨˜ª¤(♥)¤ª˜¨¨¨¨˜ª¤(♥) \r\n");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine(random_texts(rand, texts));

            check_status(rand, feliz, "Não vamos brincar?\nEstou um pouco entediado");
            check_status(rand, limpo, "Estou um pouco sujo\nUm banho seria muito bom");
            check_status(rand, alimentado, "Estou com fome\nPode me dar algo para comer?");

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("{0}, seu bichinho virtual :D", name);
            Console.WriteLine("nivel alimentado : {0}\nnivel limpo : {1}", alimentado, limpo);
            Console.WriteLine("nivel felicidade : {0}", feliz);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("Opções:\n[ 0 ] - sair\n[ 1 ] - brincar\n[ 2 ] - alimentar\n[ 3 ] - dar banho");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.Write("Sua opção: ");
            int opt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Clear();

            return opt;
        }

        public static void change_status(Random rand, ref int alimentado, ref int limpo, ref int feliz) { 
            int status_mudar = rand.Next(3);

            switch (status_mudar)
            {
                case 0:
                    alimentado -= rand.Next(20);
                    break;
                case 1:
                    limpo -= rand.Next(20);
                    break;
                case 2:
                    feliz -= rand.Next(20);
                    break;
            }
        }
    }
}
