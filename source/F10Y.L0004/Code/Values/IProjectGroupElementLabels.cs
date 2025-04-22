using System;

using F10Y.T0003;


namespace F10Y.L0004
{
    /// <summary>
    /// Label values for .NET project file group (PropertyGroup and ItemGroup) XML elements.
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectGroupElementLabels
    {
        /// <summary>
        /// <para><value>Main</value></para>
        /// </summary>
        public string Main => "Main";

        /// <summary>
        /// <para><value>Package</value></para>
        /// </summary>
        public string Package => "Package";

        /// <summary>
        /// <para><value>Package References</value></para>
        /// </summary>
        public string PackageReferences => "Package References";

        /// <summary>
        /// <para><value>"Project References"</value></para>
        /// </summary>
        public string ProjectReferences => "Project References";
    }
}
