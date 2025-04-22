using System;


namespace F10Y.L0004
{
    public class ProjectGroupElementLabels : IProjectGroupElementLabels
    {
        #region Infrastructure

        public static IProjectGroupElementLabels Instance { get; } = new ProjectGroupElementLabels();


        private ProjectGroupElementLabels()
        {
        }

        #endregion
    }
}
