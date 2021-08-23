using System;


namespace Calculadora_B_sica_em_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int key = 0;
            Writing.WriteManual("Olá, seja bem-vindo a minha primeira calculadora hospedada no GitHub!\n");
            while(key != 5){
            double n1,n2;
            try
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("Digite seu primeiro número: ");
                n1 = double.Parse(Console.ReadLine());
                System.Console.Write("Digite seu segundo número: ");
                n2 = double.Parse(Console.ReadLine());
                Console.Clear();
               
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                System.Console.Write($"Seu números foram: {n1} e {n2}\n\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("O que deseja fazer agora?\n\n[1] Soma\n[2] Subtração\n[3] Multiplicação\n[4] Divisão\n[5] Sair do Programa\n\n");
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("===>>>");
                key = int.Parse(Console.ReadLine());
                Console.Clear();
                for(int i = 0; i <= 3; i++){
                    System.Console.WriteLine("\n" + i);
                    System.Threading.Thread.Sleep(1000);
                }
                Console.Clear();    
                Console.ForegroundColor = ConsoleColor.Green;
                switch (key)
                {
                    case 1:
                        Console.Clear();
                        System.Console.WriteLine($"O resultado da soma de {n1} e {n2} é igual à {Counts.Plus(n1, n2)}\n");
                        break;
                    case 2:
                        Console.Clear();
                        System.Console.WriteLine($"O resultado da subtração de {n1} e {n2} é igual à {Counts.Minus(n1, n2)}\n");
                        break;
                    case 3:
                        Console.Clear();
                        System.Console.WriteLine($"O resultado da multiplicação de {n1} e {n2} é igual à {Counts.Times(n1, n2)}\n");
                        break;
                    case 4:
                        Console.Clear();
                        System.Console.WriteLine($"O resultado da divisão de {n1} e {n2} é igual à {Counts.Div(n1, n2)}\n");
                        break;
                }
            }

            catch(Exception error)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine("VALOR DIGITADO NÃO RECONHECIDO! FAVOR SIGA AS INSTRUÇÕES!\n\n"+error.Message+"\n");
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
            }

            Console.ResetColor();
            }

            Console.Clear();
            Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("PROGRAMA FINALIZADO COM SUCESSO! OBRIGADO POR ME USAR!!!!");
            Console.ResetColor();
        }

    }
}
