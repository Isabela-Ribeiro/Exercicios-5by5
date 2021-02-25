using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoListaDinamicaEnc
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ListaContatos meus_contatos = new ListaContatos { Head = null, Tail = null,Cont=0 };
            int opc;
            do
            {
                Console.WriteLine("Agenda telefonica");
                Console.WriteLine("1-Cadastrar Numero\n2-Excluir Numero\n3-Procurar por Contato\n4-Lista telefonica\n5-Impressão indiviual\n6-Quantidade de Contatos\n0-Sair");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Cadastro do contato");
                        Console.Write("Digite o nome:");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o DDD:");
                        int ddd = int.Parse(Console.ReadLine());
                        Console.Write("Digite Numero:");
                        int num = int.Parse(Console.ReadLine());
                        Console.Write("Digite o tipo do telefone:");
                        string tipo = Console.ReadLine();

                        Pessoa nova= new Pessoa
                        {
                            Nome = nome,
                            telefone = new Telefone[] {
                                new Telefone { DDD = ddd,
                                               Numero =num,
                                               Tipo = tipo 
                                }
                            }
                        };
                        meus_contatos.Push(nova);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Digite o nome de quem quer excluir:");
                        nome = Console.ReadLine();
                        meus_contatos.Remover(nome);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Procurar Por contato:");
                        Console.WriteLine("Digite o nome da pessoa:");
                        string pesq = Console.ReadLine();
                        meus_contatos.Pesquisar(pesq);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Lista telefonica");
                        meus_contatos.Print();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("impressão Individual");
                        meus_contatos.PrintIndividual();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine($"\nVocê tem {meus_contatos.Cont} contatos\n");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida!");
                            break;
                }  
            } while (opc!=0);  
        }
        
    }
}
