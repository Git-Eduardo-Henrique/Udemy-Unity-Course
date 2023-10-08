using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_007__area_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tipo o float porem em 64bits
            double area = 0;
            double t_base = 0;
            double t_altura = 0;

            string entradas;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("calcular area de um triangulo");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.Write("digite a base: ");
            entradas = Console.ReadLine();
            // converte string para double ( float )
            t_base = Convert.ToDouble(entradas);

            Console.Write("digite a altura: ");
            entradas = Console.ReadLine();
            // converte string para double ( float )
            t_altura = Convert.ToDouble(entradas);

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            // calcular a area
            area = t_base * t_altura / 2;

            Console.WriteLine("um triangulo de base {0} e altura {1} tem a area de {2}", t_base, t_altura, area);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
        }
    }
}
