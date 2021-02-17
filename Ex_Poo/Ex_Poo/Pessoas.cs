using System;
namespace Ex_Poo
{
    public class Pessoas :Cadastro
    {

    
            public double Cpf { get; set; }
            public string Nome { get ; set ; }
            public string Endereco { get; set; }
            public string Nasc { get; set; }
            public string Data_Compra { get; set; }
       
        public void ExibirDados2()
        {
            Console.WriteLine("Cadastro da Pessoa Dados de " + this.Nome + " CPF: " + this.Cpf + " ENDEREÇO : " + this.Endereco + "\n DATA DE NASCIMENTO : " + this.Nasc + " DATA DA COMPRA : " + this.Data_Compra);
        }

    }
    
}
   
