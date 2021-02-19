using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamicaEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaOs minhaFila = new FilaOs{Head=null , Tail=null, Cont = 0};
            OrdemServico ord = new OrdemServico();
            int opc;
            do
            {
                Console.WriteLine("\tMENU :");
                Console.WriteLine("1-INSERIR \n2-REMOVER \n3-IMPRIMIR PILHA\n4-QUANTIDADE DE ELEMENTOS NA PILHA\n5-BUSCAR POR NUMERO\n0-SAIR");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("\tCADASTRAR O S");
                        Console.Write("Informe o numero da Ordem: ");
                        int num = int.Parse(Console.ReadLine());
                        Console.Write("Tipo de Ordem: ");
                        string tipo = Console.ReadLine();
                        Console.Write("Descrição do serviço: ");
                        string desc = Console.ReadLine();
                        Console.Write("Prazo para Entrega: ");
                        int prazo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Data e Hora: " + DateTime.Now +"\n");

                        minhaFila.Push(new OrdemServico
                        {
                            Numero = num,
                            Tipo = tipo,
                            Descricao = desc,
                            DataCriacao = DateTime.Now,
                            Prazo = prazo,
                            Proximo = null
                        });
                        break;
                    case 2:
                        minhaFila.Pop();
                        break;
                    case 3:
                        minhaFila.Print();
                        break;
                    case 4:
                        Console.WriteLine("CONTADOR: ");
                        Console.WriteLine("O total de ordens : " + minhaFila.Cont);
                        break;
                    case 5:
                        Console.WriteLine("PESQUISAR ORDEM DE SERVIÇO");
                        Console.WriteLine("Digite o numero da Ordem de Serviço");
                        int pesq = int.Parse(Console.ReadLine());
                        minhaFila.pesquisar(pesq);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção Invalida!");
                        break;
                }
            } while (opc!=0);         
        }
    }
}
