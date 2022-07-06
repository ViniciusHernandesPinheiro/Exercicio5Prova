using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5Prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RA: 6322036
            //Nome: Vinícius Hernandes Pinheiro

            Console.WriteLine("Exercicio 5");

            Console.WriteLine("Numeros pares entre 1 e 100");
            
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
