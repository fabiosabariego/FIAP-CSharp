using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Cliente.Models
{
    internal class Cliente
    {
        public int Codigo { get; set; }
        private int _codigo;

        public string Nome { get; set; }
        private string _nome;

        public void Print()
        {
            this._codigo = Codigo;
            this._nome = Nome;

            Console.WriteLine($"Nome: {_nome}");
            Console.WriteLine($"Codigo: {_codigo}");
        }

    }
}
