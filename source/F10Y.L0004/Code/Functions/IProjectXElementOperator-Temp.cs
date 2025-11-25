using System;
using System.Xml.Linq;


namespace F10Y.L0004
{
    public partial interface IProjectXElementOperator
    {
        #region Item Group - Project References

        XElement Acquire_ItemGroup(XElement projectElement)
        => Instances.XElementOperator.Acquire_Child(
            projectElement,
            this.Has_ItemGroup,
            this.Create_ItemGroup);

        new XElement Acquire_ItemGroup_ForProjectReferences(XElement projectElement)
            => Instances.XElementOperator.Acquire_Child(
                projectElement,
                this.Has_ItemGroup_ForProjectReferences,
                this.Create_ItemGroup_ForProjectReferences);

        XElement Create_ItemGroup_ForProjectReferences()
        {
            var output = Instances.XElementOperator.Create_Element(Instances.ProjectElementNames.ItemGroup);

            Instances.XElementOperator.Add_Attribute(
                output,
                Instances.ProjectAttributeNames.Label,
                Instances.ProjectGroupElementLabels.ProjectReferences);

            return output;
        }

        For_Has.Has<XElement> Has_ItemGroup(XElement projectElement)
            => Instances.XElementOperator.Has_Child(
                projectElement,
                Instances.ProjectElementNames.ItemGroup);

        new For_Has.Has<XElement> Has_ItemGroup_ForProjectReferences(XElement projectElement)
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

        XElement Get_ItemGroup_ForProjectReferences(XElement projectElement)
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
