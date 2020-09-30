using System;
using System.Reflection;

namespace CSharp8
{
    internal sealed class AttributesOnProperties
    {
        class MyAttribute : Attribute { }

        public Version CSharp7
        {
            [My]
            get;
        } = new Version("8.0");

        public static void Run()
        {
            Type myType = typeof(AttributesOnProperties);
            PropertyInfo property = myType.GetProperty("CSharp7");
            var customAttrs = property.GetMethod.CustomAttributes;

            foreach (var customAttr in customAttrs)
            {
                Console.WriteLine(customAttr.AttributeType.FullName);
            }
        }
    }
}