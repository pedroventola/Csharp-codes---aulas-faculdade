using System;
using System.Threading;

namespace Prog_Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Autor: Pedro Ventola
            * Programa: Cadastro de Pessoas
            * Data: 20/05/2022
            */

            String nome = "";
            String numcel = "";
            int idade = 0;
            String necresp = "";
            String cpf = "", rg = "", uf = "";



            //inicio
            Console.Clear();
            Console.WriteLine("  --- CADASTRO --- \n ");


            //regras do looping
            while (nome == "")
            {
                //entrada
                Console.Write("Digite o seu nome: ");
                nome = Console.ReadLine();

            }

            while (numcel.Length < 11)
            {
                //entrada
                Console.Write("Digite o seu número de celular: ");
                numcel = Console.ReadLine();

            }

            while (!((idade >= 18) && (idade <= 99)))
            {
                //entrada
                Console.Write("Digite a sua idade: ");
                idade = int.Parse(Console.ReadLine());

            }

            while (!((necresp.ToUpper() == "S") || (necresp.ToUpper() == "N")))
            {
                //entrada
                Console.Write("Possui necessidades especias ? (S)im ou (N)ão: ");
                necresp = Console.ReadLine();

            }

            while (!(cpf.Length == 11))
            {
                //entrada
                Console.Write("Digite seu cpf: ");
                cpf = Console.ReadLine();

            }

            while (!(rg.Length == 9))
            {
                //entrada
                Console.Write("Digite seu rg: ");
                rg = Console.ReadLine();

            }

            while (!(uf.Length == 2))
            {
                //entrada
                Console.Write("Digite seu estado de origem. Exemplo (SP): ");
                uf = Console.ReadLine().ToUpper();

            }

           
            Console.Write(" \n Carregando... \n\n");


            //saída
            Thread.Sleep(500);
            Console.WriteLine("Nome..........: {0}", nome);
            Console.WriteLine("Celular.......: {0}", numcel);
            Console.WriteLine("Idade.........: {0}", idade);
            Console.WriteLine("Nec. Especiais: {0}", necresp);
            Console.WriteLine("C.P.F.........: {0}", cpf);
            Console.WriteLine("R.G...........: {0}", rg);
            Console.WriteLine("U.F...........: {0}", uf);

            Console.ReadKey();
        }
    }
}
