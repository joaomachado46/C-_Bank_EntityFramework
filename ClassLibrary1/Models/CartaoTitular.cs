using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace ClassLibrary1
{
    public class CartaoTitular
    {
        public int Id { get; set; }

        [ForeignKey("Cartao")]
        public int IdCartao { get; set; }
        public Cartao Cartao { get; set; }

        [ForeignKey("TitularConta")]
        public int IdTitular { get; set; }
        public TitularConta TitularConta { get; set; }

    }
}
