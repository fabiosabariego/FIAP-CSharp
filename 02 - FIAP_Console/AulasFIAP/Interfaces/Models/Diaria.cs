using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    internal class Diaria : Despesa
    {
        public double QtdeDiaria { get; set; }

        public override void CalcularDespesas(double valor)
        {
            QtdeDiaria = valor;
            ValorTotal = QtdeDiaria * 50;
        }

        public override void ListarDespesas()
        {
            Console.WriteLine($"Despesa Com: {Descricao} // Diarias: {QtdeDiaria} // Valor Total: R${Math.Round(ValorTotal, 2)}");
        }
    }
}
