using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoListaDinamicaEnc
{
    class ListaContatos
    {
        public Pessoa Head { get; set; }
        public Pessoa Tail { get; set; }
        public int Cont { get; set; }

        public bool Vazia => Cont == 0;
        

        public void Push(Pessoa aux)
        {
            
            if (Vazia)
            {
                Head = aux;
                Tail = aux;
                Console.WriteLine("Contato salvo!");
            }
            else
            {

                if (aux.Nome.CompareTo(Tail.Nome) >= 0) // Inserir novo "último" elemento
                {
                    Tail.Proximo = aux;
                    Tail = aux;

                    Console.WriteLine("Contato salvo!");
                }
                else
                {
                    if (aux.Nome.CompareTo(Head.Nome) < 0)// Inserir novo "primeiro" elemento
                    {
                        aux.Proximo = Head;
                        Head = aux;

                        Console.WriteLine("Contato salvo!");
                    }
                    else // Inserir no "meio" da Lista
                    {
                        Pessoa aux1 = Head;
                        do
                        {
                            if (aux.Nome.CompareTo(aux1.Proximo.Nome) < 0)
                            {
                                aux.Proximo = aux1.Proximo;
                                aux1.Proximo = aux;

                                Console.WriteLine("Contato salvo");
                                break;
                            }
                            aux1 = aux1.Proximo;
                        } while (true);
                    }
                }
            }
            Cont++;
        }

        public void Print()
        {
            if (Vazia)
            {
                Console.WriteLine("Impossível Imprimir! Lista vazia!");
                Console.ReadKey();
            }
            else
            {

                Pessoa aux = Head;
                Console.WriteLine("\n>>> CONTATOS NA LISTA <<<\n");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                } while (aux!=null);
                Console.WriteLine("\n>>> FIM <<<");
            }
        }
        public void PrintIndividual()
        {
            if (Vazia)
            {
                Console.WriteLine("Impossível Imprimir! Lista vazia!");
                Console.ReadKey();
            }
            else
            {
                int escolha = 0;
                Pessoa aux = Head;
                do
                {
                    if (aux == null)
                    {
                        Console.WriteLine(">>>Fim<<");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(aux);
                        aux = aux.Proximo;

                        Console.WriteLine("Quer passar para outro contato ?\n1-sim\n0-não");
                        escolha = int.Parse(Console.ReadLine());
                    }      
                } while (escolha == 1);
            }
        }
        public void Remover(string nome)
        {
            bool achou = false;
            if (Vazia)
            {
                Console.WriteLine("Não ha contato para remover");

            }
            else
            {
                //remover o elemnto da cabeça, o primeiro elemento
                if (nome.CompareTo(Head.Nome)==0)
                {
                    Head = Head.Proximo;
                    if (Head == null)//só entra aqui quando não ha nada na lista
                    {
                        Tail = null;
                        achou = true;
                    }
                }
                else
                {
                    Pessoa aux = Head;
                    while (aux.Proximo != null && nome.CompareTo(aux.Proximo.Nome) >= 0)
                    {
                        if (nome.CompareTo(aux.Proximo.Nome) == 0)//Achei o elemento para remover
                        {
                            aux.Proximo = aux.Proximo.Proximo;
                            achou = true;
                            break;
                        }
                        aux = aux.Proximo;
                    }
                    //Se remover o último elemento
                    if (aux == null)//Criei o "Novo Último"
                        Tail = aux;  // tail deve ser reposicionada
                }
                if (achou)
                    Console.WriteLine("Elemento Removido!");
                else
                    Console.WriteLine("Elemento Não Localizado!");
                Console.ReadKey();
                return;

            }
        }
               
               
        public void Pesquisar(string pesq)
        {
            bool encontrar = false;
            if (Head == null)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                Pessoa aux = Head;
                do
                {
                    if (pesq.ToUpper() == aux.Nome.ToUpper())
                    {
                        encontrar = true;
                        Console.WriteLine(aux.ToString() + "\n");
                    }
                    //Vai percorrer a lista
                    aux = aux.Proximo;
                } while (aux != null);
                if (!encontrar)
                {
                    Console.WriteLine("não localizado");
                }
            }
        }
    }
}
