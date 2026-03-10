using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos
{
    public class Conta
    {
        private long _numero;
        private decimal _saldo;

        public long Numero
        {
            get => _numero;

            set {
                _numero = value;
            }

        }

        public decimal Saldo
        {
            get => _saldo;
            private set
            {
                _saldo = value;
            }
        }

        public Conta(long numero, decimal saldo)
        {
            _saldo = saldo;
            _numero = numero;

        }

        public void Deposito(decimal valor)
        {
           
        }
        public void Saque(decimal valor)
        {

        }

    }
}
