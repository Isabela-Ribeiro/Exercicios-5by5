using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica_simplesmente_encadeada
{
    class Pilha_Dinamica_livro
    {
        public Livro Topo { get; set; }
        public int cont { get; set; }


        public void Push(Livro aux)
        {
            //if (vazia()) //Verifica se a pilha está vazia
            //{
            //    Topo = aux;
            //}
            //else
            //{
            aux.Anterior = Topo;
            Topo = aux;
            cont++;
            //}
            Console.WriteLine("Elemento inserido com sucesso!");
            return;
        }

        private bool Vazia()
        {
            if (Topo == null)
                return true;
            return false;
        }

        public void Imprimir()
        {
            if (Vazia())
            {


            }
            else
            {
                Livro aux = Topo;
                Console.WriteLine("Os elementos na pilha são:");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                } while (aux != null);
                Console.WriteLine(">>>FIM<<");
            }
        }

        public void pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível Remover! Pilha Vazia!");
                Console.ReadKey();
            }
            else
            {
                Topo = Topo.Anterior;
                cont--;
                Console.WriteLine("Elemento Removido!");
            }
        }
        public void pesquisar(string tlivro)
        {
            bool encontrar = false;
            if (Topo==null)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                Livro aux = Topo;
                do
                {
                    if (tlivro.ToUpper() == aux.Titulo.ToUpper())
                    {
                        encontrar = true;
                        Console.WriteLine(aux.ToString());
                    }
                    aux = aux.Anterior;
                } while (aux != null);
                if (!encontrar)
                {
                    Console.WriteLine("Livro não localizado");
                }

            }
        }
    }
}
