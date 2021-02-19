using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamicaEncadeada
{
    class FilaOs
    {
        public OrdemServico Head { get; set; }
        public OrdemServico Tail { get; set; }
        public int Cont { get; set; }

        public bool Vazia()
        {
            if ((Head == null) && (Tail == null)) 
                return true;
            return false;
        }
        public void Push(OrdemServico aux)
        {
            if (Vazia())
            {
                Head = aux;
                Tail = aux;
            }
            else
            {
                Tail.Proximo = aux;//Encadeamento da Nova os(aux)
                Tail = aux;//Atualizo o Tail
                Cont++;
            }
            Console.WriteLine("Elemento Inserido com sucesso");
        }
        public void Print()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossivel Imprimir! pilha Vazia");
            }
            else
            {
                OrdemServico aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;

                } while (aux != null);
                Console.WriteLine(">>>FIM DA IMPRESSAO<<<");
            }
        }
        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Lista Vazia");
            }
            else
            {
                Head = Head.Proximo;
                Console.WriteLine("Elemento removido com sucesso");
                if (Head == null)
                {

                    Tail = null;
                    Cont--;
                    Console.WriteLine("fila ESTÁ vazia!");
                }
            }
        }
      
        public void pesquisar(int pesq)
        {
            bool encontrar = false;
            if (Head == null)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                OrdemServico aux = Head;
                do
                {
                    if (pesq == aux.Numero)
                    {
                        encontrar = true;
                        Console.WriteLine(aux.ToString());
                    }
                    aux = aux.Proximo;
                } while (aux != null);
                if (!encontrar)
                {
                    Console.WriteLine("Ordem de Serviço não localizado");
                }

            }
        }
    }
}
