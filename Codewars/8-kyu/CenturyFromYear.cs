namespace Codewars._8_kyu
{
    public static class CenturyFromYear
    {
        public static int Handle(int year)
        {
            if (year % 100 == 0)
            {
                return year / 100;
            }
            else
            {
                return (year / 100) + 1;
            }
        }
    }
}
