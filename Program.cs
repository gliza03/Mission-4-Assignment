string choice = "";
int position = 0;
bool GameOver = false;
int counter = 0;

TicTacToeTools tt = new TicTacToeTools();

List<string> gameBoard = new List<string>()
{
    " "," "," ",
    " "," "," ",
    " "," "," ",
};

Console.WriteLine("Welcome to 4-10's Tic-Tac-Toe!");

Console.WriteLine("Player 1 will be X and Player 2 will be O, are you ready?");

for (int i = 0; i < gameBoard.Count; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine();
    }
    Console.Write($"|{i+1}|");
}

do
{
    // Check if the input is valid
    do
    {
        choice = Console.ReadLine();
    }
    while (!tt.ValidateGuess(choice, gameBoard));

    // Turn the input into a position
    position = int.Parse(choice);

    // Check if it's player 1 or player 2
    if (counter % 2 == 0)
    {
        tt.UpdateBoard(1, position, gameBoard);
        tt.PrintBoard(gameBoard);
        counter++;
    }
    else
    {
        tt.UpdateBoard(1, position, gameBoard);
        tt.PrintBoard(gameBoard);
        counter++;
    }


    if (tt.CheckWin(gameBoard) == '1')
    {
        Console.WriteLine("Player 1 has won! Player 2, you are a LOSER!");
        GameOver = true;
    }
    else if (tt.CheckWin(gameBoard) == '2')
    {
        Console.WriteLine("Player 2 has won! Player 1, you are a LOSER!");
        GameOver = true;
    }
    else if (tt.CheckWin(gameBoard) == '3')
    {
        Console.WriteLine("Nobody won! You both suck :D");
        GameOver = true;
    }
    else
    {
        GameOver = false;

    }
}
while (!GameOver);
