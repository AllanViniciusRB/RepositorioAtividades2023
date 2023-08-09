using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimosDiversos
{
    internal class TrabalhandoLista
    {
        static void ImprimeLista(List<int> lista, String titulo = "|=================================================================|") 
        {
            Console.WriteLine("|=================================================================|");
            Console.WriteLine($"                  {titulo}");
            Console.WriteLine("|=================================================================|");
            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }
           
        }
        static void Main()
        {
            List<int> lista = new List<int>(); // new representa uma nova instância de lista.

            //Add: adicionando elemento na lista
            lista.Add(1);
            lista.Add(50);
            lista.Add(40);
            lista.Add(10);
            lista.Add(90);
            lista.Add(70);

          

            ImprimeLista(lista,"Adicionando Elemento na Lista");

       

            //Remove: Remove a primeira ocorrência de um elemento.

            lista.Remove(10);

            ImprimeLista(lista, "Remove a primeira ocorrência de um elemento.");

           
            //RemoveAt: Remove o elemento de um indice.

            lista.RemoveAt(0);

            ImprimeLista(lista, "Remove o elemento de um indice.");


            //Sort: Ordenar os elementos em ordem crescente

            lista.Sort();
            ImprimeLista(lista, "Ordem crescente");

            //Reverse: Ordenar os elementos em ordem decrescente
            lista.Reverse();
            ImprimeLista(lista, "Ordem decrescente");

            //Cont: Retorna a quantidade de elementos na lista

            int numeroItem = lista.Count;

            Console.WriteLine($"Existe {numeroItem} itens na lista");

            //Contains: verifica se o lista contém um dterminado elemento

            if (lista.Contains(40)) //Estrutura condicional
            {
                Console.WriteLine("Foi encontrado o item na lista! ");

            }
            else
            {
                Console.WriteLine("Não foi encontrado nenhum item na lista");
            }
            //Insert: Insere um elemento em um determinado indice da lista

            lista.Insert(2, 45);

            ImprimeLista(lista, "Inserindo o numero 45");

            //Clear = limpar os itens da lista.

             lista.Clear();
        }
        static void EscreverLinha()// Isso é um metodo, um bloco de códigos que se repetem varias vezes.
        {

            Console.WriteLine("|=================================================================|");
        }

       
    }
}
