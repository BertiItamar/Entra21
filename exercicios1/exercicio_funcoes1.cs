using System;

namespace ConsoleApp11
{
    class Program
    {
        ///  Faça um programa em que o usuário preencha um array de 10 posições e mostre o
        /// maior valor entre eles(usando funções e/ou procedimentos). 

        static void Main(string[] args)
        {
            static void arrayDeNumeros()
            {
                float[] notas = new float[10];
                float maior = 0; 

                for (int i = 0; i < notas.Length; i++)
                {
                    Console.WriteLine($"Digite o numero {i}º do seu Array: ");
                    notas[i] = Convert.ToSingle(Console.ReadLine());
                }

                for (int i = 0; i < 10; i++)
                {
                    if (notas[i] > maior)
                    {
                        maior = notas[i];
                    }
                }
                Console.WriteLine("O maior número é:" + maior);

            }
            arrayDeNumeros();
        }
    }
}
