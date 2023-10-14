using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_agenda
{
    internal class backup
    {
        public static string archive = "data.txt";
        public static void RecoverData(ref string[] nomes, ref string[] emails, ref int index) {
            
            StreamReader sr = new StreamReader(archive);

            index = 0;

            string line = sr.ReadLine();

            while (line != null) {
                int pos = line.IndexOf("-");
                nomes[index] = line.Substring(0, pos);
                emails[index] = line.Substring(pos + 1);
                index++;

                 line = sr.ReadLine();
                }

            sr.Close();
        }
        public static void UpdateData(ref string[] nomes, ref string[] emails, ref int index) {
            if (index != 0) {
                StreamWriter writer = new StreamWriter(archive);

                for (int cont = 0; cont <= index; cont++)
                {
                    writer.WriteLine("{0}-{1}", nomes[cont], emails[cont]);
                }

                writer.Close();
            }
        }
    }
}
