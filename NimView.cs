/*Jerald Coyne
 * Last Edited 9/24/2018
 * Class Number: 1
 * This is the control class of the app
 *    it handles all of the validation and
 *    interaction with the form
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace GameOfNim
{
    public partial class NimView : Form
    {
        public NimView()
        {
            InitializeComponent();
        }
        //Declarations for the control class 
        PlayerModel currentPlayer = new PlayerModel();
        private BoardModel boardRep = new BoardModel(maxRows);

        private const int maxRows = 4;
        private const int maxCols = 7;

        int marblesSelectedCount = 0;  // Total number of marbles selected in current turn
        int rowID;                     // row number of row just slected by current player
        private Button[,] btnMarbleButton = new Button[maxRows, maxCols];
        private Button[] btnNewRow = new Button[maxRows];

        //--------------------------------------------------------------EVENT HANDLERS-------------------------------------------------------------------------------------------
        //Load Form
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Ok button to accept player 1s input
        public void btnFirstPlayerOK_Click(object sender, EventArgs e)
        {
            try { 
            firstPlayerValidate();
            currentPlayer.PlayerName(txtFirstPlayer.Text);
            currentPlayer.setCurrentPlayer(txtFirstPlayer.Text);
            }
            catch
            {
                MessageBox.Show("Please Enter a valid name");
            }
        }

        //Ok button to accept player 2s input
        public void btnSecondPlayerOK_Click(object sender, EventArgs e)
        {
            try
            {
                secondPlayerValidate();
            }
            catch
            {
                MessageBox.Show("Please Enter a valid name");
            }
        }

        //Button to start game, and create the board
        public void btnStart_Click(object sender, EventArgs e)
        {
            txtTurn.Text = txtFirstPlayer.Text;
            startButtonForm();
            createBoard();
            btnStart.Enabled = false;
        }

        // The event handler for the four row buttons. It uses sender argument to determine which row button was selected
        private void btnNewRow_Click(object sender, EventArgs e)
        {
            selectRow(sender);
        } 

        //The event handler for the 28 Nim board buttons and is the handler for all 16 clickable marble buttons
        private void BtnMarbleButton(object sender, EventArgs e)
        {
            //converts sender from type object to type button
            Button button = sender as Button;
            if (button != null)
            {
                marblesSelectedCount++;
                
                ((Button)sender).Visible = false;
            }
        }

        private void btnTurnComplete_Click(object sender, EventArgs e)
        {
            //reenables row buttons after turns over
             btnNewRow[0].Enabled = true;
             btnNewRow[1].Enabled = true;
             btnNewRow[2].Enabled = true;
             btnNewRow[3].Enabled = true;
        
            //decides who wins
            if (marblesSelectedCount == 15)
            {
                MessageBox.Show("Player " + txtTurn.Text + " Has Won The Game!");
                btnNewRow[0].Enabled = false;
                btnNewRow[1].Enabled = false;
                btnNewRow[2].Enabled = false;
                btnNewRow[3].Enabled = false;
                btnStart.Enabled = true;
                txtTurn.Clear();

            }
            if(marblesSelectedCount > 15)
            {
                MessageBox.Show("Player " + txtTurn.Text + " Has Tragically Lost The Game!");
                btnNewRow[0].Enabled = false;
                btnNewRow[1].Enabled = false;
                btnNewRow[2].Enabled = false;
                btnNewRow[3].Enabled = false;
                btnStart.Enabled = true;
                txtTurn.Clear();
            }

            //if statement that determines whos turn it is after the button turn click
            if (currentPlayer.getCurrentPlayer() == txtFirstPlayer.Text)
            {
                currentPlayer.setCurrentPlayer(txtSecondPlayer.Text);
                txtTurn.Text = currentPlayer.getCurrentPlayer();
            }
            else 
            {
                currentPlayer.setCurrentPlayer(txtFirstPlayer.Text);
                txtTurn.Text = currentPlayer.getCurrentPlayer();
            }

            //updates board model counts
            boardRep.recordTurn(rowID, marblesSelectedCount);
            
           //disables marble buttons after turn and prevents jumping into other row
            for (int i = 0; i < btnMarbleButton.GetLength(0); i++)
            {
                for (int j = 0; j < btnMarbleButton.GetLength(1); j++)
                {
                    btnMarbleButton[i, j].Enabled = false;
                }
            }

            //check to see if row is empty
           

            /*WAS WORKING IN TAs OFFICE, but now does not. Origianlly it disabled 
             * empty row buttons. However, if you dont pick the marbles in a spceific
             * way then it will delete random rows even if they have marbles in them.
             * Ive tried multiple ways to do this and this was the way that was working
             * when I left the TAs office. Other than this, the game works completely fine.
             * If a player chooses a row that has no marbles they simply loose their turn.
             * That was not how I originally planed for the game to work however if we
             * are letting the players who are dumb enough to pick an empty pile will
             * be punished with their stupidity along with the poor soul who picks all
             * the marbles, ultimately losing the game for themselves. 
             * 
                for (int i = 0; i <= 3; i++)
                {
                    if (boardRep.getRowCount(i) <= 0)
                    {
                        btnNewRow[i].Enabled = false;
                    }

             }*/

        }

        //reset the game
        public void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        //quit Game
        public void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------------------------------------------------------METHODS----------------------------------------------------------------------------------------------
        //Beginning of methods to be called by the view class
        public void firstPlayerValidate()
        {
            //if else statement that parses user input using a regular expression
            if (txtFirstPlayer.Text == "" || Regex.IsMatch(txtFirstPlayer.Text, @"^\d+$"))
            {
                MessageBox.Show("Please Enter a Name, Cannot Be left Blank or Just Numbers");
                txtFirstPlayer.Text = "";
            }
            else
            {
                this.txtSecondPlayer.Visible = true;
                this.lblSecondPlayer.Visible = true;
                this.btnSecondPlayerOK.Visible = true;
            }
        }

        public void secondPlayerValidate()
        {
            //if else statement that parses user input using a regular expression
            if (txtSecondPlayer.Text == "" || Regex.IsMatch(txtSecondPlayer.Text, @"^\d+$"))
            {
                MessageBox.Show("Please Enter a Name, Cannot Be left Blank or Just Numbers");
                txtSecondPlayer.Text = "";
            }
            else
            {
                this.lblStartGame.Visible = true;
                this.btnStart.Visible = true;
            }
        }

        public void startButtonForm()
        {
            this.lblTurn.Visible = true;
            this.txtTurn.Visible = true;
            this.txtTurn.Text = txtFirstPlayer.Text;
            this.btnTurnComplete.Visible = true;
            this.btnQuit.Visible = true;
            this.btnPlayAgain.Visible = true;
            this.btnStart.Enabled = false;
           
        }

        // The code that dynamically creates the row buttons and the Nim Board buttons.
        private void createBoard()
        {
            // Dynamically Creates a 4x7 board with associated row buttons  
            pnlBoard.Visible = true;

            Size size = new Size(50, 50);
            Point loc = new Point(0, 0);
            int padding = 10;
            int topMargin = 10;

            // The board is treated like a maxRows x MaxCols array
            for (int row = 0; row < maxRows; row++)
            {
                // For each new row, insert at left the Row i Button
                loc.Y = (topMargin + 10) + row * (size.Height + padding);
                int rowBtnExtraLeftPadding = 15;
                btnNewRow[row] = new System.Windows.Forms.Button();
                btnNewRow[row].Location = new Point(rowBtnExtraLeftPadding, loc.Y);
                btnNewRow[row].Size = new Size(75, 23);
                btnNewRow[row].Text = "Row " + (row + 1) + " -->";
                btnNewRow[row].Enabled = true;
                btnNewRow[row].Visible = true;
                btnNewRow[row].Name = "rowBtn" + row;
                btnNewRow[row].Click += new EventHandler(btnNewRow_Click);
                
                // Add 4 row buttons to the form
                pnlBoard.Controls.Add(btnNewRow[row]);

                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 100;
                for (int col = 0; col < maxCols; col++)
                {
                    btnMarbleButton[row, col] = new System.Windows.Forms.Button();
                    btnMarbleButton[row, col].Location = new Point(extraLeftPadding + col *
                                                   (size.Width + padding), loc.Y);
                    btnMarbleButton[row, col].Size = size;
                    btnMarbleButton[row, col].Text = "";
                    btnMarbleButton[row, col].Enabled = false;
                    btnMarbleButton[row, col].Visible = true;
                    btnMarbleButton[row, col].Name = "btnMarbleButton" + row + col;

                    // Associates the same event handler with each of the buttons generated
                    btnMarbleButton[row, col].Click += new EventHandler(BtnMarbleButton);

                    // Add button to the form
                    pnlBoard.Controls.Add(btnMarbleButton[row, col]);
                } 
            } 

            // Set up the board with the 16 marbles
            btnMarbleButton[0, maxCols / 2].Image = collectionOfPics.Images[0];
            for (int i = maxCols / 2 - 1; i <= maxCols / 2 + 1; i++) btnMarbleButton[1, i].Image =
                    collectionOfPics.Images[0];
            for (int i = maxCols / 2 - 2; i <= maxCols / 2 + 2; i++) btnMarbleButton[2, i].Image =
                    collectionOfPics.Images[0];
            for (int i = maxCols / 2 - 3; i <= maxCols / 2 + 3; i++) btnMarbleButton[3, i].Image =
                    collectionOfPics.Images[0];

        } 

        //selects row
        private void selectRow(object sender)
        {
            try
            {
                //converts sender from type object to type button
                Button button = sender as Button;
                if (button != null)
                {
                    rowID = convertCharToInt(((Button)sender).Name[6]);
                    for (int i = 0; i < maxRows; i++) btnNewRow[i].Enabled = false;
                    if (rowID == 0) btnMarbleButton[rowID, maxCols / 2].Enabled = true;
                    if (rowID == 1) for (int i = maxCols / 2 - 1; i <= maxCols / 2 + 1; i++)
                            btnMarbleButton[rowID, i].Enabled = true;
                    if (rowID == 2) for (int i = maxCols / 2 - 2; i <= maxCols / 2 + 2; i++)
                            btnMarbleButton[rowID, i].Enabled = true;
                    if (rowID == 3) for (int i = maxCols / 2 - 3; i <= maxCols / 2 + 3; i++)
                            btnMarbleButton[rowID, i].Enabled = true;
                    btnQuit.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Marble Row is disabled");
                btnNewRow[0].Enabled = false;
                btnNewRow[1].Enabled = false;
                btnNewRow[2].Enabled = false;
                btnNewRow[3].Enabled = false;
            }

        }
        
        // Convert a charcter to its equivalent integer
        int convertCharToInt(Char c)
        {
            return ((int)(c) - (int)('0'));
        }  
        //--------------------------------------------------------------END OF METHODS------------------------------------------------------------------------
    }
}
