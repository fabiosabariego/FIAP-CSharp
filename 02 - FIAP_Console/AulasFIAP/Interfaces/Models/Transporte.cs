using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    internal class Transporte : Despesa
    {
        public double KmPercorrido { get; set; }
        public double ValorPedagios { get; set; }

        public override void CalcularDespesas(double valor)
        {
            ValorPedagios = valor;
            ValorTotal = (KmPercorrido * 3) + ValorPedagios;
        }

        public override void ListarDespesas()
        {
            Console.WriteLine($"Despesa Com: {Descricao} // Km Percorridos: {KmPercorrido}Km // Valor Pedagios: R${Math.Round(ValorPedagios, 2)} // Valor Total: R${Math.Round(ValorTotal, 2)}");
        }

    }
}
