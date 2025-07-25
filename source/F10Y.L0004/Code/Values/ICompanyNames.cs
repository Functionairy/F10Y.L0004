using System;

using F10Y.T0003;


namespace F10Y.L0004
{
    [ValuesMarker]
    public partial interface ICompanyNames
    {
        /// <summary>
        /// <para><value>Acme</value></para>
        /// </summary>
        public string Acme => "Acme";

        /// <summary>
        /// <para><value>Functionairy</value></para>
        /// </summary>
        public string Functionairy => "Functionairy";
    }
}
