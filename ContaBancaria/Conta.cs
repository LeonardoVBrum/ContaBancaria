using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ContaBancaria
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Nome { get; set; }

        public double SaldoInicial { get; set; }

        public Conta(int numero,  string nome)
        {
            Nome = nome;
            Numero = numero;
            
        }
        public Conta(int nuemero, string nome, double saldo) : this (nuemero, nome) 
        {
            SaldoInicial = saldo;
        }

        public void AumentarSaldo(double saldo)
        {
            SaldoInicial = SaldoInicial + saldo;
        }
        public void SacarDinheiro(double saldo)
        {
            SaldoInicial = SaldoInicial - 0.3;
        }
        public override string ToString()
        {
            return  "Conta: "
                    + Numero
                    + ", Titular:"
                    + Nome
                    + ", Saldo: $ "
                    + SaldoInicial.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
