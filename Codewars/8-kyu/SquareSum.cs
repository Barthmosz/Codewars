namespace Codewars._8_kyu
{
    public static class SquareSum
    {
        public static int Handle(int[] numbers)
        {
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                result += (numbers[i] * numbers[i]);
            }

            return result;
        }
    }
}
