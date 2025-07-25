using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0004
{
    /// <summary>
    /// F10Y organizational catch-all library JSON operator.
    /// </summary>
    [FunctionsMarker]
    public partial interface IJsonOperator :
        L0080.IJsonOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <inheritdoc cref="L0080.IJsonOperator"/>
        [Ignore]
        public L0080.IJsonOperator _L0080 => L0080.JsonOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
