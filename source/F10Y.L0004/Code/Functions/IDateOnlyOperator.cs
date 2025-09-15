using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0004
{
    /// <summary>
    /// Functions for the <see cref="DateOnly"/> type.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [FunctionsMarker]
    public partial interface IDateOnlyOperator :
        L0060.IDateOnlyOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0060.IDateOnlyOperator _L0060 => L0060.DateOnlyOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
