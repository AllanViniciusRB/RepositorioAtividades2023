using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimosDiversos
{
    internal class TrabalhandoArray
    {
        static void Main()
        {
            int[] numero = { 10, 25, 30, 5, 50 };// quando define um valor ele se torna statico (se torna um array com 5 elementos)
            int[] numerosNota = new int[5] { 10, 5, 8, 8, 5 };//
            int[] notas = new int[4];

            notas[0] = 10; // Posição 0 recebe 10
            notas[1] = 8; //Posição 1 recebe 8
            notas[2] = 3; //Posição 2 recebe 3
            notas[3] = 10; //Posição 3 recebe 10 
            
            foreach(int nota in numerosNota) // Comando para listar(escrever) na tela o array.
            {
                Console.WriteLine(nota);
            }

        }
    }
}
