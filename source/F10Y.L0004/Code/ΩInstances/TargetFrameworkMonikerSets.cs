using System;


namespace F10Y.L0004
{
    public class TargetFrameworkMonikerSets : ITargetFrameworkMonikerSets
    {
        #region Infrastructure

        public static ITargetFrameworkMonikerSets Instance { get; } = new TargetFrameworkMonikerSets();


        private TargetFrameworkMonikerSets()
        {
        }

        #endregion
    }
}


namespace F10Y.L0004.Raw
{
    public class TargetFrameworkMonikerSets : ITargetFrameworkMonikerSets
    {
        #region Infrastructure

        public static ITargetFrameworkMonikerSets Instance { get; } = new TargetFrameworkMonikerSets();


        private TargetFrameworkMonikerSets()
        {
        }

        #endregion
    }
}