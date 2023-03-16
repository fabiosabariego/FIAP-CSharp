using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LivroEbook.Models
{
    internal class Livro
    {
        // Classe Pai / Mestre
        protected string _titulo;
        protected string _autor;
        protected string _categoria;
        protected double _valor;

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public double Valor { get; set; }

        public void AplicarDesconto()
        {
            Valor = Valor - (Valor * 0.3);
        }
    }
}
