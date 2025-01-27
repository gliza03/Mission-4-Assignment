string choice = "";
List<string> list = new List<string>()
{
    "a","a","a",
    "a","a","a",
    "a","a","a",
};

Console.WriteLine("Welcome to 4-10's Tic-Tac-Toe!");

Console.WriteLine("Which symbol would you like to choose?\n 1. X\n 2. O");

//choice = verifyChoice(Console.ReadLine());


for (int i = 0; i < list.Count; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine();
    }
    Console.Write($"|{list[i]}|");
}

