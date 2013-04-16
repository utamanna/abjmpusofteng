
using System;
using TICSET;
using gamePlay;
using System.Windows.Forms;
//make a variable for an array for winning combinations



//findBlocks();
//findOffenses();
//calculateBestMove();

namespace AI
{
    class winningCombo {
        private int[] positions;
        public winningCombo(int a, int b, int c, int d) 
        {
            positions = new int[4] {a, b, c, d};
        }
        public bool hasPosition(int pos) {
            if (positions[0] == pos || positions[1] == pos || positions[2] == pos || positions[3] == pos ) return true;
            else return false;
        }
        public int[] getPositions() 
        {
            return positions;
        }
        public int getScore(virtualBoard board, char gamePiece, int weight) {
            //MessageBox.Show("Using piece: " + gamePiece);
            /* checks current combo to see what score it has
             * score is equal to the number of times gamePiece shows up in the combo, multiplied by weight,
             * UNLESS the other piece shows up.
             * This is so that you do not block or try to make an offensive move on a position that is already blocked.
             */
            int unadjustedScore = 0;
            bool blocked = false;
            char otherPiece = ' ';  //arbitrary value for otherpiece. 
            if (gamePiece == 'X') otherPiece='O';   
            else if (gamePiece == 'O') otherPiece = 'X';
            else MessageBox.Show("Piece Error in winningCombo.getScore; using piece: " + gamePiece);  //used if piece is neither X or O
            
            for (int x=0; x<4; x++) { //Check each position
                int pos = positions[x];
                if (board.getPieceAtPosition(pos)==gamePiece) unadjustedScore++;       //if it has gamePiece in it, increment unadjusted score
                else if (board.getPieceAtPosition(pos) == otherPiece) blocked=true;    //if it has the otherPiece, set blocked.
            }

            if (blocked) return 0;                                          //If the combo is blocked, we don't want to move there, so return 0
            else return unadjustedScore*unadjustedScore*weight;                             //multiply by weight.
        }
    }

    class winningComboList
    {
        private winningCombo[] combos = new winningCombo[28];
        public winningComboList()
        {
            buildList();
        }
        private void buildList()
        {
            /* virtualBoard Layout:
             * 0   1   2   3   4
             * 5   6   7   8   9
             * 10  11  12  13  14
             * 15  16  17  18  19
             * 20  21  22  23  24
             */
            //horizontal
            combos[0] = new winningCombo(0, 1, 2, 3);
            combos[1] = new winningCombo(1, 2, 3, 4);
            combos[2] = new winningCombo(5, 6, 7, 8);
            combos[3] = new winningCombo(6, 7, 8, 9);
            combos[4] = new winningCombo(10, 11, 12, 13);
            combos[5] = new winningCombo(11, 12, 13, 14);
            combos[6] = new winningCombo(15, 16, 17, 18);
            combos[7] = new winningCombo(16, 17, 18, 19);
            combos[8] = new winningCombo(20, 21, 22, 23);
            combos[9] = new winningCombo(21, 22, 23, 24);
            //vertical
            combos[10] = new winningCombo(0, 5, 10, 15);
            combos[11] = new winningCombo(5, 10, 15, 20);
            combos[12] = new winningCombo(1, 6, 11, 16);
            combos[13] = new winningCombo(6, 11, 16, 21);
            combos[14] = new winningCombo(2, 7, 12, 17);
            combos[15] = new winningCombo(7, 12, 17, 22);
            combos[16] = new winningCombo(3, 8, 13, 18);
            combos[17] = new winningCombo(8, 13, 18, 23);
            combos[18] = new winningCombo(4, 9, 14, 19);
            combos[19] = new winningCombo(9, 14, 19, 24);
            //diagonal down
            combos[20] = new winningCombo(0, 6, 12, 18);
            combos[21] = new winningCombo(6, 12, 18, 24);
            combos[22] = new winningCombo(5, 11, 17, 23);
            combos[23] = new winningCombo(1, 7, 13, 19);
            //diagonal up
            combos[24] = new winningCombo(15, 11, 7, 3);
            combos[25] = new winningCombo(20, 16, 12, 8);
            combos[26] = new winningCombo(16, 12, 8, 4);
            combos[27] = new winningCombo(21, 17, 13, 9);

        }
        public winningCombo[] getCombosWithPosition(int pos)
        {
            /*
             * gets all winning combinations that contain a position. for example, calling it with 19 will return a winningCombo[]
             * with {winningCombo(16,17,18,19), winningCombo(4, 9, 14, 19), winningCombo(1, 7, 13, 19)}
             */
            winningCombo[] results = new winningCombo[28];      //to start, build a big array
            int index = 0;
            for (int x = 0; x < 28; x++)
            {
                winningCombo c = combos[x];
                if (c.hasPosition(pos))
                {               //on the combolist array, check if each one has that position
                    results[index] = combos[x];                 //if so, add it
                    index++;
                }
            }
            winningCombo[] ret = new winningCombo[index];     //Now that we know how many there are, build a correct-sized array
            for (int i = 0; i < index; i++)
            {                       // and add each winningCombo to it
                ret[i] = results[i];
            }

            return ret; //return the correct sized array

        }
    }
    class computerPlayer  :   Player
    {
        /*
         * This class allows us to call "new computerPlayer("X")" when a 1player game is started. 
        */
        //private char computersGamePiece; //Set to X or O
        private string id;
        private char GamePiece;
        private bool isHuman;
        private winningComboList WCL;
        public computerPlayer(char piece) :base("AI", piece, false)
        {
            GamePiece = piece;
            this.id = "AI";
            this.isHuman = false;
            WCL = new winningComboList();                      //Build the Winning Combo List
        }
        int[] calculateDefensiveMoves(virtualBoard currentBoard) {
            char humansGamePiece=' ';                                           //In Defensive check, we need to check against the other player's piece
            if (GamePiece == 'X') humansGamePiece = 'O';
            else if (GamePiece == 'O') humansGamePiece = 'X';
            else MessageBox.Show("Piece Error in winningCombo.getScore; using piece: " + GamePiece);  //used if piece is neither X or O
            int[] results = new int[25];
            for (int x = 0; x < 25; x++) results[x] = 0; // set result set to 0

            for (int pos = 0; pos < 25; pos++)                                  //loop through each position
            {
                if (currentBoard.getPieceAtPosition(pos) == 'N') //Only loop check it if the spot it empty.
                {

                    winningCombo[] WCs = WCL.getCombosWithPosition(pos);            //Get all the combos that intersect that position
                    int score = 5;
                    foreach (winningCombo WC in WCs)                                // loop through the intersecting combos
                    {
                        score += WC.getScore(currentBoard, humansGamePiece, 5);  //add the score
                        //TODO: Change 5 to be the correct weight
                    }
                    results[pos] = score;                                           //set the score at that position
                }
            }

            return results;
        }
        int[] calculateOffensiveMoves(virtualBoard currentBoard)
        {
            winningComboList WCL = new winningComboList();                      //Build the Winning Combo List
            int[] results = new int[25];
            for (int x = 0; x < 25; x++)  results[x] = 0; // set result set to 0

            for (int pos = 0; pos < 25; pos++)                                  //loop through each position
            {
                if (currentBoard.getPieceAtPosition(pos) == 'N') //Only loop check it if the spot it empty.
                {
                    winningCombo[] WCs = WCL.getCombosWithPosition(pos);            //Get all the combos that intersect that position
                    int score = 1;
                    foreach (winningCombo WC in WCs)                                // loop through the intersecting combos
                    {
                        score += WC.getScore(currentBoard, GamePiece, 5);  //add the score
                        //TODO: Change 5 to be the correct weight
                    }
                    results[pos] = score;                                           //set the score at that position
                }
            }

            return results;

        }

        public override void startTurn(Game game)
        {
            
            //call this function at the start of every computer turn. This will kick off the AI and commit a move.
            int[] DefensiveMoves =new int[25];   
            int[] OffensiveMoves = new int[25];
            

            DefensiveMoves = calculateDefensiveMoves(game.virtualBoard);
            OffensiveMoves = calculateOffensiveMoves(game.virtualBoard);
            //MessageBox.Show("Computer is making moves");
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
            //MessageBox.Show("Computer move: " + bestMoveIndex);
            game.makeMove(bestMoveIndex);                    //When we have the best move, commit it

        }

        
    }
}