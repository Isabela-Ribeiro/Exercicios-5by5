using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Poo
{  
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro carro = new Cadastro();
            Pessoas pessoa = new Pessoas();
            int opc;
            do
            {

                Console.WriteLine("Cadastro do motorista: ");
                Console.WriteLine("1-Cadastro\n2-Imprimir Dados do veiculo\n0-Sair");
                Console.WriteLine("Digite a opção :");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                         Console.Clear();
                         Console.WriteLine("\tCadastre o veiculo");
                         Console.Write("Modelo : ");
                         carro.Modelo = Console.ReadLine();
                         Console.Write("Cor : ");
                         carro.Cor = Console.ReadLine();
                         Console.Write("Chassis  ");
                         carro.Chassis = Console.ReadLine();
                         Console.Write("Ano : ");
                         carro.Ano = int.Parse(Console.ReadLine());
                         Console.Write("Placa : ");
                         carro.Placa = Console.ReadLine();
                         Console.Write("Renavan apenas numeros: ");
                         carro.Renavan = double.Parse(Console.ReadLine());
                         Console.Clear();

                         Console.WriteLine("\tCADASTRO DA PESSOA FISICA:");
                         Console.Write("Informe o seu nome :");
                         pessoa.Nome = Console.ReadLine();
                         Console.Write("Informe o seu CPF :");
                         pessoa.Cpf = double.Parse(Console.ReadLine());
                         Console.Write("Informe o seu Endereço completo:");
                         pessoa.Endereco = Console.ReadLine();
                         Console.WriteLine("Informe a data de nascimento dia/mes/ano:");
                         pessoa.Nasc = Console.ReadLine();
                         Console.WriteLine("Informe a Data de compra dia/mes/ano:");
                         pessoa.Data_Compra = Console.ReadLine();

                        Console.Clear();                
                        break;
                    case 2:
                        Console.Clear();
                        carro.ExibirDados();
                        pessoa.ExibirDados2();
                       
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção invalida!!");
                        break;
                }
            } while (opc != 0);
        }
    }
}
