using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Triangulo.Models
{
    internal class Triangulo
    {
        public double X { get; set; }
        private double _x;

        public double Y { get; set; }
        private double _y;

        public double Z { get; set; }
        private double _z;

        public string Valida()
        {
            this._x = X;
            this._y = Y;
            this._z = Z;

            //Verifica o comprimento de cada lado deve ser menor que a soma dos outros 2
            if (_x < _y + _z && _y < _x + _z && _z < _x + _y &&)
            {
                //Verifica se e equilatero (tres lados iguais)
                if(_x == _y && _y == _z)
                {
                    return "Equilatero";
                }
                else
                {
                    return "Outro";
                }
            }
        }

    }
}
