using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_015__veri_eleitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.Write("Qual sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("Sua idade é de {0} anos.", idade);

            if (idade < 16) {
                Console.WriteLine("Você NÃO pode votar!!!");
            } else if ((idade >= 16 && idade < 18) || idade > 65) {
                Console.WriteLine("Seu voto é OPCIONAL!!!");
            } else {
                Console.WriteLine("Seu voto é OBRIGATORIO!!!");
            } 

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
        }
    }
}
