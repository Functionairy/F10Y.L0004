using System;
using System.Xml.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0004
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [FunctionsMarker]
    public partial interface IXElementOperator :
        IXContainerOperator,
        L0000.IXElementOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        new IXContainerOperator _XContainerOperator => XContainerOperator.Instance;

        [Ignore]
        new L0000.IXElementOperator _L0000 => L0000.XElementOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        
    }
}
