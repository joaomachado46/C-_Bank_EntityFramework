using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class TipoDeConta
    {
        public int Id { get; set; }
        public string NomeConta { get; set; }

        public ICollection<Cartao> Cartoes { get; set; }

    }
}
