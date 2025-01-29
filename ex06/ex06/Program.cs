using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cidades = { "São Paulo", "Rio de Janeiro", "Belo Horizonte", "Curitiba", "Natal" };

            foreach (string cidade in cidades)
            {
                Console.WriteLine(cidade);
            }

            Console.ReadLine();
        }
    }
}
