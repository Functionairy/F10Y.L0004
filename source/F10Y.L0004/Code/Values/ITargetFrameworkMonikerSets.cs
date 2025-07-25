using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0004
{
    [ValuesMarker]
    public partial interface ITargetFrameworkMonikerSets :
        Z0002.ITargetFrameworkMonikerSets
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z0002.ITargetFrameworkMonikerSets _Z0002 => Z0002.TargetFrameworkMonikerSets.Instance;

        [Ignore]
        public new Raw.ITargetFrameworkMonikerSets _Raw => Raw.TargetFrameworkMonikerSets.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.ITargetFrameworkMonikerSets.N_0000"/>
        public string[] Encountered => _Raw.N_0000;
    }
}
