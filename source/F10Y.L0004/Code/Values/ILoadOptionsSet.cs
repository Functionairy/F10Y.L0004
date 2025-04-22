using System;
using System.Xml.Linq;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0004
{
    [ValuesMarker]
    public partial interface ILoadOptionsSet
        : L0000.ILoadOptionsSet
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.ILoadOptionsSet _L0000 => L0000.LoadOptionsSet.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><inheritdoc cref="L0000.ILoadOptionsSet.PreserveWhitespace_Constant" path="descendant::value"/></para>
        /// The standard load options preserves whitespace.
        /// </summary>
        /// <remarks>
        /// Note: As opposed to a "default" value (which is just what the value defaults to), you could have a "standard" value in an personally- or organizationally-opinionated library.
        /// </remarks>
        public const LoadOptions Standard_Constant = ILoadOptionsSet.PreserveWhitespace_Constant;

        /// <inheritdoc cref="Standard_Constant"/>
        public LoadOptions Standard => ILoadOptionsSet.Standard_Constant;
    }
}
