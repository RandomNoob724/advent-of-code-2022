string[] inputData = Utils.ReadFile.GetInput(3);

string faultyPackedItems = String.Empty;
string groupBadges = String.Empty;

int CharValue(char c) => c < 97 ? c - 65 + 27 : c - 97 + 1;

foreach (string input in inputData)
{
    string firstRucksack = input.Substring(0, (int)(input.Length / 2));
    string secondRucksack = input.Substring((int)(input.Length / 2), (int)(input.Length / 2));

    foreach (char letter in firstRucksack)
    {
        if (secondRucksack.Contains(letter))
        {
            faultyPackedItems += letter;
            break;
        }
    }
}

var dataB = inputData
    .Chunk(3);

foreach(var group in dataB)
{
    string firstRucksack = group.First();
    foreach(var letter in firstRucksack)
    {
        if (group[1].Contains(letter) && group[2].Contains(letter))
        {
            groupBadges += letter;
            break;
        }
    }
}

int score = 0;
foreach (char letter in faultyPackedItems)
{
    score += CharValue(letter);
}

int groupScore = 0;
foreach (char letter in groupBadges)
{
    groupScore += CharValue(letter);
}

Console.WriteLine(score);
Console.WriteLine(groupScore);