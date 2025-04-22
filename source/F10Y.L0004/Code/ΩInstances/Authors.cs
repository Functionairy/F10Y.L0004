using System;


namespace F10Y.L0004
{
    public class Authors : IAuthors
    {
        #region Infrastructure

        public static IAuthors Instance { get; } = new Authors();


        private Authors()
        {
        }

        #endregion
    }
}
