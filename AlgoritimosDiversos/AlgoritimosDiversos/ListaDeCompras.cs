using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlgoritimosDiversos
{
    internal class ListaDeCompras
    {
        static void ExibirLinha()
        {
            Console.WriteLine("================================================");
        }
        static void ExibirLogo()
        {
            Console.WriteLine(@"
███╗░░░███╗███████╗██████╗░░█████╗░░█████╗░██████╗░██╗███╗░░██╗██╗░░██╗░█████╗░  ██████╗░░█████╗░
████╗░████║██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║████╗░██║██║░░██║██╔══██╗  ██╔══██╗██╔══██╗
██╔████╔██║█████╗░░██████╔╝██║░░╚═╝███████║██║░░██║██║██╔██╗██║███████║██║░░██║  ██║░░██║██║░░██║
██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██╗██╔══██║██║░░██║██║██║╚████║██╔══██║██║░░██║  ██║░░██║██║░░██║
██║░╚═╝░██║███████╗██║░░██║╚█████╔╝██║░░██║██████╔╝██║██║░╚███║██║░░██║╚█████╔╝  ██████╔╝╚█████╔╝
╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░  ╚═════╝░░╚════╝░

░██████╗███████╗██╗░░░██╗  ███████╗███████╗
██╔════╝██╔════╝██║░░░██║  ╚════██║██╔════╝
╚█████╗░█████╗░░██║░░░██║  ░░███╔═╝█████╗░░
░╚═══██╗██╔══╝░░██║░░░██║  ██╔══╝░░██╔══╝░░
██████╔╝███████╗╚██████╔╝  ███████╗███████╗
╚═════╝░╚══════╝░╚═════╝░  ╚══════╝╚══════╝");
        }
        static void Main()
        {
            //Caso a lista eseteja vazia retornar o resto "Lista de Compras Vazia"
            //Caso contrario imprimir todos os itens na tela (estrutura condiciona if

            List<String> listaDeCompra = new List<String>();

            ExibirLogo();
            ExibirLinha();
            Console.WriteLine("::::::::! Programa de lista de Compras! ::::::::");


            while (true)
            {
                Console.Write("Digite um item para adicionar à lista: ");

                string item = Console.ReadLine();
                

                if (item.ToLower() == "parar")
                {
 
                    break;

                }
                else if(item == "")
                {
                    
                    Console.WriteLine("Nenhum item identificado");

                }
                else
                {
                    ExibirLinha();
                    listaDeCompra.Add(item);
                    Console.WriteLine("Item adicionado com sucesso! ");
                }
                ExibirLinha();
                
            }
            Console.Clear();

            ExibirLogo();
            ExibirLinha();
            Console.WriteLine("---------Lista de Compras---------");
           

            var grupos = listaDeCompra.GroupBy(item => item);

            foreach (var grupo in grupos)
            {
                string item = grupo.Key;
                int quantidade = grupo.Count();
                Console.WriteLine($"{quantidade} {item}");
            }
        }

    }
 }



