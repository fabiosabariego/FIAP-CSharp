using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    internal class GerenciadorDespesas
    {
        public int QtdeAlimentacao { get; set; }
        public int QtdeTransporte { get; set; }
        public int QtdeDiaria { get; set; }
        public double TotalAlimentacao { get; set; }
        public double TotalTransporte { get; set; }
        public double TotalDiaria { get; set; }
        public double TotalDespesas { get; set; }

        public void AnalisarDespesas(Despesa despesa)
        {
            if (despesa.GetType().Name == "Alimentacao")
            {
                QtdeAlimentacao++;
                TotalAlimentacao += despesa.ValorTotal;
                TotalDespesas = Math.Round((TotalDespesas + TotalAlimentacao), 2);
            }
            else if (despesa.GetType().Name == "Transporte")
            {
                QtdeTransporte++;
                TotalTransporte += despesa.ValorTotal;
                TotalDespesas = Math.Round((TotalDespesas + TotalTransporte), 2);
            }
            else if (despesa.GetType().Name == "Diaria")
            {
                QtdeDiaria++;
                TotalDiaria += despesa.ValorTotal;
                TotalDespesas = Math.Round((TotalDespesas + TotalDiaria), 2);
            }

        }

    }
}
