using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    internal class Alimentacao : Despesa
    {
        public string NomeRestaurante { get; set; } = "";

        public override void CadastrarDespesas(string descricao)
        {
            base.CadastrarDespesas(descricao);
        }

        public override void CalcularDespesas(double valor)
        {
            ValorTotal = valor * 18;
        }

        public override void ListarDespesas()
        {
            Console.WriteLine($"Despesa Com: {Descricao} // Nome do Restaurante: {NomeRestaurante} // Valor Total: R${Math.Round(ValorTotal, 2)}");
        }

    }
}
