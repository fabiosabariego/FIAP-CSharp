using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AppSeguro.Models
{
    internal class Seguro
    {

        public double ValorAuto { get; set; }
        public Pessoa Pessoas { get; set; }


        public double CalcularSeguro()
        {
            if (Pessoas.Sexo.Equals("M") && Pessoas.Idade < 24)
            {
                return Math.Round((ValorAuto * 1.20), 2);
            }
            else if (Pessoas.Sexo.Equals("F"))
            {
                return Math.Round((ValorAuto * 1.05), 2);
            }
            else
            {
                return Math.Round((ValorAuto * 1.10), 2);
            }
        }
    }
}
