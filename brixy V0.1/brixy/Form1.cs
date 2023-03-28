using System.Diagnostics;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace brixy
{
    public partial class Form1 : Form
    {
        
        public GameSquare[,] allSquareArray = new GameSquare[3, 3];
        public GameSquare selectedSquare;
        public Player player1 = new Player();
        public Player player2 = new Player();
        public Player playerTurn;
        bool openMode = false;
        bool gameOver = false;
        bool skip = false;
        public Form1()
        {
            KeyPreview = true;
            
            playerTurn = player1;

            InitializeComponent();
            CreateBoard();
            DrawPieces();
            PossibleMoves(null);
            

        }

        void CreateBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        allSquareArray[i, j] = new GameSquare(i, j, new Button(), player2);
                    }
                    else if (j == 2)
                    {
                        allSquareArray[i, j] = new GameSquare(i, j, new Button(), player1);
                    }
                    else
                    {
                        allSquareArray[i, j] = new GameSquare(i, j, new Button());
                    }



                    allSquareArray[i, j].button.Click += ButtClick;
                    allSquareArray[i, j].button.Tag = allSquareArray[i, j];
                    Controls.Add(allSquareArray[i, j].button);
                    allSquareArray[i, j].button.Size = new Size(100, 100);
                    allSquareArray[i, j].button.Location = new Point(i * 100, j * 100);

                }
            }
        }


        public void buttonMovement_Click(object sender, EventArgs e)
        {
            GameSquare square = selectedSquare;
            int newX = square.xPos;
            int newY = square.yPos;
            if(sender == buttonAdd)
            {
                selectedSquare.AddPiece(playerTurn);
            }
            if (sender == buttonUp)
            {
                newY -= 1;
            }
            if (sender == buttonLeft)
            {
                newX -= 1;
            }
            if (sender == buttonRight)
            {
                newX += 1;
            }
            if (sender == buttonDown)
            {
                newY += 1;
            }
            if (sender == buttonSkipUp)
            {
                newY -= 2;
            }
            if(sender == buttonSkipLeft)
            {
                newX -= 2;
            }
            if(sender == buttonSkipRight)
            {
                newX += 2;
            }
            if(sender == buttonSkipDown)
            {
                newY += 2;
            }

            playerTurn.pieces[square.xPos, square.yPos] -= 1;
            playerTurn.pieces[newX,newY] += 1;

            EndTurn();
        }

        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space)
            {
                if (buttonAdd.Enabled == true)
                {
                    buttonMovement_Click(buttonAdd, e);
                }
            }

            if (e.KeyCode == Keys.W)
            {
                if (buttonUp.Enabled == true)
                {
                    buttonMovement_Click(buttonUp, e);

                }
            }
            if (e.KeyCode == Keys.A)
            {
                if (buttonLeft.Enabled == true)
                {
                    buttonMovement_Click(buttonLeft, e);

                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (buttonRight.Enabled == true)
                {
                    buttonMovement_Click(buttonRight, e);
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (buttonDown.Enabled == true)
                {
                    buttonMovement_Click(buttonDown, e);
                }
            }
        }

        public void ButtClick(object sender, EventArgs e)
        {

            Button myButton = sender as Button;
            selectedSquare = (GameSquare)myButton.Tag;
            if(gameOver)
            {
                return;
            }
            PossibleMoves(selectedSquare);

        }

        void PossibleMoves(GameSquare? square)
        {
            
            buttonUp.Enabled = false;
            buttonLeft.Enabled = false;
            buttonRight.Enabled = false;
            buttonDown.Enabled = false;
            buttonAdd.Enabled = false;
            buttonSkipUp.Visible = false;
            buttonSkipLeft.Visible = false;
            buttonSkipRight.Visible = false;
            buttonSkipDown.Visible = false;
            if (square == null)
            {
                return;
            }
            square.button.Focus();
            if (playerTurn.pieces[square.xPos, square.yPos] > 0 && openMode == false)
            {
                if ((square.xPos + 1) <= 2)
                {
                    buttonRight.Enabled = true;
                }
                if ((square.xPos - 1) >= 0)
                {
                    buttonLeft.Enabled = true;
                }
                if ((square.yPos + 1) <= 2)
                {
                    buttonDown.Enabled = true;
                }
                if ((square.yPos - 1) >= 0)
                {
                    buttonUp.Enabled = true;
                }
                if((square.xPos+2) <=2 && (player1.pieces[square.xPos + 1, square.yPos] + player2.pieces[square.xPos+1,square.yPos]) == 0)
                {
                    buttonSkipRight.Visible = true;
                }
                if ((square.xPos - 2) >= 0 && (player1.pieces[square.xPos - 1, square.yPos] + player2.pieces[square.xPos - 1, square.yPos]) == 0)
                {
                    buttonSkipLeft.Visible = true;
                }
                if ((square.yPos + 2) <= 2 && (player1.pieces[square.xPos, square.yPos +1] + player2.pieces[square.xPos, square.yPos+1]) == 0)
                {
                    buttonSkipDown.Visible = true;
                }
                if ((square.yPos - 2) >= 0 && (player1.pieces[square.xPos, square.yPos - 1] + player2.pieces[square.xPos, square.yPos - 1]) == 0)
                {
                    buttonSkipUp.Visible = true;
                }

            }

            if (square.isHome && playerTurn == square.playerHome && playerTurn.totalPieces > 0)
            {
                buttonAdd.Enabled = true;
            }




        }


        public void EndTurn()
        {
            PossibleMoves(null);
            if (CheckWins() == true)
            {
                gameOver = true;
                DrawPieces();
                return;
            }

            if (playerTurn.totalPieces > 5)
            {
                openMode = true;
            }
            else
            {
                openMode = false;
            }

            if (openMode == false)
            {
                if (playerTurn == player1)
                {
                    playerTurn = player2;
                }
                else
                {
                    playerTurn = player1;
                }
            }

            DrawPieces();
            return;
        }

        #region win logic
        public bool CheckWins()
        {
            if(TotalPieces(0,0) == TotalPieces(0,1) && TotalPieces(0,1) == TotalPieces(0,2))
            {
                if(TotalPieces(0,0) >=2)
                {
                    allSquareArray[0, 0].button.BackColor = Color.BlueViolet;
                    allSquareArray[0, 1].button.BackColor = Color.BlueViolet;
                    allSquareArray[0, 2].button.BackColor = Color.BlueViolet;
                    return true;
                }
                
            }
            if (TotalPieces(1, 0) == TotalPieces(1, 1) && TotalPieces(1, 1) == TotalPieces(1, 2))
            {
                if(TotalPieces(1,0) >= 2)
                {
                    allSquareArray[1, 0].button.BackColor = Color.BlueViolet;
                    allSquareArray[1, 1].button.BackColor = Color.BlueViolet;
                    allSquareArray[1, 2].button.BackColor = Color.BlueViolet;
                    return true;
                }
                
            }
            if (TotalPieces(2, 0) == TotalPieces(2, 1) && TotalPieces(2, 1) == TotalPieces(2, 2))
            {
                if(TotalPieces(2,0) >= 2)
                {
                    allSquareArray[2, 0].button.BackColor = Color.BlueViolet;
                    allSquareArray[2, 1].button.BackColor = Color.BlueViolet;
                    allSquareArray[2, 2].button.BackColor = Color.BlueViolet;
                    return true;
                }
               
            }
            if (TotalPieces(0, 1) == TotalPieces(1, 1) && TotalPieces(1, 1) == TotalPieces(2, 1))
            {
                if(TotalPieces(0,1) >= 2)
                {
                    allSquareArray[0, 1].button.BackColor = Color.BlueViolet;
                    allSquareArray[1, 1].button.BackColor = Color.BlueViolet;
                    allSquareArray[2, 2].button.BackColor = Color.BlueViolet;
                    return true;
                }
                
            }
            if (TotalPieces(0, 0) == TotalPieces(1, 1) && TotalPieces(1, 1) == TotalPieces(2, 2))
            {
                if(TotalPieces(0,0) >= 2)
                {
                    allSquareArray[0, 0].button.BackColor = Color.BlueViolet;
                    allSquareArray[1, 1].button.BackColor = Color.BlueViolet;
                    allSquareArray[2, 2].button.BackColor = Color.BlueViolet;
                    return true;
                }
                
            }
            if (TotalPieces(2, 0) == TotalPieces(1, 1) && TotalPieces(1, 1) == TotalPieces(0, 2))
            {
                if(TotalPieces(2,0) >= 2)
                {
                    allSquareArray[2, 0].button.BackColor = Color.BlueViolet;
                    allSquareArray[1, 1].button.BackColor = Color.BlueViolet;
                    allSquareArray[0, 2].button.BackColor = Color.BlueViolet;
                    return true;
                }
                
            }
            return false;
        }
        public int? TotalPieces(int i,int j)
        {
            return (player1.pieces[i, j] + player2.pieces[i, j]);

            
        }
        #endregion




        public void DrawPieces()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    allSquareArray[i, j].button.Text = "";
                    for (int k = 0; k < player1.pieces[i,j]; k++)
                    {
                        if(playerTurn == player1)
                        {
                            allSquareArray[i, j].button.Text += "X";
                        } else
                        {
                            allSquareArray[i, j].button.Text += "x";
                        }
                        
                    }
                    for (int k = 0; k < player2.pieces[i, j]; k++)
                    {
                        if(playerTurn == player2)
                        {
                            allSquareArray[i, j].button.Text += "O";
                        } else
                        {
                            allSquareArray[i, j].button.Text += "o";
                        }
                        
                    }
                    
                }
            }
            if (playerTurn == player1)
            {
                label1.Text = "Turn: Player X";

            }
            else
            {
                label1.Text = "Turn: Player O";
            }
            if (openMode)
            {
                label1.Text += " (opening)";
            }
            if (gameOver)
            {
                
                label1.Text += " WINNER";
            }
        }

        public class GameSquare
        {
            public Button button;
            public int xPos;
            public int yPos;
            public Player playerHome;
            public bool isHome = false;

            public GameSquare(int xPos, int yPos, Button button)
            {
                this.xPos = xPos;
                this.yPos = yPos;
                this.button = button;
            }

            public GameSquare(int xPos, int yPos, Button button, Player player)
            {
                this.xPos = xPos;
                this.yPos = yPos;
                this.button = button;
                playerHome = player;
                isHome = true;
            }

            public void AddPiece(Player player)
            {

                player.totalPieces -= 1;
                player.pieces[xPos, yPos] += 1;

            }


        }

        public class Player
        {
            public int totalPieces = 10;
            public int[,] pieces = new int[3,3];

        }
    }
}