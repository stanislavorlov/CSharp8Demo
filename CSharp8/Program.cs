using System;
using System.Reflection;
using CSharp8;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //0. Attributes on Properties
            AttributesOnProperties.Run();

            //1. Readonly members
            ReadonlyMembers.Run();

            //2. Default interface methods
            DefaultInterfaceMethods.Run();
        }
    }
}
