using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Investimento.Models
{
    internal class Investimento
    {
        private double _valor;

        public double Valor { get; set; }
        public string Tipo { get; set; }

        public double Correcao()
        {
            this._valor = Valor;

            if(Tipo == "p")
            {
                Valor *= 1.03;
            }
            else if (Tipo == "r")
            {

                Valor *= 1.04;
            }
            else
            {
                Valor = Valor;
            }
            return Valor;
        }
    }
}
