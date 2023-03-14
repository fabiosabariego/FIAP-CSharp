using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Conta.Models
{
    internal class Conta
    {
        //Atributos -> Sao as Caracteristicas do Objeto
        //Atributo -> Visibilidade (modificador de acesso), tipo e nome
        public string numeroConta;
        private int _agencia;
        private double _saldo;

        //Set -> Inserir / modificar o atributo
        public void setSaldo(double valor)
        {
            this._saldo = valor;
        }

        //Get -> Retorna o valor que esta no atributo
        public double getSaldo()
        {
            return _saldo;
        }

        public int Agencia 
        {
            get 
            {
                return _agencia;
            }
            set
            {
                this.Agencia = value;
            }
        }
    }
}
