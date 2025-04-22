using System;

using F10Y.T0003;
using F10Y.Z0002;


namespace F10Y.L0004.Raw
{
    [ValuesMarker]
    public partial interface IWarningSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IWarnings _Warnings => Warnings.Instance;

#pragma warning restore IDE1006 // Naming Styles

        /// <summary>
        /// <list type="bullet">
        /// <item><inheritdoc cref="IWarnings.CS1573" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IWarnings.CS1587" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IWarnings.CS1591" path="descendant::value"/></item>
        /// <item><inheritdoc cref="IWarnings.IDE0130" path="descendant::value"/></item>
        /// </list>
        /// </summary>
        public string[] N_001 =>
        [
            _Warnings.CS1573,
            _Warnings.CS1587,
            _Warnings.CS1591,
            _Warnings.IDE0130,
        ];
    }
}
