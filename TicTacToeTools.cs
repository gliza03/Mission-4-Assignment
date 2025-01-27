using System;
using System.Security.Cryptography.X509Certificates;

public class TicTacToeTools
{
	
    //ValidateGuess
    public bool ValidateGuess(int boardPosition, List<string> boardArray)
    {

        bool result = true;

        //Check if the position is in the range 0-8
        if (boardPosition < 1)
        {
            Console.WriteLine("Invalid Position: Pick a position between 1 and 9");
            result = false;
        }
        //Check if the position is in the range 0-8
        if (boardPosition > 9)
        {
            Console.WriteLine("Invalid Position: Pick a position between 1 and 9");
            result = false;
        }
        //Check if the position is a number
        else if (int.TryParse(boardPosition)
        {
            Console.WriteLine("sorry, the guess needs to be a letter");
            result = false;
        }
        //If the position is taken
        else if (boardArray[boardPosition] != "")
        {
            result = false;
        }

        return result;//return true if position is available
    }
    //Update board
    public List<string> UpdateBoard(int playerNum, int boardPosition, List<string> boardArray)
	{
        //convert playernumber to X or O
        if (playerNum == 1)
        {
            //update the board to reflect the new boardposition
            boardArray[boardPosition] = "X";
        }
        else (playerNum == 2)
        {
            //update the board to reflect the new boardposition
            boardArray[boardPosition] = "O";
        }
        return boardArray;
		//input X or O in respective boardposition
		//Return the Board
	}
    //CheckWin
    public int CheckWin(List<string> boardArray)
    {

        //validate the ways that player 1 can win
        if (boardArray[0] == "X" && boardArray[1] == "X" && boardArray[2] == "X")
        {
            return 1;
        }


        return 
        //Validate the ways that player 2 can win
    }
        //return player number 
        //return that it's a tie
        // Game is still playing
        
}
