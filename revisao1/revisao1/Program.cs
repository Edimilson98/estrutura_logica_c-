using System;

namespace revisao1
{
    class Program
    {
        static void Main(string[] args)
        {
            // um simples sistema que define se é manhã, tarde ou noite através das horas!
            #region Estrutura condicional if...
            /* 
             * 
            int horas;
            Console.WriteLine("Que horas são? ");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia");
            } 
            else if(horas < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }

            Console.ReadLine();
             

            int minutos;
            double conta;

            Console.WriteLine("DIGITE QUANTOS MINUTOS DESEJA");
            minutos = int.Parse(Console.ReadLine());

            conta = 50;

            if (minutos > 100)
            {
                conta += (minutos - 100) * 2;
            }
            Console.WriteLine("valor a pagar: " + conta);
            */
            #endregion

            // um simples sistema que diz o dia da semana
            #region Estrutura condicional Switch-case...
            /* int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda";
                    break;
                case 3:
                    dia = "terça";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                case 6:
                    dia = "sexta";
                    break;
                case 7:
                    dia = "sábado";
                    break;
                default:
                    dia = "dia inválido";
                    break;
            }

            Console.WriteLine("o dia da semana é: " + dia);
            Console.ReadLine();
            */
            #endregion

            //um simples sistema de soma com condição
            #region Estrutura repetitva While...
            /*
            int x, soma;

            x = int.Parse(Console.ReadLine());

            soma = 0;
            while(x != 0)
            {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O resultado é: " + soma);
            Console.ReadLine();
            */
            #endregion

            //um simples sistema de soma que diz a soma da quantidade de números definido inicialmente
            #region Estrutura repetitiva for...
            /* int N, x, soma;

            N = int.Parse(Console.ReadLine());

            soma = 0;
            for(int i=1; i<=N; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }

            Console.WriteLine(soma);
            Console.ReadLine();
            */
            #endregion

            // um simples sistema que converte celsius em fahrenheit
            #region Estrutura repetitiva do while...

            /* double C, F;
            char repetir;

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine());
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1"));
                Console.Write("Deseja repetir (s/n)? ");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');

            Console.ReadLine();
            */

            #endregion
        }
    }
}
