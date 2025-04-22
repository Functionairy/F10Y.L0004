using System;


namespace F10Y.L0004
{
    public class CompanyNames : ICompanyNames
    {
        #region Infrastructure

        public static ICompanyNames Instance { get; } = new CompanyNames();


        private CompanyNames()
        {
        }

        #endregion
    }
}
