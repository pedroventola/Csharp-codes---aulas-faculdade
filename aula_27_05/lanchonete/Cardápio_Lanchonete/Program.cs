using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardápio_Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Autor: Pedro Ventola
            * Problema: Cardápio da Lanchonete
            * Data: 27/05/2022
           */

            String cod = "";
            string resp;
            double quantidade, total = 0;

            Console.WriteLine("--- LANCHONETE ---");

            //while ()
            
                Console.WriteLine("Insira o código do lanche");
                cod = Console.ReadLine();


                switch (cod)
                {
                    case "100":
                        Console.WriteLine("Código 100 - Cachorro quente - R$2,50");
                        Console.WriteLine("Quantos você deseja pedir?");
                        quantidade = double.Parse(Console.ReadLine());
                        total = quantidade * 2.5;
                        break;
                    case "101":
                        Console.WriteLine("Código 101 - Bauru Simples - R$2,00");
                        break;
                    case "102":
                        Console.WriteLine("Código 102 - Bauru com ovo - R$3,50");
                        break;
                    case "103":
                        Console.WriteLine("Código 103 - Hambúrguer - R$5,10");
                        break;
                    case "104":
                        Console.WriteLine("Código 104 - X-Burguer - R$3,00");
                        break;
                    case "105":
                        Console.WriteLine("Código 105 - Refrigerante - R$2,00");
                        break;
                }

                Console.WriteLine(total);
                Console.ReadKey();

               
        }
    }
}
