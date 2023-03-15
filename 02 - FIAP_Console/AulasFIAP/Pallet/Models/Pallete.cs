using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pallet.Models
{
    internal class Pallete
    {
        private string _codigo;
        private double _largura;
        private double _profundidade;
        private double _altura;
        private double _peso;
        private double _pesoMaxSuportado;

        public string Codigo { get; set; }
        public double Largura { get; set; }
        public double Profundidade { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public double PesoMaxSuportado { get; set; }

        //Criando o primeiro construtor - Vazio
        public Pallete()
        {

        }

        //Criando o segundo construtor - Com 2 parametros
        public Pallete(string codigo, double pesoMaxSup)
        {
            this._codigo = codigo;
            this._largura = 400;
            this._profundidade = 600;
            this._altura = 420;
            this._peso = 3.35;
            this._pesoMaxSuportado = pesoMaxSup;
        }

        public string Consultar()
        {
            return $"Codigo: {_codigo}  //  (LxPxA): ({_largura}x{_profundidade}x{_altura})  //  Peso: {_peso}  //  Peso Max Suportado: {_pesoMaxSuportado})";
        }
    }
}
