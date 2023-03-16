using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LivroEbook.Models
{
    internal class Ebook : Livro
    {
        private string _marcaDagua;
        public string MarcaDagua { get; set; }


        public void AplicarDesconto()
        {
            Valor = Valor - (Valor * 0.15);
        }
    }
}
