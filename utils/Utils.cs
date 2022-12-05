using System.IO;

namespace Utils
{
    public static class Utils
    {
        public static string GetInput(int day)
        {
            return File.ReadAllText($"../../../../day{day}/input.txt");
        }

        public static string GetTestInput(int day)
        {
            return File.ReadAllText($"../../../../day{day}/test.txt");
        }
    }
}