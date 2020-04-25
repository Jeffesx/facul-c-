/*Faça um algoritmo que receba o custo de um espetáculo teatral e o preço do convite desse espetáculo.
Esse programa deve calcular e mostrar:
•a quantidade de convites que devem ser vendidos para que pelo menos o custo do espetáculo seja
alcançado.
•a quantidade de convites que devem ser vendidos para que se tenha um lucro de 30%.*/
using System;

namespace atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double precoconv,custoespet,quantconvit,convlucro;
            //lucro de 30%
            string percent = "30%";
            var percentlucro = 1.3;
            //exibe no console a solicitação para o usuário digitar valor
            Console.WriteLine("Digite o valor do convite:");
            //transforma o valor recebido no ReadLine em double e atribui ele a variavél
            precoconv = Convert.ToDouble(Console.ReadLine());
            //exibe no console a solicitação para o usuário digitar valor
            Console.WriteLine("Digite o custo do espetaculo:");
            //transforma o valor recebido no ReadLine em double e atribui ele a variavél
            custoespet = Convert.ToDouble(Console.ReadLine());
            //calcula a quantidade de convites
            quantconvit = custoespet/precoconv;
            //Arredonda a quantidade de convites para cima
            quantconvit = Math.Ceiling(quantconvit);
            //Calcula o lucro com base na variavel percentlucro
            convlucro = custoespet*percentlucro;
            //verifica a quantidade de ingressos para ter o lucro e arredonda
            convlucro = Math.Ceiling(convlucro/precoconv);
            //Escreve resultado
            Console.WriteLine("A quantidade de convites necessária para cobrir o espetaculo, é de:"+quantconvit);
            Console.WriteLine("A quantidade de convites necessária para obter "+percent+" de lucro é de:"+convlucro);

            
        }
    }
}
