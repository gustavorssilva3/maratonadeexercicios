using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10-) Crie um sistema para registrar o nome completo dos clientes. O sistema deve armazenar o nome e o sobrenome separadamente, mas exibí-los de forma concatenada.");

            Console.WriteLine("Digite o primeiro nome: ");
            string primeiroNome = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine($"\nNome completo do cliente: {primeiroNome} {sobrenome}");

            Console.ReadLine();
        }
    }
}
