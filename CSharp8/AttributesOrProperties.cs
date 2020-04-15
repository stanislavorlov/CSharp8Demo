using System;

namespace CSharp8
{
    internal class AttributesOrProperties
    {
        class MyAttribute : Attribute { }

        public Version CSharp7
        {
            [My]
            get;
        } = new Version("8.0");
    }
}