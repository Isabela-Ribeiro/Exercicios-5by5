using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ContaCorrente clienteConta = new ContaCorrente();
            int id=0;
           
            int opc;
            do
            {
                Console.WriteLine("\tMENU PRINCIPAL");
                Console.WriteLine("1-CADASTRAR\n2-DEPOSITO\n3-SAQUE\n4-TRANFERENCIA\n5-CONSULTAR SALDO\n0-SAIR ");
                Console.WriteLine("Digite a opção desejada: ");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("\tCasdastrar Novo Titular");
                       
                        Console.Write("Nome : ");
                        clienteConta.Nome = Console.ReadLine();
                        Console.Write("Informe o CPF sem os ponto : ");
                        clienteConta.Cpf = Console.ReadLine();
                        Console.Write("Rua :");
                        clienteConta.Rua = Console.ReadLine();
                        Console.Write("Numero da rsidencia:");
                        clienteConta.NumeroCasa = int.Parse(Console.ReadLine());
                        Console.Write("Cidade :");
                        clienteConta.Cidade = Console.ReadLine();
                        Console.Write("Agencia :");
                        clienteConta.Agencia = int.Parse(Console.ReadLine());
                        Console.Write("conta : ");
                        clienteConta.Numero = int.Parse(Console.ReadLine());
                        Console.Clear();

                        break;
                    case 2:
                        Console.WriteLine("DEPOSITAR");
                        
                        clienteConta.Depositar();
                        
                        break;
                    case 3:
                        Console.WriteLine("SAQUE");
                        clienteConta.Sacar();
                        break;
                    case 4:
                        Console.WriteLine("TRANSFERIR");
                        clienteConta.Tranferir();
                        break;
                    case 5:
                        Console.WriteLine("SALDO");
                        Console.WriteLine("Seu saldo é : " +clienteConta.Saldo);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção Invalida!");
                        break;
                }
            }while(opc != 0);
            Console.ReadKey();


        }
       
    }
}
