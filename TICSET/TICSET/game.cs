using System;
using TICSET;
using AI;
using System.Windows.Forms;
using Database;

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

        private int[,] winPattern ={
            {0,1,2,3},
            {1,2,3,4},
            {5,6,7,8},
            {6,7,8,9},
            {10,11,12,13},
            {11,12,13,14},
            {15,16,17,18},
            {16,17,18,19},
            {20,21,22,23},
            {21,22,23,24},
            {4,8,12,16},
            {0,5,10,15},
            {5,10,15,20},
            {1,6,11,16},
            {6,11,16,21},
            {2,7,12,17},
            {7,12,17,22},
            {3,8,13,18},
            {8,13,18,23},
            {4,9,14,19},
            {9,14,19,24},
            {0,6,12,18},
            {6,12,18,24},
            {5,11,17,23},
            {1,7,13,19},
            {3,7,11,15},
            {8,12,16,20},
            {9,13,17,21}};

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
        public bool isDraw()
        {
            for (int i = 0; i < 25; i++)
            {
                if (board[i] == 'N') return false;
            }
            return true;
        }
        private bool isGameOver()
        {
            bool gameOver = false;
            for (int i = 0; i < 28; i++)
            {
                int a = winPattern[i, 0], b = winPattern[i, 1], c = winPattern[i, 2], d = winPattern[i, 3];
                char pa, pb, pc, pd;
                pa = board[a]; pb = board[b]; pc = board[c]; pd = board[d];
                if (pa == 'N' || pb == 'N' || pc == 'N' || pd == 'N')
                {
                    continue;
                }
                else if (pa == pb && pb == pc && pc == pd)
                {
                    gameOver = true;
                }

            }
            return gameOver;
        }
        public char whoWon()
        {
            for (int i = 0; i < 28; i++)
            {
                int a = winPattern[i, 0], b = winPattern[i, 1], c = winPattern[i, 2], d = winPattern[i, 3];
                char pa, pb, pc, pd;
                pa = board[a]; pb = board[b]; pc = board[c]; pd = board[d];
                if (pa == 'N' || pb == 'N' || pc == 'N' || pd == 'N')
                {
                    continue;
                }
                else if (pa == pb && pb == pc && pc == pd)
                {
                    return pa;
                }

            }
            return 'N';
        }
        public int[] winningPositions()
        {
            for (int i = 0; i < 28; i++)
            {
                int a = winPattern[i, 0], b = winPattern[i, 1], c = winPattern[i, 2], d = winPattern[i, 3];
                char pa, pb, pc, pd;
                pa = board[a]; pb = board[b]; pc = board[c]; pd = board[d];
                if (pa == 'N' || pb == 'N' || pc == 'N' || pd == 'N')
                {
                    continue;
                }
                else if (pa == pb && pb == pc && pc == pd)
                {
                    int[] ret = { a, b, c, d };
                    return ret;
                }


            }
            int[] retu = { 0, 0, 0, 0 };
            return retu;
        }

        public bool commitMove(Player Player, int pos)
        {
            //commits a move to the board and calls "log", a not-yet-implemented function to log the move in the database;
            //TODO: Can someone link this back to the UI so that It makes the move visible?
            if (board[pos] == 'N')
            {

                board[pos] = Player.getGamePiece();

                vBoard.drawMove(pos, Player.getGamePiece()); //display the move
                if (isGameOver())
                {
                    game.end();
                    MessageBox.Show("Game Over");
                    return false;
                }
                else
                {
                    return true;
                    //game.Turnover(); //we are done making moves. Change turn to other player.
                }
            }
            else
            {
                MessageBox.Show("Move not Allowed");
                return false;
            }
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
        public virtual void setDifficulty(int dif) { }
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

        private bool over = false;
        public virtualBoard virtualBoard;
        private Player player1;
        private Player player2;
        private Player currentPlayer;
        private Form1 vb;



        public Game(Settings settings)
        {
            player1 = settings.player1;
            player2 = settings.player2;
            //MessageBox.Show(player2.getID());
            if (player2.getID() == "AI")
            {
                player2.setDifficulty(settings.difficulty);
            }
            if (player1.getGamePiece() == settings.PieceThatGoesFirst)
            {
                currentPlayer = player1;
            }
            else if (player2.getGamePiece() == settings.PieceThatGoesFirst)
            {
                currentPlayer = player2;
<<<<<<< HEAD
            }

            vb = new Form1(settings, this);

<<<<<<< HEAD
            } 
            //Usman: the rest of this function can be whatever code you need to kick off the visual board (UI)
            Form1 vb = new Form1();
            
=======
            virtualBoard = new virtualBoard(vb, this);
            if (settings.difficulty == 1 || settings.difficulty == 2)
            {
                //something here that says its a computer player
            }
=======
            }

            vb = new Form1(settings, this);

            virtualBoard = new virtualBoard(vb, this);
            if (settings.difficulty == 1 || settings.difficulty == 2)
            {
                //something here that says its a computer player
            }
>>>>>>> 5a2b97b7a2390f5beb4d75a8f3de030e4e0b0e88
            currentPlayer.startTurn(this);

            vb.Show();

        }
        public void defaultTurn()
        {
            currentPlayer.startTurn(this);
<<<<<<< HEAD
>>>>>>> 5a2b97b7a2390f5beb4d75a8f3de030e4e0b0e88
=======
>>>>>>> 5a2b97b7a2390f5beb4d75a8f3de030e4e0b0e88
        }
        public void Turnover()
        {
            if (virtualBoard.isDraw())
            {
                MessageBox.Show("Draw");
            }

            else if (!over)
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
        }
        public void makeMove(Player p, int position)
        { //might be obsolete
            if (p.getID() == currentPlayer.getID())
            {
                virtualBoard.commitMove(p, position);
                //Turnover();
            }




        }
        public void makeMove(int position)
        {
            bool success = false;
            if (player1.getID() == currentPlayer.getID())
            {
                success = virtualBoard.commitMove(player1, position);
            }
            if (player2.getID() == currentPlayer.getID())
            {
                success = virtualBoard.commitMove(player2, position);
            }

            if (success) Turnover();
            else if (!success && !over)
            {
                defaultTurn();
            }
            else if (over)
            {
                int[] poss = virtualBoard.winningPositions(); //the positions that won.
                char winner = virtualBoard.whoWon();
                DatabaseHelper dbHelper = new DatabaseHelper();
                dbHelper.score(player1, player2, winner);
                Gameover go = new Gameover(player1, player2, winner);
                vb.Visible = false;
                go.Show();
            }
        }
        public void end()
        {
            over = true;
        }
    }
}