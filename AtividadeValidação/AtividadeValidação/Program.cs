using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AtividadeValidação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados a serem inseridos
            string CPF;
            int[] x = new int[11];

            //Array do primeiro digito
            int [] dig1 = {10, 9, 8, 7, 6, 5, 4, 3, 2};
            int soma=0;
            int total = 0;
            int resto = 0;

            //Array do segundo digito
            int[] dig2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] soma2 = 0;
            int total2 = 0;
            int resto2 = 0;


            //Estrutura de repetição para verificar os dados.

            Console.WriteLine("Insira seu CPF: ");
            CPF = Console.ReadLine();
            int[] numeroInteiro = CPF.Select(numero => Convert.ToInt32(numero.ToString())).ToArray();

  
        }
    }
}
