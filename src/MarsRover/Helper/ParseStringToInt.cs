namespace MarsRover.Helper
{
    public static class ParseStringToInt
    {
        public static int Parse(string stringValue)
        {
            int result = int.TryParse(stringValue, out int intValue) ? intValue : 0;
            return result;
        }
    }
}
