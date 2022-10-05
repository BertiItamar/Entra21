using System;

namespace Exercicio_4
{
    class Program
    { ///
        static void Main(string[] args)
        {
            ///Faça um programa que receba o valor de um produto e o percentual de 
            /// desconto e mostre o valor do produto com o desconto e calcule os impostos
            /// (com base no valor sem desconto) sobre e mostre também em tela:
            /// Valor até 100: alíquota de 5 %;
            /// Valor entre 101 e 300: alíquota de 15 %;
            ///Valor entre 301 e 1000: alíquota de 25 %

            float valorDoProduto = 1;
            int descontoDoProduto = 1;
            float valorComDesconto = 1;
            float produtoComDesconto = 1;
            float aliquiota = 1;
            float aliquiota5 = 1;
            float aliquiota15 = 1;
            float aliquiota25 = 1;
            

            


            Console.WriteLine("Qual o valor do produto que você deseja comprar? ");
            valorDoProduto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o valor de desconto a ser dado ao cliente?");
            descontoDoProduto = Convert.ToInt32(Console.ReadLine());

            valorComDesconto = valorDoProduto / 100 * descontoDoProduto;
            produtoComDesconto = valorDoProduto - valorComDesconto;

            Console.WriteLine($"Valor do desconto é: {valorComDesconto}");
            Console.WriteLine($"O valor do produto com desconto é: {produtoComDesconto}");



            if (valorDoProduto <= 100)
            {
                aliquiota = valorDoProduto / 100 * 5;
                aliquiota5 = valorDoProduto - aliquiota;
                Console.WriteLine($"Aliquiota de 5%: {aliquiota5}");
            }

            else if (valorDoProduto > 101 && valorDoProduto < 300) 
            {
                aliquiota = valorDoProduto / 100 * 15;
                aliquiota15 = valorDoProduto - aliquiota;
                Console.WriteLine($"Aliquiota de 15%: {aliquiota15}");
            }

            else if (valorDoProduto > 301 && valorDoProduto < 1000) 
            {
                aliquiota = valorDoProduto / 100 * 25;
                aliquiota25 = valorDoProduto - aliquiota;
                Console.WriteLine($"Aliquiota de 25%: {aliquiota25}");
            }
               


        }
    }
}
