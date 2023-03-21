using _02_Enumerator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Enumerator.Models
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public EstadoCivilEnum EstadoCivil { get; set; }

        public Funcionario(string Nome)
        {
            this.Nome = Nome;
        }
    }
}
