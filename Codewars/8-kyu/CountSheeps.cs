namespace Codewars._8_kyu
{
    public static class CountSheeps
    {
        public static int Handle(bool[] sheeps)
        {
            int result = 0;

            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i])
                {
                    result++;
                }
            }

            return result;
        }
    }
}
