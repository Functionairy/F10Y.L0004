using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0004
{
    [ValuesMarker]
    public partial interface IFilePaths :
        L000.IFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L000.IFilePaths _L000 => L000.FilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
