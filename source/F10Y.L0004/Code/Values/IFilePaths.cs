using System;

using F10Y.T0003;


namespace F10Y.L0004
{
    [ValuesMarker]
    public partial interface IFilePaths
    {
        /// <summary>
        /// <para><value>C:\Temp\Output.csproj</value></para>
        /// </summary>
        public string Output_ProjectFilePath => @"C:\Temp\Output.csproj";

        /// <summary>
        /// <para><value>C:\Temp\Output.txt</value></para>
        /// </summary>
        public string Output_TextFilePath => @"C:\Temp\Output.txt";

        /// <summary>
        /// <para><value>C:\Temp\Output.xml</value></para>
        /// </summary>
        public string Output_XmlFilePath => @"C:\Temp\Output.xml";
    }
}
