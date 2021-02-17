using System;
namespace Ex_Poo
{
	public class Cadastro
	{
        public Cadastro()
        {
			this.Ano = 0;
			this.Renavan = 0;
			this.Chassis = "";
			this.Placa = "";
			this.Modelo = "";
			this.Cor = "";
		}
		public Cadastro(int ano,double renavan,string chassis,string placa,string modelo,string cor)
		{
			this.Ano = ano;
			this.Renavan = renavan;
			this.Chassis = chassis;
			this.Placa = placa;
			this.Modelo = modelo;
			this.Cor = cor;
		}
		public double Renavan { get; set; }
			public string Chassis { get; set; }
			public string Placa { get; set; }
			public string Modelo { get; set; }
			public string Cor { get; set; }
			public int Ano { get; set; }

		public Pessoas pessoas;
		public void ExibirDados()
        {
			Console.WriteLine("Carro Cadastrado: Modelo :" + Modelo + " COR : " + this.Cor + " PLACA : " + this.Placa + " ANO : " + this.Ano + "CHASSIS : " + this.Chassis + " RENAVAN : " + this.Renavan );
        }
	}	
}
