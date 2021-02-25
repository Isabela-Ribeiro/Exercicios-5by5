using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz2
{
    class Program
    {
        /*Usando matriz sem referencia:
        static void Main(string[] args)
        {
            double[ , ] vetnota = new double[10,3];
            int aprovado = 0, reprovado = 0, exame = 0;
            string result = " ";

            Console.WriteLine("Cadastro de nota de Alunos:");
            for (int l = 0; l < 10; l++)
            {
                Console.WriteLine("Insira as notas do aluno " + (l + 1) + " :");
                for (int c = 0; c < 2; c++)
                {
                    Console.WriteLine("Insira a nota " + (c + 1) + ":");
                    vetnota[l, c] = Convert.ToDouble(Console.ReadLine());
                }
            }
            for (int l = 0; l < 10; l++)
            {
                    vetnota[l,2] += (vetnota[l, 0] + vetnota[l,1]) / 2;
                   
                        if (vetnota[l, 2] >= 7)
                        {
                            result = "Aprovado!";
                            aprovado++;
                        }
                        if (vetnota[l, 2] < 2) 
                        {
                            result = "Reprovado";
                            reprovado++;
                        }
                        if ((vetnota[l, 2] > 2) && (vetnota[l, 2] < 7))
                        {
                            result = "Exame!";
                            exame++;
                        }
                        Console.WriteLine("Aluno " + (l+1) + " nota 1: " + vetnota[l , 0] + " nota 2: " + vetnota[l, 1] + " media: " + vetnota[l, 2] + " Situação: " + result);      
            }     
            Console.WriteLine("Aprovado : " + aprovado);
            Console.WriteLine("Exame : " + exame);
            Console.WriteLine("Reprovado : " + reprovado);

            Console.ReadKey();
        }*/
        static void Main(string[] args)
        {​​
            double[,] nota = new double[10, 3];
            string[] situacao = new string[10];

            matriz(nota);
            calculaMedia(nota);
            statusAluno(nota, situacao);

            Console.ReadKey();
        }​​

        static void matriz(double[,] mat)
        {​​
            for (int i = 0; i < 2; i++)
            {​​
                for (int j = 0; j <= 9; j++)
                {​​
                    Console.WriteLine("Digite a nota: " + i + " do aluno: " + j);
                    mat[j, i] = double.Parse(Console.ReadLine());
                }​​
                Console.WriteLine("Cadastrado nota " + i + " dos alunos...");
            }​​
            return;
        }​​
        static void calculaMedia(double[,] mat)
        {​​
            for (int i = 0; i <= 9; i++)
            {​​
                mat[i, 2] = (mat[i, 0] + mat[i, 1]) / 2;
            }​​
            return;
        }​​
        static void statusAluno(double[,] mat, string[] situacao)
        {​​
            int aprovado = 0, reprovado = 0, exame = 0;

            for (int i = 0; i <= 9; i++)
            {​​
                if (mat[i, 2] >= 7)
                {​​
                    situacao[i] = "APROVADO";
                    aprovado++;
                }​​
                else
                {​​
                    if (mat[i, 2] < 2)
                    {​​
                        situacao[i] = "REPROVADO";
                        reprovado++;
                    }​​
                    else
                    {​​
                        situacao[i] = "EXAME";
                        exame++;
                    }​​
                }
                Console.WriteLine("Aluno " + i + " Nota 1 =" + mat[i, 0] + " Nota 2 =" + mat[i, 1] + " Media =" + mat[i, 2] + " Situação =" + situacao[i]);
            }​​
            Console.WriteLine("Alunos aprovados = " + aprovado);
            Console.WriteLine("Alunos reprovados = " + reprovado);
            Console.WriteLine("Alunos para exame = " + exame);
            return;
        }​​
        static void matriz(double[,] mat)
        {​​
            for (int i = 0; i < 2; i++)
            {​​
                for (int j = 0; j <= 9; j++)
                {​​
                   Console.WriteLine("Digite a nota: " + i + " do aluno: " + j);
                   mat[j, i] = double.Parse(Console.ReadLine());
                }​​
            Console.WriteLine("Cadastrado nota " + i + " dos alunos...");
            }​​
            return;
        }​​
static void calculaMedia(double[,] mat)
{​​
for (int i = 0; i <= 9; i++)
    {​​
mat[i, 2] = (mat[i, 0] + mat[i, 1]) / 2;
    }​​
return;
}​​



static void statusAluno(double[,] mat, string[] situacao)
{​​
int aprovado = 0, reprovado = 0, exame = 0;



    for (int i = 0; i <= 9; i++)
    {​​
if (mat[i, 2] >= 7)
        {​​
situacao[i] = "APROVADO";
            aprovado++;
        }​​
else
        {​​
if (mat[i, 2] < 2)
            {​​
situacao[i] = "REPROVADO";
                reprovado++;
            }​​
else
            {​​
situacao[i] = "EXAME";
                exame++;
            }​​
}​​
Console.WriteLine("Aluno " + i + " Nota 1 =" + mat[i, 0] + " Nota 2 =" + mat[i, 1] +
" Media =" + mat[i, 2] + " Situação =" + situacao[i]);
    }​​



Console.WriteLine("Alunos aprovados = " + aprovado);
    Console.WriteLine("Alunos reprovados = " + reprovado);
    Console.WriteLine("Alunos para exame = " + exame);
}​​
}​​
}​​
    

