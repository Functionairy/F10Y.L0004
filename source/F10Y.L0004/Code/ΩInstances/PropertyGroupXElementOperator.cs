using System;


namespace F10Y.L0004
{
    public class PropertyGroupXElementOperator : IPropertyGroupXElementOperator
    {
        #region Infrastructure

        public static IPropertyGroupXElementOperator Instance { get; } = new PropertyGroupXElementOperator();


        private PropertyGroupXElementOperator()
        {
        }

        #endregion
    }
}
