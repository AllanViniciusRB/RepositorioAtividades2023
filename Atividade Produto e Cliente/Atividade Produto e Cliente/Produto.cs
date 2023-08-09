using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Produto_e_Cliente
{
    internal class Produto
    {
        private int IdProduto;
        private string nomeProduto { get; set; }
        private double Valor { get; set; }
        
        public int idProduto
        {
            get { return IdProduto;}
            set
            {
                if(value >0)
                {
                    IdProduto = value;
                }
                else
                {
                    Console.WriteLine("Nenhum produto identificado!");
                }
            }
        }
        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = "Freioada"; }
        }
        public double valor
        {
            get { return Valor; }
            set { Valor = 1.99; }
        }
    }
}
