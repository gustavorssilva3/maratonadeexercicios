using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("11-) Utilize um loop for para gerar e exibir a tabuada de multiplicação para o número 7, de 1 a 10.");
            Console.WriteLine("• No for, para cada valor de 1 a 10, exiba o resultado da multiplicação do número 7 pelo valor correspondente.\n");

            int numero = 7;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
            Console.ReadLine();
        }
    }
}
