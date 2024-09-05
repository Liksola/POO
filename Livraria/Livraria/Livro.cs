using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public string Genero { get; set; }
        public string ISBN { get; set; }

        public Livro(string titulo, string autor, int ano, string genero, string iSBN)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            Genero = genero;
            ISBN = iSBN;
        }
    }
}
