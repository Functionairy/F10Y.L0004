using System;
using System.Xml.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0004
{
    [FunctionsMarker]
    public partial interface IProjectXElementOperator :
        L0006.IProjectXElementOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0006.IProjectXElementOperator _L0006 => L0006.ProjectXElementOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public Action<XElement> Get_Add_Description(string description)
            => parent => Instances.XElementOperator.Add_Child(
                parent,
                Instances.ProjectElementNames.Description,
                description);
    }
}
