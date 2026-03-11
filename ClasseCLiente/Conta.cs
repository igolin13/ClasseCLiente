using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos
{
    public class Conta
    {

        public Conta(long numero, decimal saldo)
        {
            _saldo = saldo;
            _numero = numero;

        }

        private long _numero;
        private decimal _saldo;

        public long Numero
        {
            get => _numero;

            private set {
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

       

        public void Deposito(decimal valor)
        {
            _saldo += valor;
        }
        public void Saque(decimal valor)
        {
          _saldo -= valor;
        }

    }
}
