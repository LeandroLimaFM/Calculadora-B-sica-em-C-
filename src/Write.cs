
//**    Classe Word serve pare escrever no console com uma impressão de digitação e facilitar a entrada de dados

using System;
namespace Calculadora_B_sica_em_C_
{
    class Word
    {
        public static string WriteManual(string frase)
        {
            int digit = frase.Length;
            for(int c = 0; c < digit; c++)
            {
                System.Console.Write(frase[c]);
                System.Threading.Thread.Sleep(34);
                
            }

            return frase;
        }

        public static double askUserDouble(string phrase)
        {
                int digit = phrase.Length;
                for(int c = 0; c < digit; c++)
                {
                    System.Console.Write(phrase[c]);
                    System.Threading.Thread.Sleep(34);
                }

                double value = double.Parse(Console.ReadLine());
                return value;
        }

        public static int askUserInt(string phrase)
        {
            int digit = phrase.Length;
            for (int i = 0; i < digit; i++)
            {
                System.Console.Write(phrase[i]);
                System.Threading.Thread.Sleep(34);
            }
            int value = int.Parse(Console.ReadLine());
            return value;
        }

        public static char askUserChar(string phrase)
        {
            int digit = phrase.Length;
            for (int i = 0; i < digit; i++)
            {
                System.Console.Write(phrase[i]);
                System.Threading.Thread.Sleep(34);
            }
            char value = char.Parse(Console.ReadLine());
            return value;
        }

        public static string askUserString(string phrase)
        {
            int digit = phrase.Length;
            for (int i = 0; i < digit; i++)
            {
                System.Console.Write(phrase[i]);
                System.Threading.Thread.Sleep(34);
            }
            string value = Console.ReadLine();
            return value;
        }


    }
}