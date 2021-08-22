using System;

namespace Calculadora_B_sica_em_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Olá, Seja Bem-vindo a minha primeira calculadora no GitHub!");
            double n1,n2;
            char key;
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.Write("Digite seu primeiro número: ");
                n1 = double.Parse(Console.ReadLine());
                System.Console.Write("Digite seu segundo número: ");
                n2 = double.Parse(Console.ReadLine());
                Console.Clear();
                System.Console.Write($"Seu números foram: {n1} e {n2}\n\nO que deseja fazer agora?\n\n[1] Soma\n[2] Subtração\n[3] Multiplicação\n[4] Divisão\n\n===>>>");
                key = char.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Green;
                switch (key)
                {
                    case '1':
                        System.Console.WriteLine($"O resultado da soma de {n1} e {n2} é igual à {n1 + n2}");
                        break;
                    case '2':
                        System.Console.WriteLine($"O resultado da subtração de {n1} e {n2} é igual à {n1 - n2}");
                        break;
                    case '3':
                        System.Console.WriteLine($"O resultado da multiplicação de {n1} e {n2} é igual à {n1 * n2}");
                        break;
                    case '4':
                        System.Console.WriteLine($"O resultado da divisão de {n1} e {n2} é igual à {n1 / n2}");
                        break;
                }
            }

            catch(Exception error)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine("VALOR DIGITADO NÃO RECONHECIDO! FAVOR SIGA AS INSTRUÇÕES!\n\n"+error.Message);
            }

            Console.ResetColor();
        }
    }
}
