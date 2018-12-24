/*Jerald Coyne
 * Last Edited: 9/21/2018
 * Class Number: 2 
 * This class holds the IDE generated code for the form
 */
namespace GameOfNim
{
    partial class NimView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NimView));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.lblFirstPlayer = new System.Windows.Forms.Label();
            this.txtFirstPlayer = new System.Windows.Forms.TextBox();
            this.btnFirstPlayerOK = new System.Windows.Forms.Button();
            this.lblSecondPlayer = new System.Windows.Forms.Label();
            this.txtSecondPlayer = new System.Windows.Forms.TextBox();
            this.btnSecondPlayerOK = new System.Windows.Forms.Button();
            this.lblStartGame = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.txtTurn = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.btnTurnComplete = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.collectionOfPics = new System.Windows.Forms.ImageList(this.components);
            this.pnlBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(61, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(436, 33);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome To The Game of Nim";
            // 
            // lblDirections
            // 
            this.lblDirections.Location = new System.Drawing.Point(72, 53);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(400, 50);
            this.lblDirections.TabIndex = 1;
            this.lblDirections.Text = resources.GetString("lblDirections.Text");
            // 
            // lblFirstPlayer
            // 
            this.lblFirstPlayer.AutoSize = true;
            this.lblFirstPlayer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFirstPlayer.Location = new System.Drawing.Point(61, 123);
            this.lblFirstPlayer.Name = "lblFirstPlayer";
            this.lblFirstPlayer.Size = new System.Drawing.Size(141, 16);
            this.lblFirstPlayer.TabIndex = 2;
            this.lblFirstPlayer.Text = "First Player Name -->";
            // 
            // txtFirstPlayer
            // 
            this.txtFirstPlayer.Location = new System.Drawing.Point(247, 123);
            this.txtFirstPlayer.Name = "txtFirstPlayer";
            this.txtFirstPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtFirstPlayer.TabIndex = 1;
            // 
            // btnFirstPlayerOK
            // 
            this.btnFirstPlayerOK.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFirstPlayerOK.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPlayerOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFirstPlayerOK.Location = new System.Drawing.Point(378, 120);
            this.btnFirstPlayerOK.Name = "btnFirstPlayerOK";
            this.btnFirstPlayerOK.Size = new System.Drawing.Size(49, 23);
            this.btnFirstPlayerOK.TabIndex = 2;
            this.btnFirstPlayerOK.Text = "OK";
            this.btnFirstPlayerOK.UseVisualStyleBackColor = false;
            this.btnFirstPlayerOK.Click += new System.EventHandler(this.btnFirstPlayerOK_Click);
            // 
            // lblSecondPlayer
            // 
            this.lblSecondPlayer.AutoSize = true;
            this.lblSecondPlayer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSecondPlayer.Location = new System.Drawing.Point(58, 156);
            this.lblSecondPlayer.Name = "lblSecondPlayer";
            this.lblSecondPlayer.Size = new System.Drawing.Size(162, 16);
            this.lblSecondPlayer.TabIndex = 5;
            this.lblSecondPlayer.Text = "Second Player Name -->";
            this.lblSecondPlayer.Visible = false;
            // 
            // txtSecondPlayer
            // 
            this.txtSecondPlayer.Location = new System.Drawing.Point(247, 152);
            this.txtSecondPlayer.Name = "txtSecondPlayer";
            this.txtSecondPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtSecondPlayer.TabIndex = 3;
            this.txtSecondPlayer.Visible = false;
            // 
            // btnSecondPlayerOK
            // 
            this.btnSecondPlayerOK.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSecondPlayerOK.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondPlayerOK.Location = new System.Drawing.Point(378, 152);
            this.btnSecondPlayerOK.Name = "btnSecondPlayerOK";
            this.btnSecondPlayerOK.Size = new System.Drawing.Size(49, 23);
            this.btnSecondPlayerOK.TabIndex = 4;
            this.btnSecondPlayerOK.Text = "OK";
            this.btnSecondPlayerOK.UseVisualStyleBackColor = false;
            this.btnSecondPlayerOK.Visible = false;
            this.btnSecondPlayerOK.Click += new System.EventHandler(this.btnSecondPlayerOK_Click);
            // 
            // lblStartGame
            // 
            this.lblStartGame.AutoSize = true;
            this.lblStartGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartGame.Location = new System.Drawing.Point(34, 188);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(258, 15);
            this.lblStartGame.TabIndex = 7;
            this.lblStartGame.Text = "When ready to play, click this button -->";
            this.lblStartGame.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(378, 188);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(34, 236);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(101, 16);
            this.lblTurn.TabIndex = 8;
            this.lblTurn.Text = "It\'s Your Turn...";
            this.lblTurn.Visible = false;
            // 
            // txtTurn
            // 
            this.txtTurn.Location = new System.Drawing.Point(141, 232);
            this.txtTurn.Name = "txtTurn";
            this.txtTurn.ReadOnly = true;
            this.txtTurn.Size = new System.Drawing.Size(100, 20);
            this.txtTurn.TabIndex = 9;
            this.txtTurn.Visible = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(352, 579);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Visible = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.Green;
            this.btnPlayAgain.Location = new System.Drawing.Point(116, 579);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(75, 23);
            this.btnPlayAgain.TabIndex = 11;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Controls.Add(this.btnTurnComplete);
            this.pnlBoard.Location = new System.Drawing.Point(12, 275);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(539, 298);
            this.pnlBoard.TabIndex = 12;
            this.pnlBoard.Visible = false;
            // 
            // btnTurnComplete
            // 
            this.btnTurnComplete.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnComplete.ForeColor = System.Drawing.Color.Green;
            this.btnTurnComplete.Location = new System.Drawing.Point(470, 251);
            this.btnTurnComplete.Margin = new System.Windows.Forms.Padding(2);
            this.btnTurnComplete.Name = "btnTurnComplete";
            this.btnTurnComplete.Size = new System.Drawing.Size(69, 45);
            this.btnTurnComplete.TabIndex = 0;
            this.btnTurnComplete.Text = "Turn Complete";
            this.btnTurnComplete.UseVisualStyleBackColor = true;
            this.btnTurnComplete.Visible = false;
            this.btnTurnComplete.Click += new System.EventHandler(this.btnTurnComplete_Click);
            // 
            // collectionOfPics
            // 
            this.collectionOfPics.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("collectionOfPics.ImageStream")));
            this.collectionOfPics.TransparentColor = System.Drawing.Color.Transparent;
            this.collectionOfPics.Images.SetKeyName(0, "marble.jpg");
            // 
            // NimView
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(563, 614);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtTurn);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStartGame);
            this.Controls.Add(this.btnSecondPlayerOK);
            this.Controls.Add(this.txtSecondPlayer);
            this.Controls.Add(this.lblSecondPlayer);
            this.Controls.Add(this.btnFirstPlayerOK);
            this.Controls.Add(this.txtFirstPlayer);
            this.Controls.Add(this.lblFirstPlayer);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NimView";
            this.Text = "aw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Label lblFirstPlayer;
        private System.Windows.Forms.TextBox txtFirstPlayer;
        private System.Windows.Forms.Button btnFirstPlayerOK;
        private System.Windows.Forms.Label lblSecondPlayer;
        private System.Windows.Forms.TextBox txtSecondPlayer;
        private System.Windows.Forms.Button btnSecondPlayerOK;
        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.TextBox txtTurn;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btnTurnComplete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList collectionOfPics;
    }
}

