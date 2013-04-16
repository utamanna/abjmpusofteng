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


    public class virtualBoard
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
        private Form1 vBoard;
        public virtualBoard(Form1 vb, Game gameObj)
        {
            game = gameObj;
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
            
            vBoard.drawMove( pos, Player.getGamePiece()); //display the move
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
    public class Player
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
        public virtual void startTurn(Game game) { }

    }
    class HumanPlayer : Player
    {
        private string id;
        private char GamePiece;
        private bool isHuman;

        public HumanPlayer(string ID, char piece)
            : base(ID, piece, true)
        {
            GamePiece = piece;
            id = ID;
            isHuman = true;
        }
        public override void startTurn(Game game)
        {

            //MessageBox.Show("human's move");
        }
    }
    public class Game
    {
        public virtualBoard virtualBoard;
        private Player player1;
        private Player player2;
        private Player currentPlayer;
        //private string IDofPlayerMakingMove;
        //private char PieceOfPlayerMakingMove;
        private Form1 vb;
        //private gameSettings gs;
        

        
        public Game(Settings settings)
        {
            player1 = settings.player1;
            player2 = settings.player2;
            //MessageBox.Show(player2.getID());
            if (player1.getGamePiece() == settings.PieceThatGoesFirst) 
            {
                currentPlayer = player1;
            }
            else if (player2.getGamePiece() == settings.PieceThatGoesFirst) 
            {
                currentPlayer = player2;
            }

            vb = new Form1(settings, this);
            
            virtualBoard = new virtualBoard(vb, this);
            if (settings.difficulty == 1 || settings.difficulty == 2)
            {
                //something here that says its a computer player
            }
            currentPlayer.startTurn(this);
            
            vb.Show();
            
        }
        public void Turnover()
        {
            if (player1.getID() == currentPlayer.getID())
            {
                currentPlayer = player2;
            }
            else
            {
                currentPlayer = player1;
            }
            currentPlayer.startTurn(this);
        }
        public void makeMove(Player p, int position)
        { //might be obsolete
            if (p.getID() == currentPlayer.getID())
            {
                virtualBoard.commitMove(p, position);
                Turnover();
            }
           
            


        }
        public void makeMove(int position)
        {
            //MessageBox.Show("making move: "+position);
            if (player1.getID() == currentPlayer.getID())
            {
                virtualBoard.commitMove(player1, position);
            }
            if (player2.getID() == currentPlayer.getID())
            {
                virtualBoard.commitMove(player2, position);
                
            }

            //Turnover();

        }
    }
}