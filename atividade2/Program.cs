/*Faça um algoritmo que leia o um número inteiro entre 1 e 7 e escreva o dia da semana correspondente.
Caso o usuário digite um número fora desse intervalo, deverá aparecer uma mensagem informando
que não existe dia da semana com esse número.
Dia 1 (domingo), dia 2 (segunda-feira), ... , dia 7 (sábado)*/

using System;

namespace atividade2
{
    class Program
    {
        static void Main(string[] args)
        {   //solicita ao usuário um numero
            Console.WriteLine("Digite um numero de 1 a 7, para descobrir o da semana correspondente:");
            //le o numero digitado, converte o número lido em inteiro e o atribui a variavel numsemana
            int numsemana = Convert.ToInt32(Console.ReadLine());

            //if verifica se o número recebido está entre 7 e 1
            if (numsemana >= 1 && numsemana <= 7)
            {//caso condicional correta, executa case
               switch (numsemana)
                {
                    case 1:
                        Console.WriteLine("domingo");
                        break;
                    case 2:
                        Console.WriteLine("segunda");
                        break;
                    case 3:
                        Console.WriteLine("terça");
                        break;
                    case 4:
                        Console.WriteLine("quarta");
                        break;
                    case 5:
                        Console.WriteLine("quinta");
                        break;
                    case 6:
                        Console.WriteLine("sexta");
                        break;
                    case 7:
                        Console.WriteLine("sábado");
                        break;
                }
            }else
            // se não exibe mensagem
            {   
             
             Console.WriteLine(" O numero: " + numsemana + ", não corresponde a nenhum dia da semana!");
                
            }
        }
}}
