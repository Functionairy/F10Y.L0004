using System;

using F10Y.T0002;


namespace F10Y.L0004
{
    [FunctionsMarker]
    public partial interface IDateOnlyOperator
    {
        public int Get_Year(DateOnly date)
            => date.Year;
    }
}
