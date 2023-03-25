using System;

namespace Codewars._8_kyu
{
    public static class RemoveStringSpaces
    {
        public static string Handle(string input)
        {
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() != " ")
                {
                    result += input[i];
                }
            }

            return result;
        }
    }
}
