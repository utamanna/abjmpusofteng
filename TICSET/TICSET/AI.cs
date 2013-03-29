
using System;
using TICSET;

//make a variable for an array for winning combinations



//findBlocks();
//findOffenses();
//calculateBestMove();

namespace AI
{
    class computerPlayer
    {
        /*
         * This class allows us to call "new computerPlayer("X")" when a 1player game is started. 
        */
        char computersGamePiece; //Set to X or O

        int[] calculateDefensiveMoves(char[] currentBoard) { }
        int[] calculateOffensiveMoves(char[] currentBoard) { }

        public void startTurn(Board GameBoard)
        {
            //call this function at the start of every computer turn. This will kick off the AI and commit a move.
            int[] DefensiveMoves =new int[25];   
            int[] OffensiveMoves = new int[25];
            char[] currentBoard = GameBoard.getBoard();

            DefensiveMoves = calculateDefensiveMoves(currentBoard);
            OffensiveMoves = calculateOffensiveMoves(currentBoard);

            int bestMoveIndex = 0;
            int bestMoveValue = 0;

            for (int index = 0; index < 25; index++)
            {
                //loop through to find the best move
                if (DefensiveMoves[index] + OffensiveMoves[index] > bestMoveValue)      //if this move is better,
                {                                                                       
                    bestMoveIndex = index;                                              //set the best move to the index
                    bestMoveValue = DefensiveMoves[index] + OffensiveMoves[index];      //and the best move value to the value
                }
            }

            GameBoard.commitMove(computersGamePiece, bestMoveIndex);                    //When we have the best move, commit it

        }
    }
}