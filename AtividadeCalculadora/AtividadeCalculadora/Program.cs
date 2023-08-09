using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            Console.WriteLine("---------------------");
            Console.WriteLine("|    Calcular média  |");
            Console.WriteLine("---------------------");

            Console.WriteLine("---------------------");

            //Inserindo sua média
          
            Console.Write("Insira a nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("---------------------");

            Console.Write("Insira a nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("---------------------");

            Console.Write("Insira a nota 3: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("---------------------");

            Console.Write("Insira a nota 4: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("---------------------");

            //Calcular media

            media = (nota1 + nota1 + nota2 + nota3 + nota4) / 4 ;

            Console.WriteLine("-----------");
            Console.WriteLine($"Nota 1: {nota1}|");
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Console.WriteLine($"Nota 2: {nota2}|");
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Console.WriteLine($"Nota 3: {nota3} |");
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Console.WriteLine($"Nota 4: {nota4} |");
            Console.WriteLine("-----------");





        }
    }
}
