using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Conversioni
{
    internal class conversione
    {
        static void Main(string[] args)
        {
            int nConvertito1, nConvertito2;
            int[] dp = { 10, 10, 10, 10 };
            bool[] b = {true, false, true, false};
            nConvertito1 = Convert_Binario_To_Intero(b);
            Console.WriteLine("Conversione: Binario - Intero");
            Console.WriteLine(nConvertito1);
            Console.WriteLine("(attendere 5 secondi...)");
            Thread.Sleep(5000);
            Console.Clear();
            nConvertito2 = Convert_Decimale_Puntato_To_Intero(dp);
            Console.WriteLine("Conversione: Decimale puntato - Intero");
            Console.WriteLine(nConvertito2);
            Console.ReadLine();
        }
        static int Convert_Binario_To_Intero(Boolean[] b)
        {
            int somma;
            int j = 0;
            double nConvertito = 0;
            for (int i = b.Length - 1; i >= 0; i--)
            {

                if (b[i] == true)
                {
                    nConvertito = nConvertito + (1 * Math.Pow(2, j));
                }
                j++;
            }
            somma = (int)nConvertito;
            return somma;
        }
        static int Convert_Decimale_Puntato_To_Intero(int[] dp)
        {
            double somma = 0;
            int j = 0;
            for (int i = dp.Length - 1; i >= 0; i--)
            {
                somma = somma + (dp[i] * Math.Pow(256, j));
                j++;
            }
            return (int)somma;
        }
    }
}