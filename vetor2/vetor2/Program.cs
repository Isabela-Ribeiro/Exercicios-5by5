using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Elabore um programa que:
             * A leitura de um vetor de 5 posicoes reais(float/double)
             * imprima o vetor obtido
             * inverte os valores dentro do vetor
             * imprima novamente o vetor processado*/

            /*float[] vet = new float[5];
            int aux;

            Console.WriteLine("Digite 5 valores:");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("O " + i + " valor: ");
                vet[i] = float.Parse(Console.ReadLine());
            }

            Console.Write("Os valores digitados foram:");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(" " + vet[i]);
            }

            Console.WriteLine(" ");

            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = i + 1; j < vet.Length; j++)
                {
                    aux = (int)vet[i];
                    vet[i] = vet[j];
                    vet[j] = aux;
                }
            }

            Console.Write("A ordem inversa é : ");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(" " + vet[i]);
            }

            Console.WriteLine(" ");*/
            /*__________________________________________________________________________*/

            /*Elabore um programa que ;
             * Leia um vetor de 10 posições
             * Ordene o vetor
             * Solicie ao usúario um valor para ser localizado no vetor
             * informe se o valor foi encontrado(mostre a posição ) ou se ele não foi encontrado */

            /*int[] vet = new int[10];
            int aux,busc;
            int cont = 0;

            Console.WriteLine("Digite 10 valores inteiro:");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("O " + i + " valor: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = i + 1; j < vet.Length; j++)
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
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(" " + vet[i]);
            }

            Console.WriteLine(" ");

            Console.Write("Digite um valor para ser encontrado:");
            busc = int.Parse(Console.ReadLine());
            int k=0;
            for ( int i = 0; ((i < vet.Length) && (busc >= vet[i])); i++)
            //for (int i = 0; ((i < vet.Length) ); i++)
                {
                k++;
                if (busc == vet[i])
                {
                    Console.WriteLine("Valor encontrado na posição " + i);
                    cont++;
                }

            }
            Console.WriteLine("k = " + k);
            if (cont == 0)
            {
                Console.WriteLine("Valor não encontrado");
            }*/
            /*________________________________________________________________________________________________________*/
            /*Escreva um programa para ler um número inteiro N e em seguida ler N números inteiros e armazená-los em um vetor.
             * Em seguida, percorrer o vetor e determinar quantos destes N números são negativos,
             * quantos são pares e quantos são positivos.
             * Você deverá determinar e controlar qual será o valor máximo de N.
             */

            /*int[] vet = new int[20];
            int tam;
            int cont = 0, cont1 = 0, cont2 = 0;

            do
            {
                Console.WriteLine("Digite o tamanho do vetor:(De até 20 posicoes)");
                tam = int.Parse(Console.ReadLine());

            } while ((tam>20)  || (tam<=1));

            Console.WriteLine(" Digite os valores inteiros: ");
            for (int i = 0; i < tam; i++)
            {
                Console.Write("O valor " + i +" é: ");
                vet[i] = int.Parse(Console.ReadLine());
            }
        
            for (int i = 0; i < tam; i++)
            {
               
                if (vet[i] < 0)
                {
                   cont++;
                }
                if (vet[i] > 0)
                {
                   cont1++; 
                }
                if ((vet[i] % 2 == 0)&& (vet[i]!=0))
                {
                   cont2++;
                }
                
            }
            Console.WriteLine(" ");
            Console.WriteLine("negativo = " + cont);
            Console.WriteLine("Positivo = " + cont1);
            Console.WriteLine("Pares = " + cont2);

            Console.WriteLine(" ");
            Console.Write("Digite enter para finalizar");
            Console.ReadKey();*/
            /*---------------------------------------------------------------------*/
            /*A sequência fibonacci é uma sequência numérica lógica que usa os dois números anteriores para achar o valor do próximo.
             * a fórmula é a seguinte:
               fn = fn - 1 + fn - 2
                Ex: 1 1 2 3 5 8...
                faça um programa que leia a posição desejada da sequência e 
            exiba ela completa na tela até o valor da posição escolhida.*/

            
           /*Não terminei ainda
            Console.WriteLine("Digite quantos numeros terá a sequencia: ");
            int opc = int.Parse(Console.ReadLine());

            int[] vet = new int[opc];
            

            for (int i=2; i < opc;i++)
            {
                vet[i] = vet[i - 1] + vet[i - 2];
            }
            Console.Write("Digite enter para finalizar");
            Console.ReadKey();
            */


        }
    }
}
