using System;
using System.Xml.Linq;

using F10Y.L0003.L001.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0004
{
    [FunctionsMarker]
    public partial interface IXContainerOperator :
        L0000.IXContainerOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IXContainerOperator _L0000 => L0000.XContainerOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        XElement Acquire_Child<TContainer>(
            TContainer parent,
            Func<TContainer, For_Has.Has<XElement>> has_Child_Operation,
            Func<XElement> child_Constructor)
            where TContainer : XContainer
        {
            var has_Child = has_Child_Operation(parent);
            if (has_Child)
            {
                return has_Child.Value;
            }
            else
            {
                var output = child_Constructor();

                this.Append_Child(
                    parent,
                    output);

                return output;
            }
        }

        XElement Acquire_Child<TContainer>(
            TContainer parent,
            Func<TContainer, For_Has.Has<XElement>> has_Child_Operation,
            string childName)
            where TContainer : XContainer
        {
            var has_Child = has_Child_Operation(parent);
            if (has_Child)
            {
                return has_Child.Value;
            }
            else
            {
                var output = Instances.XElementOperator.Create_Element(childName);

                this.Append_Child(
                    parent,
                    output);

                return output;
            }
        }

        XElement Acquire_ChildOfChild<TContainer>(
            TContainer parent,
            Func<TContainer, XElement> acquire_Child_Operation,
            Func<XElement, For_Has.Has<XElement>> has_ChildOfChild_Operation,
            Func<XElement> childOfChild_Constructor)
            where TContainer : XContainer
        {
            var child = acquire_Child_Operation(parent);

            var output = this.Acquire_Child(
                child,
                has_ChildOfChild_Operation,
                childOfChild_Constructor);

            return output;
        }

        XElement Acquire_ChildOfChild<TContainer>(
            TContainer parent,
            Func<TContainer, XElement> acquire_Child_Operation,
            Func<XElement, XElement> acquire_ChildOfChild_Operation)
            where TContainer : XContainer
        {
            var child = acquire_Child_Operation(parent);

            var output = acquire_ChildOfChild_Operation(child);
            return output;
        }

        For_Has.Has<XElement> Has_Child(
            XContainer container,
            string childName)
        {
            var exists = this.Has_Child(
                container,
                childName,
                out var child_OrDefault);

            var output = Instances.HasOperator.From(
                child_OrDefault,
                exists);

            return output;
        }

        For_Has.Has<XElement> Has_Child_First(
            XElement element,
            string childName)
        {
            var exists = Instances.XElementOperator.Has_Child_First(
                element,
                childName,
                out var child_OrDefault);

            var output = Instances.HasOperator.From(
                child_OrDefault,
                exists);

            return output;
        }

        For_Has.Has<XElement> Has_ChildOfChild_First(
            XContainer container,
            string childOfChildName)
        {
            var exists = this.Has_ChildOfChild_First(
                container,
                childOfChildName,
                out var childOfChild_OrDefault);

            var output = Instances.HasOperator.From(
                childOfChild_OrDefault,
                exists);

            return output;
        }

        For_Has.Has<TValue> Has_ChildOfChild_Value_First<TValue>(
            XContainer container,
            string childOfChildName,
            Func<XElement, TValue> valueSelector)
        {
            var has_ChildOfChild = this.Has_ChildOfChild_First(
                container,
                childOfChildName);

            var output = has_ChildOfChild.Convert(valueSelector);
            return output;
        }

        For_Has.Has<string> Has_ChildOfChild_Value_First(
            XContainer container,
            string childOfChildName)
            => this.Has_ChildOfChild_Value_First(
                container,
                childOfChildName,
                Instances.XElementOperator.Get_Value_AsString);

        For_Has.Has<XElement> Has_ChildWithAttributeValue_First(
            XContainer container,
            string childName,
            string attributeName,
            string attributeValue)
        {
            var exists = this.Has_ChildWithAttributeValue_First(
                container,
                childName,
                attributeName,
                attributeValue,
                out var child_OrDefault);

            var output = Instances.HasOperator.From(
                child_OrDefault,
                exists);

            return output;
        }

        For_Has.Has<XElement> Has_ChildWithChild_First(
            XContainer container,
            string childName,
            string childOfChildName)
        {
            var exists = this.Has_ChildWithChild_First(
                container,
                childName,
                childOfChildName,
                out var child_OrDefault);

            var output = Instances.HasOperator.From(
                child_OrDefault,
                exists);

            return output;
        }
    }
}
