using System;

namespace CSharp8
{
    internal sealed class ReadonlyMembers
    {
        public struct MyVector
        {
            public double X1 { get; set; }
            public double Y1 { get; set; }
            public double X2 { get; set; }
            public double Y2 { get; set; }

            /*
             * Readonly modifier is a kind of indicator for compiler that allows better optimization 
             */
            public readonly double Distance => Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

            public double Distance2 => Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

            /*
             * Translate method won't compile unless readonly modifier is removed
             * 
            public readonly void Translate(int xOffset, int yOffset)
            {
                X1 += xOffset;
                Y1 += yOffset;
            }
            */
        }

        public static void Run()
        {
            MyVector myVector = new MyVector
            { 
                X1 = 5,
                Y1 = 10
            };

            /*
             * The following code won't compile
             * 
            myVector.Distance = 5;
            myVector.Distance2 = 10;
            */
        }
    }
}
