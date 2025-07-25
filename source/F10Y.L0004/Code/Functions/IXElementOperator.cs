using System;
using System.Xml.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0004
{
    [FunctionsMarker]
    public partial interface IXElementOperator :
        IXContainerOperator,
        F10Y.L0000.IXElementOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public new IXContainerOperator _XContainerOperator => XContainerOperator.Instance;

        [Ignore]
        public new F10Y.L0000.IXElementOperator _F10Y_L0000 => F10Y.L0000.XElementOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        
    }
}
