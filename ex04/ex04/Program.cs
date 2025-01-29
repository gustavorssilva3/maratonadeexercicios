using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a raio do circulo: ");
            double raio = double.Parse(Console.ReadLine());

            const double PI = 3.14159;

            double area = PI * Math.Pow(raio, 2);

            Console.WriteLine("A área do círculo é: " + area);

            Console.ReadLine();
        }
    }
}
