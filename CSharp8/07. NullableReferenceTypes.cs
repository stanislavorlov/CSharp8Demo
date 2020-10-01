using NUnit.Framework;
using System;

namespace CSharp8
{
    internal sealed class NullableReferenceTypes
    {
        public static void Run()
        {
            string? x = null;
            string y = null;

            try
            {
                Console.WriteLine(x.Length);
                Console.WriteLine(y.Length);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null reference exception catched");
            }
        }

#nullable disable
        public class Item
        {
            public int? Id { get; set;}
            public string Title { get; set;}
            public DateTime Created { get; set; }
        }
#nullable restore

#nullable enable
        public class Data
        {
            public int Id { get; set; }
            public string? Keyword { get; set; }
            public int Modifier { get; set; }
        }
#nullable restore
    }
}
