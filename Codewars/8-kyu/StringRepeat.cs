namespace Codewars._8_kyu
{
    public static class StringRepeat
    {
        public static string Handle(int n, string s)
        {
            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += s;
            }

            return result;
        }
    }
}
