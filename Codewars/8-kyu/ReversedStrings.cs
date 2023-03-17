namespace Codewars._8_kyu
{
    public static class ReversedStrings
    {
        public static string Handle(string str)
        {
            string result = "";

            for (int i = str.Length; i > 0; i--)
            {
                result += str[i - 1];
            }

            return result;
        }
    }
}
