using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimosDiversos
{
    internal class EstruturaCondicional
    {
        static void Main()
        {
            Console.WriteLine(@"/ *-----------------------* \");
            Console.WriteLine("  | Estrutura Condicional |");
            Console.WriteLine(@"\ *-----------------------* /");

            int nota = 0;

             if(nota > 7)
             {
                EscreverLinha();
                Console.WriteLine("Aluno está aprovado!");
                EscreverLinha();
            }
             if(nota >= 7)
             {
                EscreverLinha();
                Console.WriteLine("Aluno Aprovado!");
                EscreverLinha();
            }
            else
            {
                EscreverLinha();
                Console.WriteLine("Aluno Reprovado!");
                EscreverLinha();
            }
            EscreverLinha();
            Console.WriteLine(@"/ *-----------------------* \");
            Console.WriteLine("  | Resultado das notas   |");
            Console.WriteLine(@"\ *-----------------------* /");
            EscreverLinha();

            if (nota >9)
            {
                Console.WriteLine(@"/ *-----------------------* \");
                Console.WriteLine("   |     Aluno é nota  A   |");
                Console.WriteLine(@"\ *-----------------------* /");
            }
           

            else if(nota >= 7)
            {
                Console.WriteLine(@"/ *-----------------------* \");
                Console.WriteLine("   |     Aluno é nota  B   |");
                Console.WriteLine(@"\ *-----------------------* /");
            }
            
            else if(nota >= 5)
            {
                Console.WriteLine(@"/ *-----------------------* \");
                Console.WriteLine("   |     Aluno é nota  C   |");
                Console.WriteLine(@"\ *-----------------------* /");
            }
            
            else if (nota >= 3)
            {
                Console.WriteLine(@"/ *-----------------------* \");
                Console.WriteLine("   |     Aluno é nota  D   |");
                Console.WriteLine(@"\ *-----------------------* /");
            }
           
            else
            {
                Console.WriteLine(@"/ *-----------------------* \");
                Console.WriteLine("   |     Aluno é nota  E   |");
                Console.WriteLine(@"\ *-----------------------* /");
            }
            EscreverLinha();
            string cor = "vermelho";
            switch (cor.ToLower())
            {
                case "verde":
                Console.WriteLine("A cor é verde");
                    break;

                case "vermelho" :
                Console.WriteLine("A cor é vermelha");
                    break;

                case "azul":
                Console.WriteLine("A cor é azul");
                    break;

                default:
                
                Console.WriteLine("A cor não foi reconhecida");
                    break;
            }
        }
        static void EscreverLinha()
        {
            Console.WriteLine("~=====================================");
        }
    }
}
