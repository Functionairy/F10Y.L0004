using System;
using System.Xml.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0004
{
    public partial interface IProjectXElementOperator
    {
        #region Item Group - Project References

        public new XElement Acquire_ItemGroup_ForProjectReferences(XElement projectElement)
            => Instances.XElementOperator.Acquire_Child(
                projectElement,
                this.Has_ItemGroup_ForProjectReferences,
                this.Create_ItemGroup_ForProjectReferences);

        public XElement Create_ItemGroup_ForProjectReferences()
        {
            var output = Instances.XElementOperator.Create_Element(Instances.ProjectElementNames.PropertyGroup);

            Instances.XElementOperator.Add_Attribute(
                output,
                Instances.ProjectAttributeNames.Label,
                Instances.ProjectGroupElementLabels.ProjectReferences);

            return output;
        }

        public new For_Has.Has<XElement> Has_ItemGroup_ForProjectReferences(XElement projectElement)
        {
            // => This is a Functionairy convention.
            // Is there an group with the project references label?
            var has_ItemGroup_WithProjectReferencesLabel = Instances.XElementOperator.Has_ChildWithAttributeValue_First(
                projectElement,
                Instances.ProjectElementNames.ItemGroup,
                Instances.ProjectAttributeNames.Label,
                Instances.ProjectGroupElementLabels.ProjectReferences);

            if (has_ItemGroup_WithProjectReferencesLabel)
            {
                return has_ItemGroup_WithProjectReferencesLabel;
            }

            // Is there a default convention main property group?
            var has_ItemGroup_ForProjectReferences = this.Has_ItemGroup_ForProjectReferences(
                projectElement,
                out var itemGroup_ForProjectReferences_OrDefault);

            var output = Instances.HasOperator.From(
                itemGroup_ForProjectReferences_OrDefault,
                has_ItemGroup_ForProjectReferences);

            return output;
        }

        public XElement Get_ItemGroup_ForProjectReferences(XElement projectElement)
        {
            var has_PropertyGroup_Main = this.Has_ItemGroup_ForProjectReferences(projectElement);

            if (!has_PropertyGroup_Main)
            {
                throw new Exception("No project references item group found.");
            }

            return has_PropertyGroup_Main;
        }

        #endregion
    }
}
