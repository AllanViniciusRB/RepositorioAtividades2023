using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimosDiversos
{
    internal class LacoDeRepeticao
    {
        static void Main()
        {
            Console.WriteLine(@"/ *-----------------------* \");
            Console.WriteLine("  |   Laço de Repetição   |");
            Console.WriteLine(@"\ *-----------------------* /");
            ExibirTexto();

            int contador = 0;

            while (contador <= 5)
            {
                Console.WriteLine($"  O valor do contador é: {contador}");
                contador++;
            }
            ExibirTexto();



            for (contador = 0; contador <= 5; contador++)
            {
                Console.WriteLine($"  O valor do contador é: {contador}");
            }
            ExibirTexto();

            contador = 0;

            do
            {
                Console.WriteLine($"  O valor do contador é: {contador}");
                contador++;

            } while (contador <= 5);
            ExibirTexto();

            string[] frutas = { "maçã", "banana", "laranja", "tomate" };

            for(int i =0; i < frutas.Length; i++)
            {
                Console.WriteLine(frutas[i]);
            }
            ExibirTexto();
            foreach(string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
            ExibirTexto();
        }

        static void ExibirTexto()
        {
            Console.WriteLine("=============================");
        }
    }
    
}
