using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_Polimorfismo.Models
{
    internal abstract class Conta
    {

        protected double _saldo;

        public string ConsultarSaldo()
        {
            return $"R${(Math.Round(_saldo, 2)).ToString()}";
        }

        public string Creditar(double valor)
        {
            _saldo += valor;
            return ConsultarSaldo();
        }

        public virtual string Debitar(double valor)
        {
            string semSaldo = "";

            if(valor <= _saldo)
            {
                _saldo -= valor;
                return ConsultarSaldo();
            }
            else
            {
               return $"Saldo Insulficiente, valor na conta: {ConsultarSaldo()}";
            }

        }

        public abstract void AtualizarSaldo();

    }
}
