using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Produto_e_Cliente
{
    internal class Cliente : Produto
    {

        private string nome { get; set; }
        private int IdCliente { get; set; }

        public string Nome
        {
            get { return nome; }
            set
            {
                value = "Allanzin";
            }
        }

        public int idCliente
        {
            get { return IdCliente; }
            set
            {
                if (value > 0)
                {
                    IdCliente = 1;
                }
                else
                {
                    Console.WriteLine("Nenhum cliente selecionado!");
                }
            }
        }

    }
}
   

