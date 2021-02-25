using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//DECLARANDO VETOR
            int[] x = new int[5];

            // LER VETOR
            Console.WriteLine("Informe 5 valores inteiro: ");
            for (int i=0; i<5 ;i++ )
            {
                Console.Write("Informe um valor " + (i+1) + " valor:");
                x[i] = int.Parse(Console.ReadLine());
            }

            //MOSTRAR VETOR
            Console.WriteLine("Os valores informados são: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" x [" + i + "]= " + x[i]);
               
            }*/

            /*___________________________________________________________________________________*/
            /*Elebore um prigrama que 
             * leia um vetor que leia 10 posicoes de inteiros
             * Todos os valores informados deverão obrigatoriamente serem pares
             * Imprima apenas os valores maiores do que 10
             * No final imprima a somatoria de todos os valores.

            int[] vet = new int[10];//new serve para a locação de memoria
            int soma = 0;

            Console.WriteLine("Informe 10 numeros inteiros pares");

            for (int i = 0; i < vet.Length; i++)
            {
                do
                {
                    Console.Write("Informe o " + (i+1) + " numero inteiro par: ");
                    vet[i] = int.Parse(Console.ReadLine());
                } while (vet[i] % 2 != 0);            
            }

            Console.Write("Valores maiores do que 10: ");
            for (int i = 0; i < vet.Length; i++)
            {
                    if (vet[i] > 10)
                    {
                        Console.Write(vet[i] + " "); 
                    }
                    soma += vet[i];
            }
            Console.WriteLine(" ");
            Console.WriteLine("A soma dos pares : " + soma);*/
            /*________________________________________________________________________*/
            /*Elabore um programa que:
             * leia um vetor de 10 posiçoes de inteiro
             * Solicite ao uuario um valor para ser localizado no vetor
             * Informe ao usuario se : O valor foi encontrado(Posição) ou se o valor não foi encontado*/
            /* int[] vet = new int[10];


             Console.WriteLine("Digite 10 valores inteiro:");
             for (int i=1;i<vet.Length;i++)
             {
                 Console.Write("O " + i + " valor: ");
                 vet[i] = int.Parse(Console.ReadLine());
             }

             Console.Write("Digite um valor para ser encontrado:");
             int busc = int.Parse(Console.ReadLine());
             int cont=0;

             for(int i = 1; i < vet.Length; i++)
             {

                 if (busc == vet[i])
                 {
                     Console.WriteLine("Valor encontrado na " + i + " posição");
                     cont++;
                 }

            }
             if (cont==0)
             {
                 Console.WriteLine("Valor não encontrado");
             }*/
            /*____________________________________________________________________________*/
            /*Elabore um programa 
             * leia um vetor de 10 posições de inteiro
             * Após a leitura de todos os valores, imprima o vetor fornecido
             * Ordene o vetor
             * Imprima  o vetor
             */

            int[] vet = new int[10];
            int aux;

            Console.WriteLine("Digite 10 valores inteiro:");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("O " + i + " valor: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Os valores digitados foram:");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(" " + vet[i]);
            }

            for( int i=0; i < vet.Length; i++)
            {
                for(int j = i+1; j < vet.Length; j++)
                {
                    if (vet[i] > vet[j])
                    {
                        aux = vet[i];
                        vet[i] = vet[j];
                        vet[j] = aux;
                    }
                }
            }

            Console.Write(" A ordem é : ");
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write(" " + vet[i]);
            }
            Console.ReadKey();
        }
    }
}
