﻿using System.Collections.Generic;

namespace ionit.receitas.core.Entities
{
    /// <summary>
    /// Defines the invoice model.
    /// </summary>
    public class Receita
    {
        #region Properties

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Gets or sets the Titulo.
        /// </summary>
        public string Titulo { get; set; }
        public List<Ingredientes> Ingredientes { get; set; }
        public string ModoPreparo { get; set; }
        public string TempoPreparo { get; set; }

        #endregion
    }
}
