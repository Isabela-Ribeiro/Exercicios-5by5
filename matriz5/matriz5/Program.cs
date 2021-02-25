using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[6, 2];

            Armazenar(mat);
            MostrarIndice(mat);
            CompararMatriz(mat);
          

            Console.ReadKey();
        }
        static void Armazenar(int[,] mat)
        {
            Console.WriteLine("Digite os valores inteiro das matrizes:");
           	        
		       for (int c = 0; c < mat.GetLength(1); c++)
               {      
                   for (int l = 0; l < mat.GetLength(0); l++)
                   {
                    Console.Write("Linha[" + l + "]" + " Coluna[" + c + "] ");
                    mat[l, c] = int.Parse(Console.ReadLine());
                   }
               }
            return;
        }
        static void MostrarIndice(int[,] mat)
        {
            Console.Clear();
            Console.WriteLine("valores digitados:");
            for (int l = 0; l < mat.GetLength(0); l++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                { 
                    Console.Write("\tIndice["+l+"] ["+c+"]: " + mat[l, c] );
                }
                Console.WriteLine();
            }

            return;
        }
        
        static bool Calculo(int[,] mat, int valor, int lA, int cA)
        {
            bool valorEncontrado = false;
            
            for (int l = 0; l < mat.GetLength(0)-1; l++)
            {
                for (int c = 0; c < mat.GetLength(1);c++)
                {
                    string posicao1 = $"{l},{c}";
                    string posicao2 = $"{lA},{cA}";

                    if ((posicao1 != posicao2) && (mat[l, c] == valor))         
                    {
                        Console.WriteLine("\nO valor " + valor + " existe na posição" + "[" + l + "," + c + "]" + " = [" + lA + "," + cA + "]");
                        valorEncontrado = true;
                    }
                    
                   break;
                }
               
            }
            
            return valorEncontrado;
        }
        static void CompararMatriz(int[,] mat)
        {
            bool valorEncontrado = false;
            for (int l = 0; l < mat.GetLength(0); l++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    bool existe = Calculo(mat, mat[l, c], l, c);

                    if (existe)
                        valorEncontrado = true;
                }
            }
            if (!valorEncontrado)
                Console.WriteLine("Não foram encontrados valores iguais");
        }
    }
}
