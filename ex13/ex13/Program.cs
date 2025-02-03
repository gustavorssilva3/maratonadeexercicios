using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("13-) Crie um sistema simples de cadastro de produto para uma loja.");
            Console.WriteLine("• Declare variáveis para o nome do produto (string), preço (double) e quantidade (int).");
            Console.WriteLine("• Solicite ao usuário as informações e armazene os valores nas variáveis.");
            Console.WriteLine("• Exiba os dados do produto no final.");
            Console.WriteLine("• Caso o estoque seja zero, mostre uma mensagem de \"Produto fora de estoque\".\n");

            Console.Write("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do Produto:");
            Console.WriteLine($"Nome: {nomeProduto}");
            Console.WriteLine($"Preço: R$ {preco:F2}");
            Console.WriteLine($"Quantidade em estoque: {quantidade}");

            if (quantidade == 0)
            {
                Console.WriteLine("Produto fora de estoque.");
            }
            Console.ReadLine();
        }
    }
}
