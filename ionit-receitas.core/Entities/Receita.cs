namespace ionit.receitas.core.Entities
{
    using System;

    /// <summary>
    /// Defines the invoice model.
    /// </summary>
    public class Receita
    {
        #region Properties

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Int32 Id { get; set; }
        public string Titulo { get; set; }
        public string Ingredientes { get; set; }
        public string ModoPreparo { get; set; }
        
        #endregion
    }
}
