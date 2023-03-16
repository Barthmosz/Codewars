namespace Codewars._8_kyu
{
  public static class RemoveFirstAndLastChat
  {
    public static string Handle(string s)
    {
      string result = "";

      for (int i = 1; i < s.Length - 1; i++)
      {
        result += s[i];
      }

      return result;
    }
  }
}
