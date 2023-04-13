namespace Codewars._7_kyu
{
    public static class VowelCount
    {
        public static int Handle(string str)
        {
            int vowelCount = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (str[i] == vowels[j])
                    {
                        vowelCount++;
                    }
                }
            }

            return vowelCount;
        }
    }
}
