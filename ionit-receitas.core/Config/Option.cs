namespace ionit.receitas.core.Config
{
    using System.Collections.Generic;

    /// <summary>
    /// Multi App tenant configuration options
    /// </summary>
    public class Option
    {
        #region Properties

        /// <summary>
        /// Gets or sets the tenants.
        /// </summary>
        public IEnumerable<AppOption> Options { get; set; }

        #endregion
    }
}
