using System;

namespace Problema_Fábrica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Autor: Pedro Ventola
             * Problema: Cadastro de peças 
             * Data: 27/05/2022
            */

            //variáveis
            int contA = 0, contR = 0, i = 1, capacity = 0; ;
            String estado = "";
            String codigo;
           

            //Titulo
            Console.WriteLine("--- Cadastro Peças Fábrica ---");

            //entrada
            Console.Write("\nDigite a capacidade de peças: ");
            capacity = int.Parse(Console.ReadLine());

            //looping
            while (i <= capacity)
            {
                //entradas
                Console.Write("\nDigite o código da {0}° peça: ", i);
                codigo = Console.ReadLine();
                Console.Write("\nDigite o estado da {0}° peça: ", i);
                estado = Console.ReadLine();

                //condição
                while (!((estado == "Aprovado" || estado == "aprovado") || (estado == "reprovado" || estado == "Reprovado")))
                {
                    Console.Write(" \nDigite o estado da peça. Aprovado/Reprovado: ");
                    estado = Console.ReadLine();
                }

                //incremento
                i++;


                if (estado == "Aprovado" || estado == "aprovado")
                {
                    //processamento
                    contA++;
                }
                else
                {
                    //processamento
                    contR++;
                    Console.Write("\nO produto com código {0} está reprovado.\n", codigo);
                }

                
            }

            //sáida
            Console.Write("\nTotal de produtos aprovados: {0}", contA);
            Console.Write("\nTotal de produtos reprovados: {0}", contR);

            Console.ReadKey();

        }
    }
}
