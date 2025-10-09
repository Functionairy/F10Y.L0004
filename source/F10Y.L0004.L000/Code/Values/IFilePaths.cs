using System;

using F10Y.T0003;


namespace F10Y.L0004.L000
{
    [ValuesMarker]
    public partial interface IFilePaths
    {
        /// <summary>
        /// <para><value>C:\Temp\Output.csproj</value></para>
        /// </summary>
        string Output_ProjectFilePath => @"C:\Temp\Output.csproj";

        /// <summary>
        /// <para><value>C:\Temp\Output.json</value></para>
        /// </summary>
        string Output_JsonFilePath => @"C:\Temp\Output.json";

        /// <summary>
        /// <para><value>C:\Temp\Output.txt</value></para>
        /// </summary>
        string Output_TextFilePath => @"C:\Temp\Output.txt";

        /// <summary>
        /// <para><value>C:\Temp\Output.xml</value></para>
        /// </summary>
        string Output_XmlFilePath => @"C:\Temp\Output.xml";
    }
}
