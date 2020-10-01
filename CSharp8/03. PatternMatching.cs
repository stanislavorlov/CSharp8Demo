using System;

namespace CSharp8
{
    internal sealed class PatternMatching
    {
        public static void Run()
        {
            PropertyPatterns();
            PositionalPatterns();
            TuplePatterns(State.Opened, Transition.Close, true);
        }

        public static void PropertyPatterns()
        {
            var point = new Point(0, 1);
            _ = point switch
            {
                Point { X: 0, Y: 0 } p  => $"({p.X};{p.Y})",
                Point p when p.X == 0   => $"({p.X};{p.Y})",
                { X: var x, Y: 1 } p    => $"({x};{p.Y})",
                { } p                   => p.ToString(),
                _                       => "Unknown"
                //null => "null",
            };
        }

        public static void PositionalPatterns()
        {
            var point = GetPoint();

            _ = point switch
            {
                Point(0, 0)             => "origin",
                Point(var x, var y)     => $"({x}, {y})",
                _                       => "unknown"
            };

            static Point GetPoint()
            {
                return new Point(1, 1);
            }
        }

        public static State TuplePatterns(State current, Transition transition, bool hasKey) =>
            (current, transition, hasKey) switch
            {
                (State.Opened, Transition.Close, _) => State.Closed,
                (State.Closed, Transition.Open, _) => State.Opened,
                (State.Closed, Transition.Lock, true) => State.Locked,
                (State.Locked, Transition.Unlock, true) => State.Closed,
                (_,_,_) => throw new InvalidOperationException($"Invalid transition")
            };

        public static int Fib(int n)
        {
            var result = n switch
            {
                _ when n < 0 => throw new ArgumentOutOfRangeException(),
                0 => 0,
                1 => 1,
                _ => Fib(n - 1) + Fib(n - 2)
            };
            return result;
        }

        public static string PatternMatchingWithCustomExtensions(DateTime date) => date switch
        {
            (_, _, 1) => $"{date:d} is the first of the month",
            (int year, 2, 29) => $"{year} is a leap year",
            _ => $"{date:d} is a boring date"
        };

        internal class Point
        {
            public int X { get; private set; }
            public int Y { get; private set; }

            public Point(int x, int y) => (X, Y) = (x, y);

            internal void Deconstruct(out int x, out int y)
            {
                x = X;
                y = Y;
            }
        }

        internal enum State
        {
            Opened,
            Closed,
            Locked
        }

        internal enum Transition
        {
            Close,
            Open,
            Lock,
            Unlock
        }
    }

    static class DateTimeExtensions
    {
        public static void Deconstruct(this DateTime date, out int year, out int month, out int day) =>
            (year, month, day) = (date.Year, date.Month, date.Day);
    }
}