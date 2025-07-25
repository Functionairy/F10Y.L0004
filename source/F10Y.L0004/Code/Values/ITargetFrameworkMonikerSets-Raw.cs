using System;

using F10Y.T0003;


namespace F10Y.L0004.Raw
{
    [ValuesMarker]
    public partial interface ITargetFrameworkMonikerSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static Z0002.ITargetFrameworkMonikers _TargetFrameworkMonikers => Z0002.TargetFrameworkMonikers.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// Target framework monikers that have been encountered (instead of mythologically existing).
        /// </summary>
        public string[] N_0000 =>
        [
            _TargetFrameworkMonikers.netcoreapp2_1,
            _TargetFrameworkMonikers.netcoreapp2_2,
            _TargetFrameworkMonikers.netstandard2_0,
            _TargetFrameworkMonikers.netstandard2_1,
            _TargetFrameworkMonikers.net5_0,
            _TargetFrameworkMonikers.net6_0,
            _TargetFrameworkMonikers.net7_0,
            _TargetFrameworkMonikers.net8_0,
            _TargetFrameworkMonikers.net8_0_windows,
        ];
    }
}
