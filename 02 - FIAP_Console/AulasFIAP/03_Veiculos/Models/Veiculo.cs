using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Veiculos.Models
{
    internal class Veiculo
    {
        public double ValorHora { get; set; }
        public double ValorAdicional { get; set; }
        public double Horas { get; set; }

        public virtual double DoTotal()
        {
            return ValorHora + ValorAdicional * (Horas - 1);
        }

        public virtual string DoViewCupom()
        {
            return $"Total a pagar: {DoTotal()}";
        }

    }
}
