using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    internal abstract class Despesa
    {
        public string Descricao { get; set; } = "";
        public double ValorTotal { get; set; } = 0;

        public virtual void CadastrarDespesas(string descricao)
        {
            this.Descricao = descricao;
            this.ValorTotal = 0;
        }

        public abstract void CalcularDespesas(double valor);
        public abstract void ListarDespesas();
    }
}
