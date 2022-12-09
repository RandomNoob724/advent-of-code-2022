using System.IO;

namespace Utils
{
    public static class ReadFile
    {
        public static string[] GetInput(int day)
        {
            return File.ReadAllLines($"../../../../day{day}/input.txt");
        }

        public static string[] GetTestInput(int day)
        {
            return File.ReadAllLines($"../../../../day{day}/test.txt");
        }
    }
}