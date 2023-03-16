using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Heranca.Models
{
    internal class Gerente : Funcionario
    {
        //Classe Filha / Classe que herdara parametros de Funcionarios

        public double Gratificacao { get; set; }
    }
}
