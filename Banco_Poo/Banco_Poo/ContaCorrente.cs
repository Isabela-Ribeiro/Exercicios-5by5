using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Poo
{
     class ContaCorrente
    {
        
        private double _agencia;
        private double _saldo;
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public int NumeroCasa { get; set; }
        public string Cidade { get; set; }
        public double Numero { get; set; }

        public double Agencia 
        { 
            get
            {
                return _agencia;
            }
            set 
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            } 
        }
        
        public double Saldo 
        {
            get 
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }
        
        public void Depositar()
        {
            double valor;
            Console.WriteLine("Digite quanto irá depositar:");
            valor = int.Parse(Console.ReadLine());
            this._saldo += valor;
            Console.WriteLine("Deposito realizado com sucesso!");
        }
        public bool Sacar()
        {
            double valor;
            Console.WriteLine("Digite quanto irá sacar:");
            valor = int.Parse(Console.ReadLine());
            if (this._saldo < valor)
            {
                Console.WriteLine("Valor maior do que disponivel!");
                return false;
                
            }

            this._saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso!");
            return true;
        }
        public bool Tranferir()
        {
            Console.WriteLine("Conta Existente ag:210 , conta:12345");
            double valor;  
            Console.WriteLine("Digite a AGENCIA para:");
            int agen = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Conta para:");
            int conta = int.Parse(Console.ReadLine());

            Console.WriteLine("valor para a tranferencia");
            valor = double.Parse(Console.ReadLine());

            if (agen == 210 && conta == 12345)
            {
                if (this._saldo < valor)
                {
                    Console.WriteLine("valor maior que o saldo");
                    return false;
                }
                this._saldo -= valor;
                Console.WriteLine("Tranferencia realizado com sucesso!");

                return true;
            }
            else
            {
                Console.WriteLine("Conta inexistente!");
            }
            return false;
            
        }
    }
}
