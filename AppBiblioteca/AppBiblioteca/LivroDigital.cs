using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class LivroDigital : Livro
    {
        public string TipoArquivo;
        private int TamanhoMB;

        public int tamanhoMB
        {
            get { return TamanhoMB; }
            set
            {
                if (value > 0)
                {
                    TamanhoMB = value;
                }
                else
                {
                    Console.WriteLine("Tamanho do arquivo inválido.");
                }

            }
        }
        public override void MostrarDetalhes()
        {
            base.MostrarDetalhes();
            Console.WriteLine($"O tipo de arquivo é: {TipoArquivo}");
            Console.WriteLine($"O tamanho do arquivo é {TamanhoMB} MBS.");
        }
    }
}
