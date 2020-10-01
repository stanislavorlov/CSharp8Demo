using System;

namespace CSharp8
{
    internal sealed class IndecesAndRanges
    {
        /*
         * Index represents an index into a sequence
         * Range represents a sub range of a sequence
         */
        public static void Run()
        {
            Indices();

            Ranges();
        }

        private static void Indices()
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };
            Index idx1 = 2;
            Index idx2 = new Index(1, true);    //First from the End
            Index idx3 = ^1;

            Console.WriteLine(arr[idx1]);       //3
            Console.WriteLine(arr[idx2]);       //5
            Console.WriteLine(arr[idx3]);       //5

            arr[^1] *= -1;                      //-5
        }

        private static void Ranges()
        {
            var words = new string[]
            {
                "The", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog"    
            };

            var quickBrownFox = words[1..4];        //"quick", "brown", "fox"
            var lazyDog = words[^2..^0];            //"lazy", "dog" 
            var allWords = words[..];               // contains "The" through "dog".
            var firstPhrase = words[..4];           // contains "The" through "fox"
            var lastPhrase = words[6..];            // contains "the", "lazy" and "dog"

            Range phrase = 1..4;
            var text = words[phrase];               //"quick", "brown", "fox"

            try
            {
                var i1 = ^2;
                var inverse = words[i1..0];
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Catched out of range exception");
            }
        }
    }
}
