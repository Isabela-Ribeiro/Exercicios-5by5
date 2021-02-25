using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[10, 5];
            int soma = 0;

            Console.WriteLine("DIGITE OS VALORES DA PRIMEIRA LINHA:");
             for (int c = 0; c < 5; c++)
             {
                   Console.Write("DIGITE OS VALORES DA " + (c+1) +  "° COLUNA : ");
                   num[0, c] = int.Parse(Console.ReadLine());
             }
            

            for (int l = 0; l < 10; l++)
            {
                for (int c = 0; c < 5; c++)
                {
                    
                   num[l, c] = num[0, c] * (l+1);
                  
                } 
            }
            for (int l = 0; l < 10; l++)
            {
                for (int c = 0; c < 5; c++)   
                {
                    Console.Write( num[l,c] + " \t ");
                   
                }
                Console.WriteLine();
            }
         
                for (int c = 0; c < 5; c++)
                {
                soma += num[9, c];
                }
            Console.WriteLine("\nA somatória da 10ª linha eh: " + soma);

            Console.ReadKey();
        }
    }
}
