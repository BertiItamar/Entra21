using System;

namespace ConsoleApp5
{
    class Program
    {
        static void StartupObject(string[] args)
        {
            ///  Escreva um programa que receba dois pontos com coordenadas e imprima 
            /// em tela a distância entre eles
            int x1, x2, y1, y2, d = 0;
            double distancia;
           
            Console.WriteLine("Digite a coordenada x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a coordenada y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a coordenada x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a coordenada y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            distancia = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine($"a distancia entre os pontos é: ");













        }

    }
}
