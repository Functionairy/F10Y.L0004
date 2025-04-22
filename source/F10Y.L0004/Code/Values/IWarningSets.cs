using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0004
{
    [ValuesMarker]
    public partial interface IWarningSets
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IWarningSets _Raw => Raw.WarningSets.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IWarningSets.N_001"/>
        public string[] Default => _Raw.N_001;
    }
}
