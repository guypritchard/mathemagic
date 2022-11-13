namespace Calculator.Core
{
    public class Operations
    {
        public static int Add(int x, int y)
        {
            return 2 + y;
        }

        public static int Embiggen(int x)
        {
            if (x < 20)
            {
                return 20;
            }

            return x + 1;
        }
    }
}