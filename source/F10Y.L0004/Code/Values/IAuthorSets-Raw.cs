using System;

using F10Y.T0003;


namespace F10Y.L0004.Raw
{
    [ValuesMarker]
    public partial interface IAuthorSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IAuthors _Authors => Authors.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <list type="bullet">
        /// <item><inheritdoc cref="IAuthors.DCoats" path="descendant::value"/></item>
        /// </list>
        /// </summary>
        public string[] N_001 =>
        [
            _Authors.DCoats
        ];
    }
}
