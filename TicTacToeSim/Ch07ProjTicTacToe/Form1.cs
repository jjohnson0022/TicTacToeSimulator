using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch07ProjTicTacToe
{
    public partial class Form1 : Form
    {

        const int PLAYERAMOUNT = 2;
        const int ROWS = 3;
        const int COLS = 3;
        const int TILECOUNT = 9;
        const int MINWIN = 5;
        const int EMPTYTILE = -1;

        Random rand = new Random();

        int[,] ticTacToe = new int [ROWS,COLS];
        String[,] labelsArray = new String[ROWS, COLS];
        int[] indexArray = new int[3] { 0, 1, 2 };
        int[,] testArray = new int[ROWS, COLS];

        Boolean gameOver;        
        
        int i;
        int checkWin;        
        
        String outcomeMessage;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clears the board and decides who goes first
        private void newGameButton_Click(object sender, EventArgs e)
        {
            newGameButton.Enabled = false;
                ClearBoard();
                int playerOne = rand.Next(PLAYERAMOUNT);
                SimulateGame(playerOne);           
        }

        //Called when a new game starts.
        private void ClearBoard()
        {          
            topLeftLabel.Text = "";
            topMidLabel.Text = "";
            topRightLabel.Text = "";
            midLeftLabel.Text = "";
            midMidLabel.Text = "";
            midRightLabel.Text = "";
            bottomLeftLabel.Text = "";
            bottomMidLabel.Text = "";
            bottomRightLabel.Text = "";

            labelsArray[0, 0] = "";
            labelsArray[0, 1] = "";
            labelsArray[0, 2] = "";
            labelsArray[1, 0] = "";
            labelsArray[1, 1] = "";
            labelsArray[1, 2] = "";
            labelsArray[2, 0] = "";
            labelsArray[2, 1] = "";
            labelsArray[2, 2] = "";

            outcomeLabel.Text = "";

            for(int row = 0; row < ROWS; row++)
            {
                for(int col = 0; col < COLS; col++)
                {
                    ticTacToe[row, col] = EMPTYTILE;
                }
            }                        

            gameOver = false;
            
            i = 0;
            checkWin = 0;

            outcomeMessage = "";
        }

        //This is where the game is simulated
        public void SimulateGame(int currentPlayer)
        {

            int currentHorizontalTile;
            int currentVerticalTile;
            int horizontalIndex;
            int verticalIndex;
           

            if (!gameOver)
            {


                horizontalIndex = rand.Next(indexArray.Length);
                verticalIndex = rand.Next(indexArray.Length);

                currentHorizontalTile = indexArray[horizontalIndex];
                currentVerticalTile = indexArray[verticalIndex];

                if (i > 0)
                {
                    while ((labelsArray[currentHorizontalTile,currentVerticalTile] == "X" || labelsArray[currentHorizontalTile, currentVerticalTile] == "O"))
                    {
                        horizontalIndex = rand.Next(indexArray.Length);
                        verticalIndex = rand.Next(indexArray.Length);

                        currentHorizontalTile = indexArray[horizontalIndex];
                        currentVerticalTile = indexArray[verticalIndex];
                    }
                        
                    
                }
                i++;

                    ticTacToe[currentHorizontalTile, currentVerticalTile] = currentPlayer;

                    if (currentPlayer == 0)
                    {
                        labelsArray[currentHorizontalTile, currentVerticalTile] = "O";
                    }
                    else
                    {
                        labelsArray[currentHorizontalTile, currentVerticalTile] = "X";
                    }

                    checkWin++;

                    if (checkWin >= MINWIN)
                    {
                        if (CheckWin())
                        {
                            gameOver = true;
                        }
                        else if (checkWin == TILECOUNT)
                        {
                            gameOver = true;
                            outcomeMessage = "DRAW";
                        }
                    }

                    if (currentPlayer == 0)
                    {
                        currentPlayer = 1;
                    }
                    else
                    {
                        currentPlayer = 0;
                    }
                    SimulateGame(currentPlayer);

                }
                else
                {
                    OutCome();
                    newGameButton.Enabled = true;
                }            
        }

        //Checks for 3 in a row and determines who won
        private Boolean CheckWin()
        {
            for (int n = 0; n < 2; n++)
            {
                if ((ticTacToe[0,0] == n && ticTacToe[0,1] == n && ticTacToe[0,2] == n) || (ticTacToe[1,0] == n && ticTacToe[1,1] == n && ticTacToe[1,2] == n) || (ticTacToe[2, 0] == n && ticTacToe[2, 1] == n && ticTacToe[2, 2] == n) ||
                    (ticTacToe[0, 0] == n && ticTacToe[1, 0] == n && ticTacToe[2, 0] == n) || (ticTacToe[0, 1] == n && ticTacToe[1, 1] == n && ticTacToe[2, 1] == n) || (ticTacToe[0, 2] == n && ticTacToe[1, 2] == n && ticTacToe[2, 2] == n)
                    || (ticTacToe[0, 0] == n && ticTacToe[1, 1] == n && ticTacToe[2, 2] == n) || (ticTacToe[2, 0] == n && ticTacToe[1, 1] == n && ticTacToe[0, 2] == n))
                {
                    if(n == 0)
                    {
                        outcomeMessage = "Os WON";                        
                    }
                    else if(n == 1)
                    {
                        outcomeMessage = "Xs WON";                        
                    }
                    return true;
                }               
            }
            return false;
        }

        //Draws the board and informs the players if someone won
        private void OutCome()
        {
            topLeftLabel.Text = labelsArray[0, 0];
            topMidLabel.Text = labelsArray[0, 1];
            topRightLabel.Text = labelsArray[0, 2];
            midLeftLabel.Text = labelsArray[1, 0];
            midMidLabel.Text = labelsArray[1, 1];
            midRightLabel.Text = labelsArray[1, 2];
            bottomLeftLabel.Text = labelsArray[2, 0];
            bottomMidLabel.Text = labelsArray[2, 1];
            bottomRightLabel.Text = labelsArray[2, 2];
            outcomeLabel.Text = outcomeMessage;
        }

    }
}
