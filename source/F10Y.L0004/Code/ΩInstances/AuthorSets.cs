using System;


namespace F10Y.L0004
{
    public class AuthorSets : IAuthorSets
    {
        #region Infrastructure

        public static IAuthorSets Instance { get; } = new AuthorSets();


        private AuthorSets()
        {
        }

        #endregion
    }
}


namespace F10Y.L0004.Raw
{
    public class AuthorSets : IAuthorSets
    {
        #region Infrastructure

        public static IAuthorSets Instance { get; } = new AuthorSets();


        private AuthorSets()
        {
        }

        #endregion
    }
}
