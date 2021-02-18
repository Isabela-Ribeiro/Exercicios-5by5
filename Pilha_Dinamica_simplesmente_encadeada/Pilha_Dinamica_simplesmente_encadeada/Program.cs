using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica_simplesmente_encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha_Dinamica_livro minha_pilha = new Pilha_Dinamica_livro { Topo = null , cont=0 };
            minha_pilha.Imprimir();
            Console.ReadKey();
            int opc;
            
           
            do
            {
                Console.WriteLine("\tMENU LIVRO:");
                Console.WriteLine("1-INSERIR LIVRO\n2-REMOVER LIVRO\n3-IMPRIMIR PILHA\n4-QUANTIDADE DE ELEMENTOS NA PILHA\n5-BUSCAR POR TITULO\n0-SAIR");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Titulo ");
                        string ti = Console.ReadLine();
                        Console.Write("Autor ");
                        string a = Console.ReadLine();
                        Console.Write("Token: ");
                        int tk = int.Parse(Console.ReadLine());

                        minha_pilha.Push(new Livro
                        {
                            Titulo = ti,
                            Autor = a,
                            Isbn = tk,
                        });
                        

                        break;
                    case 2:
                        Console.Clear();
                        minha_pilha.pop();
                        
                        break;
                    case 3:
                        Console.Clear();
                        minha_pilha.Imprimir();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Quatidade de elementos na pilha: " + minha_pilha.cont);
                        break;
                    case 5:
                        Console.Clear();
                        
                        Console.Write("Digite o titulo para ser encontrado:");
                        string tLivro = Console.ReadLine();
                        minha_pilha.pesquisar(tLivro);
                        
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;

                }
            } while (opc != 0);
           

            Console.ReadKey();
            
        }
    }
}
