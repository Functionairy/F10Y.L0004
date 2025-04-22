using System;


namespace F10Y.L0004
{
    public class ProjectXElementOperator : IProjectXElementOperator
    {
        #region Infrastructure

        public static IProjectXElementOperator Instance { get; } = new ProjectXElementOperator();


        private ProjectXElementOperator()
        {
        }

        #endregion
    }
}
