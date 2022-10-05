using System;

namespace array_reverse
{
    class Program
    {
        /// Faça um programa que receba um array de 10 posições e o imprima
        /// na ordem inversa.
        private static void PrintIndexAndValues(object myArray)
        {
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            static void reverserArray()
            {
                int[] numeros = new int[10];

                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine("Digite um numero: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());


                }
                for (int b = numeros.Length - 1; b >= 0; b--)
                {
                    Console.Write(numeros[b]);
                }
            }

            reverserArray();
          
        }
    }
}
