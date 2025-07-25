using System;
using System.Xml.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0004
{
    [FunctionsMarker]
    public partial interface IPropertyGroupXElementOperator :
        L0006.IPropertyGroupXElementOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0006.IPropertyGroupXElementOperator _L0006 => L0006.PropertyGroupXElementOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public For_Has.Has<string> Has_RepositoryUrl(XElement propertyGroupElement)
        {
            var exists = this.Has_RepositoryUrl(
                propertyGroupElement,
                out var repositoryUrl_OrDefault);

            var output = Instances.HasOperator.From(
                repositoryUrl_OrDefault,
                exists);

            return output;
        }
    }
}
