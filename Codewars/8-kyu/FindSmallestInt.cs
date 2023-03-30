namespace Codewars._8_kyu
{
    public static class FindSmallestInt
    {
        public static int Handle(int[] args)
        {
            int result = args[0];

            for (int i = 0; i < args.Length; i++)
            {
                if (result > args[i])
                {
                    result = args[i];
                }
            }

            return result;
        }
    }
}
