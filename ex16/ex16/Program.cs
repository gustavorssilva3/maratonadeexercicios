using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("16-) Crie um sistema de vendas em que o valor da compra determina o desconto aplicado.");
            Console.WriteLine("O sistema deve aplicar um desconto progressivo dependendo do valor total da compra:");
            Console.WriteLine("• Se o total for até R$ 100,00, o desconto é 5%.");
            Console.WriteLine("• Se o total for entre R$ 100,01 e R$ 300,00, o desconto é 10%.");
            Console.WriteLine("• Se o total for acima de R$ 300,00, o desconto é 15%.");
            Console.WriteLine("• Calcule o valor com o desconto e exiba o valor final com uma mensagem indicando o desconto aplicado.\n");

            Console.Write("Digite o valor total da compra: ");
            double valorCompra = double.Parse(Console.ReadLine());

            double desconto = 0;

            if (valorCompra <= 100.00)
            {
                desconto = 0.05;
                Console.WriteLine("Desconto de 5% aplicado.");
            }
            else if (valorCompra <= 300.00)
            {
                desconto = 0.10;
                Console.WriteLine("Desconto de 10% aplicado.");
            }
            else
            {
                desconto = 0.15;
                Console.WriteLine("Desconto de 15% aplicado.");
            }

            double valorFinal = valorCompra - (valorCompra * desconto);

            Console.WriteLine($"Valor final após desconto: R$ {valorFinal:F2}");
            Console.ReadLine();
        }
    }
}
