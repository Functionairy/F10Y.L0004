using System;
using System.Xml.Linq;

using F10Y.T0002;


namespace F10Y.L0004
{
    [FunctionsMarker]
    public partial interface IXContainerOperations
    {
        public Func<XContainer, For_Has.Has<XElement>> Has_Child(string childName)
            => container => Instances.XContainerOperator.Has_Child(
                container,
                childName);
    }
}
