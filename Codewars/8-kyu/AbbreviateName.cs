namespace Codewars._8_kyu
{
    public static class AbbreviateName
    {
        public static string Handle(string name)
        {
            string result = "";

            char firstLetter = name[0];
            char lastLetter = name[name.IndexOf(" ") + 1];
            
            result = $"{firstLetter.ToString().ToUpper()}.{lastLetter.ToString().ToUpper()}";

            return result;
        }
    }
}
