using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gamePlay;

namespace TICSET
{
<<<<<<< HEAD
    public class Settings
    {

        public Player player1;          //First player
=======
    class Settings
    {

         public Player player1;          //First player
>>>>>>> 4c6988a8b8d3bf8f75179d9757c9b4fc8815e3f2
        public Player player2;          //Second Player, these are in arbitrary order
        public char PieceThatGoesFirst; //X or O, first player
        public int difficulty;

<<<<<<< HEAD
        
=======

>>>>>>> 4c6988a8b8d3bf8f75179d9757c9b4fc8815e3f2
        public Settings(Player p1, Player p2, char firstPiece, int diff)
        { ///constructor
            player1 = p1;
            player2 = p2;
            PieceThatGoesFirst = firstPiece;
<<<<<<< HEAD

            // WHen diff = 3 assume that its a two player game.
            // This saves us from creating another constructor.
            difficulty = diff; 
=======
            difficulty = diff;
>>>>>>> 4c6988a8b8d3bf8f75179d9757c9b4fc8815e3f2
        }

    }
}
