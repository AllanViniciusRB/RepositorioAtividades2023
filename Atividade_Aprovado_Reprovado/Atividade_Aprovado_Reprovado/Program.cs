using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Aprovado_Reprovado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inserindo notas

            double nota1, nota2, nota3, nota4, media;


            Console.Write("Insira sua nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira sua nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira sua nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira sua nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine($"Você está aprovado! {media}");
            }

            else
            {
                Console.WriteLine($"Você foi reprovado!! {media}");
            }
        }
    }
}
