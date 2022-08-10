using System;

namespace Cod_VetorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Programa: Cálculo de média de idade com Vetores
             * Problema: Entrar com idade de n pessoas
             * Autor: Pedro Ventola
             * Data: 03/06/2022
             */


            //Declaração de Vetores
            int[] idade = new int[10];
            float[] sal = new float[10];
            String[] nome = new String[8];
            Boolean[] temEstoque = new Boolean[8];

            //Variáveis
            int i, num_pessoas;
            float media = 0;
            float mediaTotal = 0;

            //Título
            Console.Clear();
            Console.WriteLine("--- CÁLCULO DA MÉDIA DE IDADES ---");

            //Entrada
            Console.Write("\nDigite a quantidade de pessoa(s): ");
            num_pessoas = int.Parse(Console.ReadLine());

            for (i = 1; i <= num_pessoas; i++)
            {
                //Entrada
                Console.Write("\n{0} - Digite a sua idade: ", i);
                idade[i] = int.Parse(Console.ReadLine());
               
            }

            for (i = 1; i <= num_pessoas; i++)
            {
                //Processamento
                mediaTotal = mediaTotal + idade[i];
            }

            //Processamento fora do loop
            media = mediaTotal / num_pessoas;

            Console.WriteLine("\n--- CÁLCULO DA MÉDIA DE IDADES ---\n");
            Console.WriteLine("Idades");
            Console.WriteLine("---------------------");
            

            for (i = 1; i <= num_pessoas; i++)
            {
                Console.WriteLine("{0} -- {1}", i , idade[i]); //Saída
            }

            Console.WriteLine("\n\nMédia das idades: {0}", media); //Saída
            Console.ReadKey();
        }
    }
}
