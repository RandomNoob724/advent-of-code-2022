using System;
using System.Collections.Generic;
using System.Linq;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var inputData = Utils.Utils.GetInput(1);
            var inputData = Utils.Utils.GetInput(1);
            string[] listOfCalories = inputData.Split("\n");

            List<int> amountPerElf = new List<int>();
            int sum = 0;

            foreach(string calories in listOfCalories)
            {
                if (String.IsNullOrEmpty(calories))
                {
                    amountPerElf.Add(sum);
                    sum = 0;
                }
                else
                {
                    sum += Convert.ToInt32(calories);
                }
            }

            amountPerElf.Sort();

            Console.WriteLine(amountPerElf.Last());
            Console.WriteLine(amountPerElf.TakeLast(3).Sum());
        }
    }
}
