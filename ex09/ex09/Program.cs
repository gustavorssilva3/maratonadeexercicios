using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9-) Crie um sistema de segurança que verifica se um usuário está logado.");
            Console.WriteLine("Declare uma variável bool chamada usuarioLogado e inicialize-a com true ou false.");
            Console.WriteLine("Use um if para verificar se o usuário está logado e exiba uma mensagem no console informando se o usuário está ou não logado.\n");

            bool usuarioLogado = false;
            if (usuarioLogado)
            {
                Console.WriteLine("O usuário está Logado");
            }
            else
            {
                Console.WriteLine("O usuário não está Logado");
            }
            Console.ReadLine();
        }
    }
}
