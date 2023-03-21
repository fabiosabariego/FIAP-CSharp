using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Polimorfismo.Models
{
    internal class Poupanca : Conta
    {

        public double ReajusteMensal { get; set; }

        public override void AtualizarSaldo()
        {
            _saldo += ReajusteMensal;
        }

    }
}
