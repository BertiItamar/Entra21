using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///• Faça um programa que receba 3 notas de um aluno e identifique a maior
            /// nota, a menor nota e a média entre as notas;


            float n1 = 1;
            float n2 = 1;
            float n3 = 1;

            float media = 0;

            Console.WriteLine("Digite a nota: ");
            n1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a nota: ");
            n2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a nota: ");
            n3 = Convert.ToSingle(Console.ReadLine());

            media = n1 + n2 + n3;
            media = media / 3;

            Console.WriteLine($"a media do aluno é: {media}");

            if (n1 > n2 && n1 > n3)
            {

                Console.WriteLine($"A maior nota é: {n1}");
            }


            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine($"A maior nota é: {n2}");

            }
             
            
             else if (n3 > n2 && n3 > n1) 
            {
                Console.WriteLine($"A maior nota é: {n3}");
            }

            /// segunda verificação 

            if (n1 < n2 && n1 < n3)
            {

                Console.WriteLine($"A menor nota é: {n1}");
            }


            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine($"A menor nota é: {n2}");

            }


            else if (n3 < n2 && n3 < n1)
            {
                Console.WriteLine($"A menor nota é: {n3}");
            }


















        }
    }
}
