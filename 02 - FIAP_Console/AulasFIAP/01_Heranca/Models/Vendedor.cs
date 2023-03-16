using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Heranca.Models
{
    internal class Vendedor : Funcionario
    {
        public double CalculoComissao(double valorVendido)
        {
            return Salario + (valorVendido * 1.05);
        }
    }
}
