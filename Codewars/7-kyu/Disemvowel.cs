namespace Codewars._7_kyu
{
    public static class Disemvowel
    {
        public static string Handle(string str)
        {
            string result = "";
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (
                        str[i].ToString().ToLower() != vowels[0].ToString().ToLower() &&
                        str[i].ToString().ToLower() != vowels[1].ToString().ToLower() &&
                        str[i].ToString().ToLower() != vowels[2].ToString().ToLower() &&
                        str[i].ToString().ToLower() != vowels[3].ToString().ToLower() &&
                        str[i].ToString().ToLower() != vowels[4].ToString().ToLower())
                    {
                        result += str[i];
                        break;
                    }
                }
            }

            return result;
        }
    }
}
