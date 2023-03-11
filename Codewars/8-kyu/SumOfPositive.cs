namespace Codewars._8_kyu
{
  public static class SumOfPositive
  {
    public static int Handle(int[] arr)
    {
      int result = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] > 0)
        {
          result += arr[i];
        }
      }
      return result;
    }
  }
}
