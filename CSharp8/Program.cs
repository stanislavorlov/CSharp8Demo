using System;
using System.Reflection;
using CSharp8;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            AttributesOrProperties myClass = new AttributesOrProperties();
            Console.WriteLine(myClass);

            Type myType = typeof(AttributesOrProperties);
            PropertyInfo property = myType.GetProperty("CSharp7");
        }
    }
}
