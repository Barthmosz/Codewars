namespace Codewars._8_kyu
{
    public static class Summation
    {
        public static int Handle(int num)
        {
            int result = 0;

            for (int i = 1; i <= num; i++)
            {
                result += i;
            }

            return result;
        }
    }
}
