using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ClassLibrary1
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public string TipoEmprestimo { get; set; }
        public int Mensalidade { get; set; }
        public int NumeroContrato { get; set; }

        [ForeignKey("Cartao")]
        public int? IdCartao { get; set; }
        public Cartao Cartao { get; set; }

        [ForeignKey("TitularConta")]
        public int? IdTitularConta { get; set; }
        public TitularConta TitularConta { get; set; }
    }
}
