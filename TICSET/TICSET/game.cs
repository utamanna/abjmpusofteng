using System;
using TICSET;
using AI;
using System.Windows.Forms;

namespace gamePlay
{

    //class gameSettings
    //{
    //    public Player player1;          //First player
    //    public Player player2;          //Second Player, these are in arbitrary order
    //    public char PieceThatGoesFirst; //X or O, first player
    //    public int difficulty;


    //    public gameSettings(Player p1, Player p2, char firstPiece, int diff)
    //    { ///constructor
    //        player1 = p1;
    //        player2 = p2;
    //        PieceThatGoesFirst = firstPiece;
    //        difficulty = diff;
    //    }

        
    //}


    class visualBoard
    {   //Deprecated byUsman Joe and Bryan on 4/10, will become Form1
        private Button[] buttonArray;
        public visualBoard(Button[] ba)
        {
            /*
             * Makes sure all buttons are loaded and not set to X or O (possibly by calling resetBoard())
             * Loads private variable buttonArray with 25 buttons
             *  
             */
            buttonArray = ba;


        }
        public void resetBoard()
        {
            /*
             * Resets the buttons on the UI to be blank
             */
        }
        public void makeMove(char piece, int position)
        {
            /*
             * Piece is either 'X' or 'O'
             * position is 0-24 marker of the board. The board is of the format:
             * 0   1   2   3   4
             * 5   6   7   8   9
             * 10  11  12  13  14
             * 15  16  17  18  19
             * 20  21  22  23  24
             * 
             * When makeMove is called, 
             * the UI needs to update the button that corresponds to the position to be either X or O according to the value passed by piece
             * 
             */
            buttonArray[position].Text = Convert.ToString(piece);
            
        }





    }
    class virtualBoard
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

        private char[] board = new char[25];
        private Game game;
        private visualBoard vBoard;
        public virtualBoard(visualBoard vb)
        {
            vBoard = vb; //bind virtual board to visual board
            for (int p = 0; p < 25; p++)
            {
                board[p] = 'N'; //set each board position N for "null"
            }

        }
        public void commitMove(Player Player, int pos)
        {
            //commits a move to the board and calls "log", a not-yet-implemented function to log the move in the database;
            //TODO: Can someone link this back to the UI so that It makes the move visible?
            board[pos] = Player.getGamePiece();
            vBoard.makeMove(Player.getGamePiece(), pos); //display the move
            game.Turnover(); //we are done making moves. Change turn to other player.
            //log();
        }
        public void bindGame(Game g) //fills in the game variable with the currently playing game
        {
            game = g;
        }
        public char[] getBoard()
        {
            return board;
        }
        public char getPieceAtPosition(int pos)
        {
            return board[pos];
        }

    }
    class Player
    {
        private string id;
        private char GamePiece;
        private bool isHuman;

        public Player(string ID, char piece, bool playerIsHuman)
        {
            id = ID;
            GamePiece = piece;
            isHuman = playerIsHuman;
        }
        public void setGamePiece(char piece)
        {
            if (piece == 'O' || piece == 'X') GamePiece = piece;
            else MessageBox.Show("Trying to set player's game piece to: " + piece);
        }
        public string getID()
        {
            return id;
        }
        public char getGamePiece()
        {
            return GamePiece;
        }
        public void startTurn(virtualBoard board) { }

    }
    class HumanPlayer : Player
    {
        private string id;
        private char GamePiece;
        private bool isHuman;

        public HumanPlayer(string ID, char piece)
            : base(ID, piece, true)
        {

        }
        public void startTurn(virtualBoard board)
        {
            //how do I start a turn for human?

        }
    }
    class Game
    {
        private virtualBoard virtualBoard;
        private Player player1;
        private Player player2;
        private string IDofPlayerMakingMove;
        private char PieceOfPlayerMakingMove;
        //private gameSettings gs;
        

        
        public Game(Settings settings)
        {
            player1 = settings.player1;
            player2 = settings.player2;
            PieceOfPlayerMakingMove = settings.PieceThatGoesFirst;

            if (settings.difficulty == 1 || settings.difficulty == 2)
            {
                //something here that says its a computer player
            }
            if (player1.getGamePiece() == PieceOfPlayerMakingMove)
            {
                IDofPlayerMakingMove = player1.getID();
                player1.startTurn(virtualBoard);
            }
            else if (player2.getGamePiece() == PieceOfPlayerMakingMove)
            {
                IDofPlayerMakingMove = player2.getID();
                player2.startTurn(virtualBoard);

            }
            Form1 vb = new Form1();
            vb.Show();
            
        }
        public void Turnover()
        {
            if (player1.getID() == IDofPlayerMakingMove)
            {
                player2.startTurn(virtualBoard);
                IDofPlayerMakingMove = player2.getID();
            }
            else
            {
                player1.startTurn(virtualBoard);
                IDofPlayerMakingMove = player1.getID();
            }
        }
        public void makeMove(Player p, int position)
        {
            if (p.getID() == IDofPlayerMakingMove)
            {
                virtualBoard.commitMove(p, position);
                Turnover();
            }
           
            


        }
    }
}