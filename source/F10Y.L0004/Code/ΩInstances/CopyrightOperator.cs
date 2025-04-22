using System;


namespace F10Y.L0004
{
    public class CopyrightOperator : ICopyrightOperator
    {
        #region Infrastructure

        public static ICopyrightOperator Instance { get; } = new CopyrightOperator();


        private CopyrightOperator()
        {
        }

        #endregion
    }
}
