// Iterate and Print Values
static void PrintList(List<string> MyList)
{
    System.Console.WriteLine("Here is a list of my favorite cars:");
    foreach (string entry in MyList)
    {
        System.Console.WriteLine($"{entry}");
    }
}
PrintList(new List<string>() { "Ferrari", "Lamborghini", "BMW" });


// Print Sum
static int SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach (int numbers in IntList)
    {
        sum += numbers;
    }
    return sum;
}
Console.WriteLine(SumOfNumbers(new List<int>() { 4, 7, 9, 14 }));


// Find Largest Value
static int FindMax(List<int> IntList)
{
    int max = 0;
    foreach (int entry in IntList)
    {
        max = IntList.Max();
    }
    return max;
}
Console.WriteLine(FindMax(new List<int>() { 17, 16, 15, 14 }));


// Square the Values
static void PrintIntList(List<int> SquaredIntList)
{
    System.Console.WriteLine("Squared Numbers:");
    foreach (int entry in SquaredIntList)
    {
        System.Console.WriteLine($"{entry}");
    }
}

static List<int> SquaredValues(List<int> IntList)
{
    for (int i = 0; i < IntList.Count; i++)
    {
        IntList[i] *= IntList[i];
    }
    return IntList;
}
PrintIntList(new List<int>(SquaredValues(new List<int>() { 8, 9, 10, 11 })));


// Replace Negative Numbers with 0
static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }
    }
    return IntArray;
}
int[] IntArray = { 7, 9, -11, -13, 5 };
NonNegatives(IntArray);

foreach (int entry in IntArray)
{
    System.Console.WriteLine($"{entry}");
}


// Print Dictionary
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Model", "Testarossa");
MyDictionary.Add("Horsepower", "450");
MyDictionary.Add("Year", "1989");
MyDictionary.Add("Condition", "Excellent");
static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    foreach (KeyValuePair<string, string> entry in MyDictionary)
    {
        System.Console.WriteLine($"{entry}");
    }
}
PrintDictionary(MyDictionary);


// Find Key
static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
    if (MyDictionary.ContainsKey(SearchTerm))
    {
        return true;
    }
    else
    {
        return false;
    }
}
System.Console.WriteLine(FindKey(MyDictionary, "Year"));
System.Console.WriteLine(FindKey(MyDictionary, "Poker"));


// Generate a Dictionary
List<string> Names = new List<string>() { "Julie", "James", "Monica", "Harold" };
List<int> FavoriteNums = new List<int>() { 6, 12, 7, 10 };
static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> UserDictionary = new Dictionary<string, int>();
    for (int i = 0; i < Names.Count; i++)
    {
        UserDictionary.Add(Names[i], Numbers[i]);
    }
    return UserDictionary;
}
Dictionary<string, int> UserDictionary = GenerateDictionary(Names, FavoriteNums);
foreach (KeyValuePair<string, int> entry in UserDictionary)
{
    System.Console.WriteLine($"{entry.Key}: {entry.Value}");
}



