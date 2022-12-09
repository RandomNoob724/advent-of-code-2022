string[] inputData = Utils.ReadFile.GetInput(3);

HashSet<char> faultyPackedItems = new HashSet<char>();

foreach (string input in inputData)
{
    string firstRucksack = input.Substring(0, (int)(input.Length / 2));
    string secondRucksack = input.Substring((int)(input.Length / 2), (int)(input.Length / 2));

    foreach(char letter in firstRucksack)
    {
        if(secondRucksack.Contains(letter))
        {
            faultyPackedItems.Add(letter);
        }
    }
}
int score = 0;
foreach(char letter in faultyPackedItems)
{
    int unicode = letter;
    if(unicode >= 97)
    {
        Console.WriteLine($"{(char)(unicode)} {unicode - 96}");
        score += unicode - 96;
    }
    else
    {
        Console.WriteLine($"{(char)(unicode)} {unicode - 38}");
        score += unicode - 38;
    }
}

Console.WriteLine(faultyPackedItems);
Console.WriteLine(score);
