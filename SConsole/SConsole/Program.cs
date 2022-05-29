using Microsoft.SqlServer.Management.Smo;
using System;

namespace SConsole
{
    class Program
    {        
        static void Main(string[] args)
        {
            string opcaoTela1;
            Console.WriteLine("BEM VINDO AO SISTEMA DE GESTÃO DE USUÁRIOS");
            goto: Login;
            Console.WriteLine("\n\n1 - Fazer Login\n2 - Cadastrar-se");
            opcaoTela1 = Console.ReadLine().ToString();
            if (opcaoTela1 == "1")
            {

            }
            else if (opcaoTela1 == "2")
            {

            }
            else
            {
                Console.WriteLine("Opção Inválida!!!");
                
            }
        }
    }
}
