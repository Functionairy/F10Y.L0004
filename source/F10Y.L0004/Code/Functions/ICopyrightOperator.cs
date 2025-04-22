using System;

using F10Y.T0002;


namespace F10Y.L0004
{
    [FunctionsMarker]
    public partial interface ICopyrightOperator
    {
        public string Get_CopyrightText(
            string copyrightHolder,
            int copyrightYear)
        {
            var output = $"Copyright {Instances.Strings.Copyright} {copyrightHolder} {copyrightYear}";
            return output;
        }

        public string Get_CopyrightText(
            string copyrightHolder,
            DateTime copyrightDate)
        {
            var copyrightYear = Instances.DateTimeOperator.Get_Year(copyrightDate);

            var output = this.Get_CopyrightText(
                copyrightHolder,
                copyrightYear);

            return output;
        }

        public string Get_CopyrightText(string copyrightHolder)
        {
            var copyrightYear = Instances.NowOperator.Get_CurrentYear();

            var output = this.Get_CopyrightText(
                copyrightHolder,
                copyrightYear);

            return output;
        }
    }
}
