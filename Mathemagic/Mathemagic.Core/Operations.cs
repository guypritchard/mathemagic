namespace Mathemagic.Core
{
    public class Operations
    {
        public static int Add(int x, int y)
        {
            if (x < 0 || y < 0)
                throw new ArgumentOutOfRangeException("inputs");

            var result = 2 + y;
            return result;
        }

        public static int Embiggen(int x)
        {
            if (x < 0)
                throw new ArgumentOutOfRangeException("x");

            if (x < 20)
            {
                return 20;
            }

            return x + 1;
        }
    }
}