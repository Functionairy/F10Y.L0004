using System;


namespace F10Y.L0004
{
    public class ProjectXElementActions : IProjectXElementActions
    {
        #region Infrastructure

        public static IProjectXElementActions Instance { get; } = new ProjectXElementActions();


        private ProjectXElementActions()
        {
        }

        #endregion
    }
}
