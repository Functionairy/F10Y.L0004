using System;


namespace F10Y.L0004
{
    public class LoadOptionsSet : ILoadOptionsSet
    {
        #region Infrastructure

        public static ILoadOptionsSet Instance { get; } = new LoadOptionsSet();


        private LoadOptionsSet()
        {
        }

        #endregion
    }
}
