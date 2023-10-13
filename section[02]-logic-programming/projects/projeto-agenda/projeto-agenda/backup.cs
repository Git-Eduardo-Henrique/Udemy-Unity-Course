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
        public static void RecoverData() {
            StreamReader sr = new StreamReader(archive);

            string line = sr.ReadLine();

            while (line != null) {

                line = sr.ReadLine();
            }

        }

        public static void UpdateData(ref string[] nomes, ref string[] emails, ref int index) {
            StreamWriter writer = new StreamWriter(archive);

            for (int cont = 0; cont <= index; cont++) {
                writer.WriteLine("{0} - {1}", nomes[cont], emails[cont]);
            }

            writer.Close();
        }
    }
}
