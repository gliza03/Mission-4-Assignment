using System;
using System.Security.Cryptography.X509Certificates;

public class TicTacToeTools
{
	
    //ValidateGuess
    public bool ValidateGuess(string boardPosition, List<string> boardArray)
    {

        bool result = true;

        int.Parse(boardPosition);
        if (int.TryParse(boardPosition)
        {
            Console.WriteLine("sorry, the guess needs to be a letter");
            result = false;
        }
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


        return 
        //Validate the ways that player 2 can win
    }
    //PrintBoard
    public 
        //return player number 
        //return that it's a tie
        // Game is still playing
        

