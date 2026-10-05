using System;


namespace F10Y.L0004
{
    public class LoadOptionsSets : ILoadOptionsSets
    {
        #region Infrastructure

        public static ILoadOptionsSets Instance { get; } = new LoadOptionsSets();


        private LoadOptionsSets()
        {
        }

        #endregion
    }
}
