using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Veiculos.Models
{
    internal class Segurado : Veiculo
    {
        public double Seguro { get; set; }

        public Segurado(double seguro)
        {
            this.Seguro = seguro;
        }

        public double DoDesconto()
        {
            return base.DoTotal() * this.Seguro / 100;
        }

        public override double DoTotal()
        {
            return base.DoTotal() - DoDesconto();
        }

        public override string DoViewCupom()
        {
            return $"Subtotal: R${Math.Round(base.DoTotal(), 2)} // Desconto: R${Math.Round(DoDesconto(), 2)} // Total a Pagar: R${Math.Round(DoTotal(), 2)}";
        }
    }
}
