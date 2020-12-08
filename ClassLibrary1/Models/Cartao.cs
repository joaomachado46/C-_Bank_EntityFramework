using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrary1
{
    public class Cartao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NumeroCartao { get; set; }
        public DateTime DataValidade { get; set; }
        public double Saldo { get; set; }

        public ICollection<Movimento> Movimentos { get; set; }

        public ICollection<Emprestimo> Emprestimos { get; set; }

        [ForeignKey("TipoDeConta")]
        public int? IdTipoDeConta { get; set; }
        public TipoDeConta TipoDeConta { get; set; }

        public ICollection<CartaoTitular> CartoesTitulares { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("DADOS DAS CONTAS:");
            sb.AppendLine("NOME: " + Nome);
            sb.AppendLine("NÚMERO CARTÃO: " + NumeroCartao);
            sb.AppendLine("DATA VALIDADE: " + DataValidade.ToString("dd/MM/yyyy"));
            sb.AppendLine("SALDO: $" + Saldo);
            sb.AppendLine("");

            return sb.ToString();
        }
    }
}
