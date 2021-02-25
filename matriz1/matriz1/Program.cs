using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //linha //coluna
            //int[ , ] x = new int[ 1 ,  5  ];
            float soma = 0;
            float[ , ] x = new float[3, 2];//[linha,coluna]

            Console.WriteLine("Informe os valores da Matriz [7,3]");
            for (int l = 0; l < 3; l++)
            {
                Console.WriteLine("Informe os valores da Linha[" + l + "]:");
                for (int c = 0; c < 2; c++)
                {
                    Console.Write("coluna[" + c + "]=");
                    x[l, c] = float.Parse(Console.ReadLine());
                }

            }
         
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 2; c++)
                {
                    soma += x[l, c];
                }

            }
            Console.WriteLine("A soma é: " + soma);
                Console.ReadKey();
        }
    }
}
