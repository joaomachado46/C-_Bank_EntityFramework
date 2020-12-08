using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Movimento
    {
        public int Id { get; set; }
        public int Levantamento { get; set; }
        public int Deposito { get; set; }
        public double ValorSaldo { get; set; }
        public double NovoSaldo { get; set; }
        public DateTime DataMovimento { get; set; }

        public int CartaoId { get; set; }
        public Cartao Cartao { get; set; }

        public double LevantamentoConta()
        {
            double calculo = ValorSaldo - Levantamento;
            NovoSaldo = calculo;
            DataMovimento = DateTime.Now;
            return calculo;

        }

        public double DepositoConta()
        {
            double calculo = ValorSaldo + Deposito;
            NovoSaldo = calculo;
            DataMovimento = DateTime.Now;
            return calculo;
        }
        public override string ToString()
        {
            StringBuilder sp = new StringBuilder();
            sp.AppendLine("Cartao: " + Cartao.NumeroCartao);
            sp.AppendLine("    Data: " + DataMovimento + ", Saldo Anterior: " + ValorSaldo + ", Novo Saldo: " + NovoSaldo);
            sp.AppendLine("");

            return sp.ToString();
        }
    }
}
