using System;


namespace F10Y.L0004
{
    public class WarningSets : IWarningSets
    {
        #region Infrastructure

        public static IWarningSets Instance { get; } = new WarningSets();


        private WarningSets()
        {
        }

        #endregion
    }
}


namespace F10Y.L0004.Raw
{
    public class WarningSets : IWarningSets
    {
        #region Infrastructure

        public static IWarningSets Instance { get; } = new WarningSets();


        private WarningSets()
        {
        }

        #endregion
    }
}
