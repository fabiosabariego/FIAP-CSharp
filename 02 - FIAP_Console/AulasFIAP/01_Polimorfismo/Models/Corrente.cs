using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Polimorfismo.Models
{
    internal class Corrente : Conta
    {
        public double Limite { get; set; }

        public override string Debitar(double valor)
        {
            if(valor <= _saldo)
            {
                _saldo -= valor;
                return ConsultarSaldo();
            }
            else if(valor <= (_saldo + Limite))
            {
                _saldo -= valor;
                return $"Saldo Insulficiente, foi usado o Cheque especial. Na conta: {ConsultarSaldo()}";
            }
            else
            {
                return $"Saldo Insulficiente. Na conta: {ConsultarSaldo()}";
            }

        }

        public override void AtualizarSaldo()
        {

            if(_saldo < 0)
            {
                _saldo *= 0.08;
            }

        }
    }
}
