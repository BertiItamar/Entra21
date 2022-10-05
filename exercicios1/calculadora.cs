using System;

namespace Calculadora
{
    class Program
    {
        ///  Faça um programa com um menu que receba uma opção, e de acordo com a
        /// opção, efetue uma operação(uma função ou procedimento) conforme abaixo e mostre em
        /// tela o resultado.O usuário deve poder efetuar quantas operações quiser.
        ///   1 – Adição;
        /// 2 – Subtração;
        /// 3 – Multiplicação;
        /// 4 – Divisão(não permitir divisão por zero);
        /// 0 – Sair.
        ///  Faça um programa em que o usuário preencha um array de 10 posições e mostre o
        /// maior valor entre eles(usando funções e/ou procedimentos).
        /// Faça um programa que receba um valor e, usando uma função, receba esse valor
        /// e retorne e mostre todos os divisores entre 0 e o número;
        /// Faça uma função que receba em um vetor as notas de 10 alunos e verifique se
        /// todos passaram(nota maior que 7). Deverá ser criada uma função que retorne um array
        /// do tipo bool, com os alunos que passaram.
        static void Main(string[] args)
        {           
            static void somarDoisNumeros(double n1, double n2)
            {              
                double res = n1 + n2;
                Console.WriteLine("A Soma é " + res);
            }
            static void subtrairDoisNumeros(double n1, double n2)
            {
                double res = n1 - n2;
                Console.WriteLine("A Subtração é " + res);
            }
            static void multiplicarDoisNumeros(double n1, double n2)
            {
                double res = n1 * n2;
                Console.WriteLine("A multiplicação é " + res);
            }
            static void divisãoDoisNumeros(double n1,double n2)
            {
                double res = n1 / n2;
                Console.WriteLine("A Divisão é " + res);
            }   
            static void calculara()
            {
                Console.WriteLine("Escolha uma opção abaixo:");
                Console.WriteLine("\ta - ASoma");
                Console.WriteLine("\tb - Subtração");
                Console.WriteLine("\tc - Multipplicação");
                Console.WriteLine("\td - Divisão");

                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n4 = Convert.ToDouble(Console.ReadLine());
                        somarDoisNumeros(n3, n4);
                        break;
                    case "b":
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n5 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n6 = Convert.ToDouble(Console.ReadLine());
                        subtrairDoisNumeros(n5, n6);
                        break;
                    case "c":
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n7 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n8 = Convert.ToDouble(Console.ReadLine());
                        multiplicarDoisNumeros(n7, n8);
                        break;
                    case "d":
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n2 = Convert.ToDouble(Console.ReadLine());
                        divisãoDoisNumeros(n1, n2);
                        break;
                }




            }calculara();
        }
    }
}
