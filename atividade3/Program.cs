/*Faça um algoritmo que leia um número maior ou igual a 10, deve-se validar a entrada, e informe
quantos divisores ele possui entre 1 e 9.*/
using System;

namespace atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {   //solicita ao usuário um numero
                Console.WriteLine("Digite um numero maior ou igual a 10, e descubra a quantidade divisores que ele possui, e quais são eles:");
                //le o numero digitado, converte o número lido em inteiro e o atribui a variavel num
                num = Convert.ToInt32(Console.ReadLine());
            //verifica se o numero é menor que 10
            } while (num < 10);
            //inicializa a varivel de quantidade de divsores
            int quantdiv = 0;
            //realiza a varredura de possiveis divisores até 9
            for (int i = 1; i <= 9; i++)
            {   //valida se o numero é divisor.
                if (num % i == 0)
                {   //a cada varredura do laço incrementa a quantidade de divisores
                    quantdiv++;
                    //exibe os numeros divisores
                    Console.WriteLine("Numero divisor:"+i);
                }
            }
            
            //apresenta a quantidade de numeros divisores
            Console.WriteLine("A quantidade de divisores para,"+num+" é de: "+quantdiv);
        }
    }
}
