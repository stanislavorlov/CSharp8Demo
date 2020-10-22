using System.Collections.Generic;

namespace CSharp8
{
    internal sealed class NullCoalescingAssignment
    {
        public static void Run()
        {
            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int> { };
            numbers.Add(i ?? 17);
            numbers.Add(i ?? 20);
        }
        
        public void CheckForNull()
        {
             _ = param ?? throw new ArgumentNullException(nameof(param));
        }

        public void AssignIfNull(string param)
        {
            param ??= string.Empty;

            string? defaultParam = default;
            param ??= defaultParam ??= string.Empty;
        }
    }
}
