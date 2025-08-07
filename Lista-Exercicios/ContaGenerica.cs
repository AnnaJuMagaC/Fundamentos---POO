using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios
{
    public class ContaGenerica
    {
        public string Banco { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public decimal Saldo { get; set; }
        public ContaGenerica(string banco, int agencia, int conta, decimal saldo)
        {
            this.Banco = banco;
            this.Agencia = agencia;
            this.Conta = conta;
            this.Saldo = saldo;
        }
        public void Depositar(int valor)
        {
            this.Saldo += valor;
        }
        public void Sacar(int valor)
        {
            if (this.Saldo > 0 && this.Saldo > valor)
            {
                this.Saldo -= valor;
            }
        }

    }
}
