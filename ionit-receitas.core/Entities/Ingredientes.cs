using System;
using System.Collections.Generic;
using System.Text;

namespace ionit.receitas.core.Entities
{
    public class Ingredientes
    {
        public int idReceita { get; set; }
        public string Nome { get; set; }
        public string UnidadeMedida { get; set; }
        public string Quantidade { get; set; }
    }
}
