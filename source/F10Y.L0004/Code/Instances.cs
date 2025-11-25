using System;


namespace F10Y.L0004
{
    public static class Instances
    {
        public static IAuthors Authors => L0004.Authors.Instance;
        public static IAuthorSets AuthorSets => L0004.AuthorSets.Instance;
        public static L0006.IAuthorsOperator AuthorsOperator => L0006.AuthorsOperator.Instance;
        public static L0006.IBooleanOperator BooleanOperator => L0006.BooleanOperator.Instance;
        public static ICompanyNames CompanyNames => L0004.CompanyNames.Instance;
        public static ICopyrightOperator CopyrightOperator => L0004.CopyrightOperator.Instance;
        public static IDateOnlyOperator DateOnlyOperator => L0004.DateOnlyOperator.Instance;
        public static L0000.IDateTimeOperator DateTimeOperator => L0000.DateTimeOperator.Instance;
        public static L0003.L001.IHasOperator HasOperator => L0003.L001.HasOperator.Instance;
        public static L0000.INewLines NewLines => L0000.NewLines.Instance;
        public static L0000.INowOperator NowOperator => L0000.NowOperator.Instance;
        public static Z0002.IOutputTypes OutputTypes => Z0002.OutputTypes.Instance;
        public static Z0002.IPackageLicenseExpressions PackageLicenseExpressions => Z0002.PackageLicenseExpressions.Instance;
        public static L0006.Z000.IProjectAttributeNames ProjectAttributeNames => L0006.Z000.ProjectAttributeNames.Instance;
        public static L0006.Z000.IProjectElementNames ProjectElementNames => L0006.Z000.ProjectElementNames.Instance;
        public static IProjectGroupElementLabels ProjectGroupElementLabels => L0004.ProjectGroupElementLabels.Instance;
        public static IRepositoryUrls RepositoryUrls => L0004.RepositoryUrls.Instance;
        public static Z0002.ISdkNames SdkNames => Z0002.SdkNames.Instance;
        public static L0000.IStrings Strings => L0000.Strings.Instance;
        public static Z0002.ITargetFrameworkMonikers TargetFrameworkMonikers => Z0002.TargetFrameworkMonikers.Instance;
        public static L0006.IVersionOperator VersionOperator => L0006.VersionOperator.Instance;
        public static L0000.IVersions Versions => L0000.Versions.Instance;
        public static L0006.IWarningsOperator WarningsOperator => L0006.WarningsOperator.Instance;
        public static IWarningSets WarningSets => L0004.WarningSets.Instance;
        public static IXContainerOperations XContainerOperations => L0004.XContainerOperations.Instance;
        public static IXContainerOperator XContainerOperator => L0004.XContainerOperator.Instance;
        public static IXElementOperator XElementOperator => L0004.XElementOperator.Instance;
        public static L0000.IXTextOperator XTextOperator => L0000.XTextOperator.Instance;
        public static L0000.IXTexts XTexts => L0000.XTexts.Instance;
    }
}