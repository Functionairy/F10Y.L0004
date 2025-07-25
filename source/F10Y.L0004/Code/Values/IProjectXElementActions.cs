using System;
using System.Xml.Linq;

using F10Y.T0003;


namespace F10Y.L0004
{
    [ValuesMarker]
    public partial interface IProjectXElementActions
    {
        public Action<XElement> Add_Author_DCoats => Instances.XElementOperator.Get_Add_Child(
            Instances.ProjectElementNames.Authors,
            Instances.AuthorsOperator.Join(
                Instances.AuthorSets.Default));

        public Action<XElement> Add_Company_Functionairy => Instances.XElementOperator.Get_Add_Child(
            Instances.ProjectElementNames.Company,
            Instances.CompanyNames.Functionairy);

        public Action<XElement> Add_Copyright_Functionairy => Instances.XElementOperator.Get_Add_Child(
            Instances.ProjectElementNames.Copyright,
            Instances.CopyrightOperator.Get_CopyrightText(
                Instances.CompanyNames.Functionairy));

        public Action<XElement> Add_GenerateDocumentationFile => Instances.XElementOperator.Get_Add_Child(
            Instances.ProjectElementNames.GenerateDocumentationFile,
            Instances.BooleanOperator.To_String_ForProjectXml(true));

        public Action<XElement> Add_OutputType_Exe => Instances.XElementOperator.Get_Add_Child(
            Instances.ProjectElementNames.OutputType,
            Instances.OutputTypes.Exe);

        public Action<XElement> Add_RepositoryUrl_F10Y_Z0010 => Instances.XElementOperator.Get_Add_Child(
            Instances.ProjectElementNames.RepositoryUrl,
            Instances.RepositoryUrls.F10Y_Z0010);

        public Action<XElement> Add_PackageLicenseExpression_MIT => Instances.XElementOperator.Get_Add_Child(
            Instances.ProjectElementNames.PackageLicenseExpression,
            Instances.PackageLicenseExpressions.MIT);

        public Action<XElement> Add_PackageRequireLicenseAcceptance => Instances.XElementOperator.Get_Add_Child(
            Instances.ProjectElementNames.PackageRequireLicenseAcceptance,
            Instances.BooleanOperator.To_String_ForProjectXml(true));

        public Action<XElement> Add_TargetFramework_net8_0 => Instances.XElementOperator.Get_Add_Child(
            Instances.ProjectElementNames.TargetFramework,
            Instances.TargetFrameworkMonikers.net8_0);

        public Action<XElement> Add_Version_Initial => Instances.XElementOperator.Get_Add_Child(
            Instances.ProjectElementNames.Version,
            Instances.VersionOperator.To_String_ForProjectXml(
                Instances.Versions.Initial_Default)
            );

        public Action<XElement> Add_Warnings_Default => Instances.XElementOperator.Get_Add_Child(
            Instances.ProjectElementNames.NoWarn,
            Instances.WarningsOperator.Join(
                Instances.WarningSets.Default)
            );

        public Action<XElement> Set_Label_Main => Instances.XElementOperator.Get_Set_Attribute_Value(
            Instances.ProjectAttributeNames.Label,
            Instances.ProjectGroupElementLabels.Main);

        public Action<XElement> Set_Label_Package => Instances.XElementOperator.Get_Set_Attribute_Value(
            Instances.ProjectAttributeNames.Label,
            Instances.ProjectGroupElementLabels.Package);

        public Action<XElement> Set_Label_ProjectReferences => Instances.XElementOperator.Get_Set_Attribute_Value(
            Instances.ProjectAttributeNames.Label,
            Instances.ProjectGroupElementLabels.ProjectReferences);

        public Action<XElement> Set_Microsoft_NET_Sdk => Instances.XElementOperator.Get_Set_Attribute_Value(
            Instances.ProjectAttributeNames.Sdk,
            Instances.SdkNames.Microsoft_NET_Sdk);
    }
}
