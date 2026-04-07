using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0004
{
    [ValuesMarker]
    public partial interface IAuthorSets
    {

#pragma warning disable IDE1006 // Naming Styles

        private static IAuthors _Authors => Instances.Authors;


        [Ignore]
        Raw.IAuthorSets _Raw => Raw.AuthorSets.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IAuthorSets.N_001"/>
        string[] Default => _Raw.N_001;

        string[] All =>
        [
            _Authors._1NFNTE_R0CK,
            _Authors.DCoats,
        ];
    }
}
