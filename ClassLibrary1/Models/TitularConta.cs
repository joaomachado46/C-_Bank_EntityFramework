using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrary1
{
    public class TitularConta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Cidade { get; set; }
        public string Email { get; set; }
        public int Senha { get; set; }

        public ICollection<Emprestimo> Emprestimos { get; set; }

        public ICollection<CartaoTitular> CartoesTitulares { get; set; }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DADOS DO TITULAR:");
            sb.AppendLine("NOME: " + Nome);
            sb.AppendLine("MORADA: " + Morada);
            sb.AppendLine("CIDADE: " + Cidade);
            sb.AppendLine("EMAIL: " + Email);
            sb.AppendLine("");

            return sb.ToString();
        }
    }
}
