using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler um vetor de 10 elementos.
            Crie um segundo vetor, com todos os elementos na ordem inversa,
            ou seja, o último elemento passará a ser o primeiro, o penúltimo será o segundo e assim por diante.
            Imprima os dois vetores.*/
            /* int[] vet = new int[10];
             int[] vetInverso = new int[10];

             Console.WriteLine("Digite 10 valores inteiros: ");
             for(int i = 0; i < vet.Length; i++)
             {
                 Console.Write("O " + i + " valor: ");
                 vet[i] = int.Parse(Console.ReadLine());
             }

             for (int i = 0 ,  j = (vet.Length - 1);  i < vet.Length; i++ , j--)
             {  
                     vetInverso[j] = vet[i]; 
             }

             Console.Write("Os valores digitados foram:");
             for (int i = 0; i < vet.Length; i++)
             {
                 Console.Write(" " + vet[i]);
             }

             for (int j = 0; j < vetInverso.Length; j++)
             {
                 Console.Write("\nvetor Invertido: " + vetInverso[j]);
             }*/

            int[ , ] mat = new int[6,2];
            int[ , ] matInverso = new int[6,2];
  
            Console.WriteLine("Digite 6 valores inteiros: ");
            for ( int c = 0; c < mat.GetLength(1); c++)
            {
                Console.WriteLine(" Digite os numeros da coluna [" + c + "]");
                for( int l = 0; l < mat.GetLength(0); l++)
                {
                    Console.Write("Linha [" + l +"]");
                    mat[l,c] = int.Parse(Console.ReadLine());
                }  
            }
    
            
            for (int c = 0, cA = (mat.GetLength(1) - 1); c < mat.GetLength(1); c++, cA--)        
            {
                for (int l = 0, lA = (mat.GetLength(0) - 1); l < mat.GetLength(0); l++, lA--)
                {
                    matInverso[lA, cA] = mat[l, c];
                }
            }
            Console.WriteLine("Os numeros Digitados foram :");
            for(int l = 0; l < mat.GetLength(0); l++)
            {
                for(int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[l, c] + "\t ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nOs numeros Invertidos:");
            for (int lA = 0; lA < 6; lA++)  
            {
                for (int cA = 0; cA < 2; cA++)
                {
                    Console.Write(matInverso[lA, cA] + "\t ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
