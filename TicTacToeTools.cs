using System;
using System.Security.Cryptography.X509Certificates;

public class TicTacToeTools
{

    //ValidateGuess
    public bool ValidateGuess(string boardPosition, List<string> boardArray)
    {
        bool result = true;
        if (!int.TryParse(boardPosition, out int boardPositionNum))
        {
            Console.WriteLine("Invalid input: Please enter a number");
            return false;
        }

        if (boardPositionNum < 1 || boardPositionNum > 9)
        {
            Console.WriteLine("Invalid Position: Pick a position between 1 and 9");
            return false;
        }

        if (boardArray[boardPositionNum - 1] != " ")
        {
            Console.WriteLine("Position already taken!");
            return false;
        }
        return result;
    }
    //Update board
    public List<string> UpdateBoard(int playerNum, int boardPosition, List<string> boardArray)
	{
        //convert playernumber to X or O
        if (playerNum == 1)
        {
            //update the board to reflect the new boardposition
            boardArray[boardPosition - 1] = "X";
        }
        else if (playerNum == 2)
        {
            //update the board to reflect the new boardposition
            boardArray[boardPosition - 1] = "O";
        }
        return boardArray;
    }
    //CheckWin
    public int CheckWin(List<string> boardArray)
    {

        //validate the ways that player 1 can win
        
            // Check for Player 1 (X) wins
            if (boardArray[0] == "X" && boardArray[1] == "X" && boardArray[2] == "X") return 1;
            if (boardArray[3] == "X" && boardArray[4] == "X" && boardArray[5] == "X") return 1;
            if (boardArray[6] == "X" && boardArray[7] == "X" && boardArray[8] == "X") return 1;
            if (boardArray[0] == "X" && boardArray[3] == "X" && boardArray[6] == "X") return 1;
            if (boardArray[1] == "X" && boardArray[4] == "X" && boardArray[7] == "X") return 1;
            if (boardArray[2] == "X" && boardArray[5] == "X" && boardArray[8] == "X") return 1;
            if (boardArray[0] == "X" && boardArray[4] == "X" && boardArray[8] == "X") return 1;
            if (boardArray[2] == "X" && boardArray[4] == "X" && boardArray[6] == "X") return 1;

            // Check for Player 2 (O) wins
            if (boardArray[0] == "O" && boardArray[1] == "O" && boardArray[2] == "O") return 2;
            if (boardArray[3] == "O" && boardArray[4] == "O" && boardArray[5] == "O") return 2;
            if (boardArray[6] == "O" && boardArray[7] == "O" && boardArray[8] == "O") return 2;
            if (boardArray[0] == "O" && boardArray[3] == "O" && boardArray[6] == "O") return 2;
            if (boardArray[1] == "O" && boardArray[4] == "O" && boardArray[7] == "O") return 2;
            if (boardArray[2] == "O" && boardArray[5] == "O" && boardArray[8] == "O") return 2;
            if (boardArray[0] == "O" && boardArray[4] == "O" && boardArray[8] == "O") return 2;
            if (boardArray[2] == "O" && boardArray[4] == "O" && boardArray[6] == "O") return 2;

            // Check for tie
            bool isBoardFull = true;
            foreach (string cell in boardArray)
            {
                if (cell != "X" && cell != "O")
                {
                    isBoardFull = false;
                    break;
                }
            }
            if (isBoardFull) return 3;

            // Game in progress
            return 0;
    }
    public void PrintBoard(List<string> gameBoard)
    {
        Console.WriteLine();
        for (int i = 0; i < gameBoard.Count; i++)
        {
            if (i % 3 == 0 && i != 0)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------");
            }
            string value = gameBoard[i] == " " ? (i + 1).ToString() : gameBoard[i];
            Console.Write($"| {value} |");
        }
        Console.WriteLine();
    }
}
    
        

