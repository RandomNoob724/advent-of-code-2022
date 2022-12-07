var inputData = Utils.Utils.GetInput(2);

var scoreMap = new Dictionary<string, (short scoreA, short scoreB)>
{
    { "A X", (4, 3) },
    { "A Y", (8, 4) },
    { "A Z", (3, 8) },

    { "B X", (1, 1) },
    { "B Y", (5, 5) },
    { "B Z", (9, 9) },

    { "C X", (7, 2) },
    { "C Y", (2, 6) },
    { "C Z", (6, 7) },
};

long firstPartScore = inputData.Sum(x => scoreMap.First(y => y.Key == x).Value.scoreA);
long secondPartScore = inputData.Sum(x => scoreMap.First(y => y.Key == x).Value.scoreB);

Console.WriteLine($"Part 1: {firstPartScore}");
Console.WriteLine($"Part 2: {secondPartScore}");