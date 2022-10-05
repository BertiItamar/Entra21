using System;

namespace ConsoleApp23
{
    class Program
    {
        /// Escreva um jogo, usando funções, em que o usuário informa um
        /// valor e o programa gerará um valor aleatório.O usuário deve ir
        /// digitando até acertar, e assim, o programa finaliza.
        static void Main(string[] args)
        {
            
            static void jogoNumeroAleatorio()
            {
                Random numAleatorio = new Random();
                int valorInteiro = numAleatorio.Next(1, 50);
                int numeroSorte = 0;

                              
                while(numeroSorte != valorInteiro)
                {
                    Console.WriteLine("Digite um numero de 1 a 50");
                    numeroSorte = Convert.ToInt32(Console.ReadLine());
                }
                if (numeroSorte == valorInteiro)
                {
                    Console.WriteLine("Voce acertou o numero da sorte!!!! ");
                }
                else
                {
                    Console.WriteLine($"Numero aleatorio é:{valorInteiro}");
                    Console.WriteLine("TENTE OUTRA VEZ! ");
                }
                
            }

            jogoNumeroAleatorio();          
        }
    }
}
