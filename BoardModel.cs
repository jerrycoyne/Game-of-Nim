    /*Jerald Coyne
 *Last Edited: 9/24/2018
 * Class number 3
 * The purpose of this class is to 
 *    hold all of the information
 *    about the board and what is on
 *    it. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim
{
    class BoardModel
    {
        const int marblesCountMax = 16;
        int currentMarbleCount;
        int rowMax;
        int[] rowMarbleCounts;// counts of marbles in each row a

        public BoardModel()
        {
           
        }
        
        //constructor that takes a parameter rowCount
        public BoardModel(int rowCount)
        {
            rowMax = rowCount;
            currentMarbleCount = marblesCountMax;
            rowMarbleCounts = new int[rowMax];
            for (int i = 0; i < rowMax; i++)
            {
                rowMarbleCounts[i] = 2 * i + 1;
            }
        }

        //rowID represents id of the row selected by the player, currentSelectionCount represents number of marbles just selected in that row
        public bool recordTurn (int rowID, int currentSelectionCount)
        {
            rowMarbleCounts[rowID] = rowMarbleCounts[rowID] - currentSelectionCount;
            currentMarbleCount = currentMarbleCount - currentSelectionCount;

            if (rowMarbleCounts[rowID] == 0)
                return true;
            else
            {
                return false;
            }
        }
        
        //gets the count of marbles left in the row
        public int getRowCount(int i)
        {
            return rowMarbleCounts[i];
        }
      
     }
}
