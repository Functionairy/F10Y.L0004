using System;
using System.Xml.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0004
{
    /// <summary>
    /// Functionairy organizational catch-all library.
    /// </summary>
    [FunctionsMarker]
    public partial interface IProjectXElementOperator :
        L0006.IProjectXElementOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0006.IProjectXElementOperator _L0006 => L0006.ProjectXElementOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        #region Description

        public Action<XElement> Get_Add_Description(string description)
            => parent => Instances.XElementOperator.Add_Child(
                parent,
                Instances.ProjectElementNames.Description,
                description);

        #endregion

        #region Generate Documentation File

        public new XElement Acquire_GenerateDocumentationFile(XElement projectElement)
            => this.Acquire_GenerateDocumentationFile(
                projectElement,
                this.Acquire_PropertyGroup_Main);

        public For_Has.Has<string> Has_GenerateDocumentationFile(XElement projectElement)
            => Instances.XElementOperator.Has_ChildOfChild_Value_First(
                projectElement,
                Instances.ProjectElementNames.GenerateDocumentationFile);

        public new XElement Set_GenerateDocumentationFile(
            XElement projectElement,
            bool generateDocumentationFile)
            => this.Set_GenerateDocumentationFile(
                projectElement,
                generateDocumentationFile,
                this.Acquire_GenerateDocumentationFile);

        #endregion

        #region Output Type

        public new XElement Acquire_OutputType(XElement projectElement)
            => this.Acquire_OutputType(
                projectElement,
                this.Acquire_PropertyGroup_Main);

        public For_Has.Has<string> Has_OutputType(XElement projectElement)
            => Instances.XElementOperator.Has_ChildOfChild_Value_First(
                projectElement,
                Instances.ProjectElementNames.OutputType);

        public new XElement Set_OutputType(
            XElement projectElement,
            string outputType)
            => this.Set_OutputType(
                projectElement,
                outputType,
                this.Acquire_OutputType);

        #endregion

        #region Property Group - Main

        public new XElement Acquire_PropertyGroup_Main(XElement projectElement)
            => Instances.XElementOperator.Acquire_Child(
                projectElement,
                this.Has_PropertyGroup_Main,
                this.Create_PropertyGroup_Main);

        public XElement Create_PropertyGroup_Main()
        {
            var output = Instances.XElementOperator.Create_Element(Instances.ProjectElementNames.PropertyGroup);

            Instances.XElementOperator.Add_Attribute(
                output,
                Instances.ProjectAttributeNames.Label,
                Instances.ProjectGroupElementLabels.Main);

            return output;
        }

        public new For_Has.Has<XElement> Has_PropertyGroup_Main(XElement projectElement)
        {
            // => This is a Functionairy convention.
            // Is there a property group with the main label?
            var has_PropertyGroup_WithMainLabel = Instances.XElementOperator.Has_ChildWithAttributeValue_First(
                projectElement,
                Instances.ProjectElementNames.PropertyGroup,
                Instances.ProjectAttributeNames.Label,
                Instances.ProjectGroupElementLabels.Main);

            if (has_PropertyGroup_WithMainLabel)
            {
                return has_PropertyGroup_WithMainLabel;
            }

            // Is there a default convention main property group?
            var has_PropertyGroup_Main = this.Has_PropertyGroup_Main(
                projectElement,
                out var propertyGroup_Main_OrDefault);

            var output = Instances.HasOperator.From(
                propertyGroup_Main_OrDefault,
                has_PropertyGroup_Main);

            return output;
        }

        public XElement Get_PropertyGroup_Main(XElement projectElement)
        {
            var has_PropertyGroup_Main = this.Has_PropertyGroup_Main(projectElement);

            if (!has_PropertyGroup_Main)
            {
                throw new Exception("No main property group found.");
            }

            return has_PropertyGroup_Main;
        }

        #endregion

        #region Project References



        #endregion

        #region Target Framework

        public new XElement Acquire_TargetFramework(XElement projectElement)
            => this.Acquire_TargetFramework(
                projectElement,
                this.Acquire_PropertyGroup_Main);

        public new XElement Set_TargetFramework(
            XElement projectElement,
            string targetFramework)
            => this.Set_TargetFramework(
                projectElement,
                targetFramework,
                this.Acquire_TargetFramework);

        #endregion
    }
}
