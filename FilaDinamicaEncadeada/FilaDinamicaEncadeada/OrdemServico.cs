using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamicaEncadeada
{
    class OrdemServico
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int Prazo { get; set; }
        public  OrdemServico Proximo { get; set; }

        public override string ToString()
        {
            return "\n>>>Dados da O.S<<<\nNumero da O.S: "+Numero+"\nTipo: "+Tipo +"\nDescrição:"+Descricao+"\nData do Pedido:"+DataCriacao +"\nPrazo em dia:"+Prazo; 
        }
    }
}
