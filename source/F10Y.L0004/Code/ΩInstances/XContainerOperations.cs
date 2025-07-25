using System;


namespace F10Y.L0004
{
    public class XContainerOperations : IXContainerOperations
    {
        #region Infrastructure

        public static IXContainerOperations Instance { get; } = new XContainerOperations();


        private XContainerOperations()
        {
        }

        #endregion
    }
}
