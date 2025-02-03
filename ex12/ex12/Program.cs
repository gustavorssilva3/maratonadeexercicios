using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("12-) Crie um sistema de vendas em que uma loja oferece um desconto para compras acima de um certo valor.");
            Console.WriteLine("• Declare uma variável do tipo double chamada valorCompra e inicialize-a com um valor qualquer.");
            Console.WriteLine("• Se o valor da compra for superior a R$ 200,00, aplique um desconto de 10% e exiba no console a mensagem \"Desconto de 10% aplicado!\".");
            Console.WriteLine("• Se o valor for R$ 200,00 ou menos, exiba a mensagem \"Adicione mais itens ao carrinho para ganhar um desconto de 10%.\".\n");

            double valorCompra = 210.00;

            Console.WriteLine($"Valor original: R$ {valorCompra:F2}");

            if (valorCompra > 200)
            {
                double desconto = valorCompra * 0.10;
                double valorFinal = valorCompra - desconto;
                Console.WriteLine("Desconto de 10% aplicado!");
                Console.WriteLine($"Desconto: R$ {desconto:F2}");
                Console.WriteLine($"Valor final com desconto: R$ {valorFinal:F2}");
            }
            else
            {
                Console.WriteLine("Adicione mais itens ao carrinho para ganhar um desconto de 10%.");
            }
            Console.ReadLine();
        }
    }
}
