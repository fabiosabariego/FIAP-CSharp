using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Heranca.Models
{
    internal class Funcionario
    {
        //Superclass / Classe Mae / Classe Base
        //Generalizacao (Classe onde guardamos os parametros gerais do Objeto final
        public string Nome { get; set; }
        public double Salario { get; set; }

        public double CalcularBonificacao()
        {
            return Salario * 0.05;
        }

    }
}
