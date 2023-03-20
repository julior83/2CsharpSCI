using System;

namespace MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int numeroQtd = 5;
            int[] numeros = new int[numeroQtd];
            int menor = 0, maior = 0;

            Console.WriteLine("Informe 5 números inteiros:");

            for (int i = 0; i < numeroQtd; i++)
            {

                Console.WriteLine((i + 1) + "º número:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    menor = numeros[0];
                    maior = numeros[0];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
                else if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }

            }

            Console.WriteLine("O menor número é:" + menor);
            Console.WriteLine("O maior número é:" + maior);

            Console.Read();
        }
    }
}
