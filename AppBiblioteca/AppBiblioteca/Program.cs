 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();

            livro.id= 1;
            livro.titulo = "Harry Potter";
            livro.Ano = 2001;
            livro.NumeroPagina = 50;
            livro.MostrarDetalhes();

            Console.WriteLine("===================================");

            LivroDigital LivroDigital =new LivroDigital();
            LivroDigital.id = 2;
            LivroDigital.titulo = "Sherlock Holmes";
            LivroDigital.Ano = 2013;
            LivroDigital.NumeroPagina=150;
            LivroDigital.MostrarDetalhes();

            Console.WriteLine("===================================");



        }
    }
}
