using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Conta
    {
        public int Id { get; set; }
        public string NomeConta { get; set; }

        public TitularConta TitularConta { get; set; }
        
    }
}
