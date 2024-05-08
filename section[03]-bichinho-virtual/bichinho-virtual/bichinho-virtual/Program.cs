using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// para coleta de dados
using System.IO;

namespace bichinho_virtual
{
    internal class Program
    {
        public static void SavePet( string file, string name, int alimentado, int limpeza, int felicidade )
        {
            string file_content = name + Environment.NewLine;
            file_content += alimentado + Environment.NewLine;
            file_content += limpeza + Environment.NewLine;
            file_content += felicidade + Environment.NewLine;

            // grava todo o texto e criar arquivo se não tiver
            File.WriteAllText(file, file_content);
        }
        static void Main(string[] args)
        {
            string name = "";

            string[] texts = new string[5];
            texts[0] = "Olá dono, fiquei muito feliz e você estar aqui hoje!!!";
            texts[1] = "Hoje foi muito legal, só não liga para a janela quebrada ;)";
            texts[2] = "Que legal você ter aparecido aqui hoje";
            texts[3] = "Adorei brincar hoje, pena que você não viu";
            texts[4] = "Posso ir na rua? não? :(";

            in_game.veri_name(ref name);

            int alimentado = 100, limpeza = 100, felicidade = 100;

            // Coleta o caminho da pasta do projeto
            string dir = Environment.CurrentDirectory + "\\";

            string file = dir + name + ".txt";
            if (File.Exists(file))
            {
                string[] dados = File.ReadAllLines(file);
                alimentado = Convert.ToInt32(dados[1]);
                limpeza = Convert.ToInt32(dados[2]);
                felicidade = Convert.ToInt32(dados[3]);

                if(alimentado <= 0 || limpeza <= 0 || felicidade <= 0) {
                    Console.WriteLine("seu bichinho está fraco!!!! vamos recuperalo");
                    alimentado = 100;
                    limpeza = 100;
                    felicidade = 100;
                }
            } else {
                Console.WriteLine(file);
                Console.WriteLine("Nenhum Save desse Pet encontrado\nUm novo save sera criado ao sair");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            }

            int opt = -1;
            bool rodando = true;

            Random rand = new Random();

            while (rodando) {
                opt = in_game.show_menu(rand, name, alimentado, limpeza, felicidade, texts);

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
                if (alimentado <= 0 || limpeza <= 0 || felicidade <= 0) {
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("Você não cuidou de mim..... porque dono?");
                    Console.WriteLine("=-= {0} irá ser cuidado pelo assistente virtual... =-=", name);

                    Console.ReadKey();

                    rodando = false;
                }
            }

            SavePet(file, name, alimentado, limpeza, felicidade);
        }
    }
}
