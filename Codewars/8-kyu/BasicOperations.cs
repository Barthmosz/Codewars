namespace Codewars._8_kyu
{
    public static class BasicOperations
    {
        public static double Handle(char operation, double value1, double value2)
        {
            return operation switch
            {
                '+' => value1 + value2,
                '-' => value1 - value2,
                '*' => value1 * value2,
                '/' => value1 / value2,
                _ => default,
            };
        }
    }
}
