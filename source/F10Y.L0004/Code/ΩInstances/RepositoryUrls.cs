using System;


namespace F10Y.L0004
{
    public class RepositoryUrls : IRepositoryUrls
    {
        #region Infrastructure

        public static IRepositoryUrls Instance { get; } = new RepositoryUrls();


        private RepositoryUrls()
        {
        }

        #endregion
    }
}
