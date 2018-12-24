/*Jerald Coyne
 * Last Edited: 9/24/2018
 * Class number 4
 * This class hold the player name
 *    and who the current player is
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim
{
    class PlayerModel
    {
        string playerName;
        public PlayerModel()
        {

        }

        public void PlayerName(string name)
        {
            playerName = name;
        }

        public void setCurrentPlayer(string theCurrentPlayer)
        {
            playerName = theCurrentPlayer;
        }

        public string getCurrentPlayer()
        {
            return playerName;
        }

    }

    
}
