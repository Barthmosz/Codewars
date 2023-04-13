namespace Codewars._7_kyu
{
    public static class SquareDigits
    {
        public static int Handle(int n)
        {
            string s = n.ToString();
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                result += ((s[i] - '0') * (s[i] - '0')).ToString();
            }

            return int.Parse(result);
        }
    }
}
