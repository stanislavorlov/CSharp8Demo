namespace CSharp8
{
    internal sealed class StaticLocalFunctions
    {
        private int x, y;

        public StaticLocalFunctions(int x, int y) => (this.x, this.y) = (x, y);

        public int LocalFunctionTest()
        {
            int z;
            LocalFunction();
            return x + y + z;

            void LocalFunction() => z = x + 5;
        }

        public int StaticLocalFunctionTest()
        {
            return Add(x, y);

            static int Add(int left, int right) => left + right;
        }

        public static void Run()
        {
            var instance = new StaticLocalFunctions(4, 5);
            var result = instance.LocalFunctionTest();
            var result2 = instance.StaticLocalFunctionTest();
        }
    }
}
