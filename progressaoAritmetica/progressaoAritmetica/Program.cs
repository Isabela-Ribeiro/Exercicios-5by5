using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progressaoAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            int ele;
            do
            {
                Console.Write("Quantos elementos terá a PA:");
                ele = int.Parse(Console.ReadLine());
            } while (ele <= 0);
            

            Console.Write("Qual a razao da PA: ");
            int razao = int.Parse(Console.ReadLine());

            Console.Write("Qual é o valor do primeiro elemento: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("a PA é:");
            for (int cont=0; cont<ele ;cont++)
            {
                
                Console.Write( num +  " " );
                num += razao;
            }
            Console.ReadKey();
        }
    }
}
