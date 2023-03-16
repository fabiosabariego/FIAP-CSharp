using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LivroEbook.Models
{
    internal class LivroFisico : Livro
    {
        public double GetTavaImpressao()
        {
            return Valor * 1.1;
        }
    }
}
