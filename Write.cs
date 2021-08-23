using System;

namespace Calculadora_B_sica_em_C_
{
    class Writing
    {
        public static string WriteManual(string frase)
        {
            int digit = frase.Length;
            for(int c = 0; c < digit; c++)
            {
                System.Console.Write(frase[c]);
                System.Threading.Thread.Sleep(100);
                
            }

            return frase;
        }
    }
}