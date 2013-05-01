using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gamePlay;

namespace TICSET
{
    public class Settings
    {

        public Player player1;          //First player
        public Player player2;          //Second Player, these are in arbitrary order
        public char PieceThatGoesFirst; //X or O, first player
        public int difficulty;

        
        public Settings(Player p1, Player p2, char firstPiece, int diff)
        { ///constructor
            player1 = p1;
            player2 = p2;
            PieceThatGoesFirst = firstPiece;

            // WHen diff = 3 assume that its a two player game.
            // This saves us from creating another constructor.
            difficulty = diff; 
        }

    }
}
