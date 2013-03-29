using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TICSET
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }



    }
    static class Board
    {
        /*
         * This class implements a virtual board. Whne complete, it should automatically log all moves whenever commitMove is called.
         * getBoard() returns the board so it can be manipulated by the AI. 
         * 
         * TODO: someone needs to add code to the UI buttonssuch that they call commitMove() with the parameters so that players can log their moves in the virtual board
         * SUGGESTION: We may also need a class of Player, that has 
         * {
         *      string PlayerID; // the ID of the player for the database, or "AI" for computer player
         *      char GamePiece;  // X or O
         *      //other functions like getters and setters
         * }
         * This would allow us to more easily track moves and allow us to pass a Player argument for moves. 
         * Usman, I think you should start implementation first so it integrates well with the DB. possibly adding a LogMove and LogWin/Loss function to the playerclass.
         * That way, the code feels more player oriented.
         */
        char[] board = new char[25];
        public void commitMove(char Player, int pos)
        {
            //commits a move to the board and calls "log", a not-yet-implemented function to log the move in the database;
            //TODO: Can someone link this back to the UI so that It makes the move visible?
            board[pos] = Player;
            //log();
        }
        public char[] getBoard()
        {
            return board;
        }

    }
}

