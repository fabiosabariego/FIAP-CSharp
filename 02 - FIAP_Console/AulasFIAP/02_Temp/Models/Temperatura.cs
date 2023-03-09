using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Temp.Models
{
    internal class Temperatura
    {
        //Atributos
        public double valor;

        //Metodo Celsius
        public double Celsius()
        {
            return (5 * valor - 160) / 9;
        }

        public double Fahrenheit()
        {
            return (9 * valor + 160) / 5;
        }

    }

    
}
