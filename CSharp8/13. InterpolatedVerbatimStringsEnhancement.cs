namespace CSharp8
{
    internal sealed class InterpolatedVerbatimStringsEnhancement
    {
        public static void Run()
        {
            const string order = "Order";
            var str1 = $@"{order} doesn't matter";
            var str2 = @$"{order} doesn't matter";
        }
    }
}