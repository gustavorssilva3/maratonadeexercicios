using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14-) Crie uma calculadora simples que possa realizar as quatro operações matemáticas básicas: soma, subtração, multiplicação e divisão.");
            Console.WriteLine("O programa deve perguntar ao usuário qual operação ele deseja realizar e em seguida pedir dois números.");
            Console.WriteLine("• Declare variáveis para armazenar os dois números (double).");
            Console.WriteLine("• Utilize a estrutura switch para realizar a operação escolhida pelo usuário.");
            Console.WriteLine("• Exiba o resultado da operação no console.\n");

            Console.WriteLine("Escolha a operação desejada:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.Write("Digite o número da operação desejada: ");
            int operacao = int.Parse(Console.ReadLine());

            double resultado = 0;

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            do
            {
                if (operacao == 4 && num2 == 0)
                {
                    Console.WriteLine("Erro: Não é possível dividir por zero. Digite um número diferente de zero.");
                    Console.Write("Digite o segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                }
            } while (operacao == 4 && num2 == 0);

            switch (operacao)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado da soma: {resultado}");
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado da subtração: {resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado da multiplicação: {resultado}");
                    break;
                case 4:
                    resultado = num1 / num2;
                    Console.WriteLine($"Resultado da divisão: {resultado}");

                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
            Console.Read();
        }
    }
}
