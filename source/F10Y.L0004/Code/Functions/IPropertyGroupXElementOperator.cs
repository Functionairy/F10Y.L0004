using System;
using System.Xml.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0004
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [FunctionsMarker]
    public partial interface IPropertyGroupXElementOperator :
        L0006.IPropertyGroupXElementOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0006.IPropertyGroupXElementOperator _L0006 => L0006.PropertyGroupXElementOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        For_Has.Has<string> Has_RepositoryUrl(XElement propertyGroupElement)
        {
            var exists = this.Has_RepositoryUrl(
                propertyGroupElement,
                out var repositoryUrl_OrDefault);

            var output = Instances.HasOperator.From(
                repositoryUrl_OrDefault,
                exists);

            return output;
        }

        /// <summary>
        /// Given a property group element, wrap it with padding.
        /// </summary>
        void Wrap_WithPadding(
            XElement propertyGroupElement,
            string text)
        {
            var xText = Instances.XTextOperator.From(text);

            propertyGroupElement.AddBeforeSelf(xText);
            propertyGroupElement.AddAfterSelf(xText);
        }

        /// <summary>
        /// Given a property group element, wrap it with padding.
        /// </summary>
        void Wrap_WithPadding(XElement propertyGroupElement)
        {
            var text = $"{Instances.NewLines.Environment}{Instances.Strings.Tab}";

            this.Wrap_WithPadding(
                propertyGroupElement,
                text);
        }
    }
}
