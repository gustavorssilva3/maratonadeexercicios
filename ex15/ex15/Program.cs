using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("15-) Crie um sistema simples de login, onde o programa solicita ao usuário um nome de usuário e senha.");
            Console.WriteLine("O sistema deve verificar se o nome de usuário e a senha correspondem aos valores cadastrados previamente (exemplo: nome de usuário = \"admin\" e senha = \"1234\").");
            Console.WriteLine("• Declare variáveis string para o nome de usuário e senha.");
            Console.WriteLine("• Utilize um laço do while para permitir que o usuário tente fazer login até acertar as credenciais.");
            Console.WriteLine("• Se o login for bem-sucedido, exiba \"Login bem-sucedido!\", caso contrário, exiba \"Credenciais incorretas\".\n");

            string usuarioCorreto = "admin";
            string senhaCorreta = "1234";
            string usuario, senha;

            do
            {
                Console.Write("Digite o nome de usuário: ");
                usuario = Console.ReadLine();

                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();

                if (usuario != usuarioCorreto || senha != senhaCorreta)
                {
                    Console.WriteLine("Credenciais incorretas. Tente novamente.\n");
                }

            } while (usuario != usuarioCorreto || senha != senhaCorreta);

            Console.WriteLine("Login bem-sucedido!");
            Console.ReadLine();
        }
    }
}
