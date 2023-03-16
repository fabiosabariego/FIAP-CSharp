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

        public Seguro(Pessoa pessoas, double valorAuto)
        {
            this.Pessoas = pessoas;
            this.ValorAuto = valorAuto;
        }

        public double CalcularSeguro()
        {
            if (Pessoas.Sexo == "M" && Pessoas.Idade < 24)
            {
                return Math.Round((ValorAuto * 0.20), 2);
            }
            else if (Pessoas.Sexo == "F")
            {
                return Math.Round((ValorAuto * 0.05), 2);
            }
            else
            {
                return Math.Round((ValorAuto * 0.10), 2);
            }
        }
    }
}
