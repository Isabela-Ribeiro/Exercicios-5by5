using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoa = new List<Pessoa>();

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
                       
                        Pessoa nova = new Pessoa
                        {
                            Nome = nome,
                            telefone = new List<Telefone> {
                                new Telefone { DDD = ddd,
                                               Numero =num,
                                               Tipo = tipo
                                }
                            }
                        };
                        listaPessoa.Add(nova);
                        listaPessoa = listaPessoa.OrderBy(ordem=>ordem.Nome).ToList();
                        listaPessoa.ForEach(i => Console.WriteLine(i.ToString() + "\n"));
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Digite o nome de quem quer excluir:");
                        Console.WriteLine("Digite o nome da pessoa que deseja excluir:");
                        string excluir = (Console.ReadLine());
                        if (listaPessoa.Remove(listaPessoa.Find(contato => contato.Nome.Equals(excluir))))
                        {
                            Console.WriteLine("Contato removido com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Contato não localizado");
                        }

                        break;
                    case 3:
                        Console.Clear();

                        Console.WriteLine("Procurar Por contato:");
                        string pesq = Console.ReadLine();
                        Console.WriteLine(listaPessoa?.Find(contato=>contato.Nome.Equals(pesq)));
                        
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Impressão");               
                        listaPessoa.ForEach(i => Console.WriteLine(i.ToString() + "\n"));

                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("impressão Individual");

                        listaPessoa?.Sort((contato1, contato2) => contato1.Nome.CompareTo(contato2.Nome));
                        
                        listaPessoa.ForEach(contato=>
                        {

                                Console.WriteLine(contato);

                                Console.WriteLine("deseja ir para o proximo: \nS - sim \nN - não ");
                                string op = Console.ReadLine();
                           
                        });
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine($"\nVocê tem {listaPessoa.Count()} contatos\n");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida!");
                        break;
                }
            } while (opc != 0); 
        }
    }
}     


