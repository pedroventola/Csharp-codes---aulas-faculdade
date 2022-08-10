using System;


namespace Comparação_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Problema: Ordenar diferentes números
             * Progrma: Ordenando números de forma asc/desc
             * Autor: Pedro Ventola
             * Data: 03/06/2022
             */

            //Declaração de Vetores
            int[] numeros = new int[10];

            //Variáveis
            int i, ii, limitador, temp;

            //Título

            Console.WriteLine("--- Ordenação ---\n");

            limitador = 9;

            //Entrada
            for (i = 1; i <= limitador; i ++)
            {
                Console.Write("Digite o {0}° número: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            //Processamento
            for(i = 1; i <= limitador; i++)
            {
                for(ii = 1; ii <= limitador; ii++)
                {
                    // if (numeros[i] > numeros[ii]) desc
                    if (numeros[i] < numeros[ii]) //asc
                    {
                        temp = numeros[i];
                        numeros[i] = numeros[ii];
                        numeros[ii] = temp;

                    }
                }
            }

            //Sáida
            Console.Write("\n\n |");
            for(i = 1; i <= limitador; i++)
            {
                Console.Write(" {0} |", numeros[i]);
            }

            Console.ReadKey();

        }
    }
}
