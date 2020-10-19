using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace T
{
    public partial class Form4 : Form
    {
        /**
            TicTacToe Data Position
             0 |1 |2 |3 |4
             5 |6 |7 |8 |9
             10|11|12|13|14
             15|16|17|18|19
             20|21|22|23|24
        */
        int[] iData = new int[25];

        //-1 = X, 1 = O, 0 = Stop
        int iTurn = -1;

        //0 = Easy, 1 = Medium, 2 = Hard, 3 = Manual
        int iType = 1;

        bool bEnableBot = false;

        //Store last move position
        int iLastMove = -1;

        int iXScores = 0;
        int iOScores = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "Easy";
            iType = 0;

            RestartGame();
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "Medium";
            iType = 1;

            RestartGame();
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "Hard";
            iType = 2;

            RestartGame();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "Manual";
            iType = 3;

            RestartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[0] == 0)
            {
                iLastMove = 0;
                iData[0] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[1] == 0)
            {
                iLastMove = 1;
                iData[1] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[2] == 0)
            {
                iLastMove = 2;
                iData[2] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[3] == 0)
            {
                iLastMove = 3;
                iData[3] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[4] == 0)
            {
                iLastMove = 4;
                iData[4] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[5] == 0)
            {
                iLastMove = 5;
                iData[5] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[6] == 0)
            {
                iLastMove = 6;
                iData[6] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[7] == 0)
            {
                iLastMove = 7;
                iData[7] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[8] == 0)
            {
                iLastMove = 8;
                iData[8] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[9] == 0)
            {
                iLastMove = 9;
                iData[9] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[10] == 0)
            {
                iLastMove = 10;
                iData[10] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[11] == 0)
            {
                iLastMove = 11;
                iData[11] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[12] == 0)
            {
                iLastMove = 12;
                iData[12] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[13] == 0)
            {
                iLastMove = 13;
                iData[13] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[14] == 0)
            {
                iLastMove = 14;
                iData[14] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[15] == 0)
            {
                iLastMove = 15;
                iData[15] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[16] == 0)
            {
                iLastMove = 16;
                iData[16] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[17] == 0)
            {
                iLastMove = 17;
                iData[17] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[18] == 0)
            {
                iLastMove = 18;
                iData[18] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[19] == 0)
            {
                iLastMove = 19;
                iData[19] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[20] == 0)
            {
                iLastMove = 20;
                iData[20] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[21] == 0)
            {
                iLastMove = 21;
                iData[21] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[22] == 0)
            {
                iLastMove = 22;
                iData[22] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[23] == 0)
            {
                iLastMove = 23;
                iData[23] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[24] == 0)
            {
                iLastMove = 24;
                iData[24] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        // Restart Button
        private void button26_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
        void RestartGame()
        {
            //Reset Data
            for (int i = 0; i <= 24; i++)
            {
                iData[i] = 0;
            }

            iLastMove = -1;
            bEnableBot = false;
            //X first
            iTurn = 1;
            SetNextTurn();

            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
            button7.BackgroundImage = null;
            button8.BackgroundImage = null;
            button9.BackgroundImage = null;
            button10.BackgroundImage = null;
            button11.BackgroundImage = null;
            button12.BackgroundImage = null;
            button13.BackgroundImage = null;
            button14.BackgroundImage = null;
            button15.BackgroundImage = null;
            button16.BackgroundImage = null;
            button17.BackgroundImage = null;
            button18.BackgroundImage = null;
            button19.BackgroundImage = null;
            button20.BackgroundImage = null;
            button21.BackgroundImage = null;
            button22.BackgroundImage = null;
            button23.BackgroundImage = null;
            button24.BackgroundImage = null;
            button25.BackgroundImage = null;

        }
        void SetNextTurn()
        {
            int iGameStatus = CheckGameStatus();
            if (iGameStatus == 2)
            {
                if (iTurn == -1)
                {
                    iTurn = 1;
                    label1.Text = "                 𐩒 Turn";
                }
                else
                {
                    if (iType != 3 && iLastMove == -1)
                    {
                        iTurn = -1;
                        label1.Text = "Start game or select player";
                    }
                    else
                    {
                        iTurn = -1;
                        label1.Text = "                 🗙 Turn";
                    }
                }
            }
            else //In this case Game must be Over (Draw) Or one of them have won it
            {
                if (iGameStatus == -1)
                {
                    iXScores++;
                    button27.Text = "🗙                   " + iXScores.ToString();
                    MessageBox.Show("🗙 has won the Game", "Yay!");
                }
                else if (iGameStatus == 1)
                {
                    iOScores++;
                    button28.Text = "◯                   " + iOScores.ToString();
                    MessageBox.Show("◯ has won the Game", "Yay!");
                }
                else if(iGameStatus==0)
                    MessageBox.Show("Game is drawn", "Oops!");

                iTurn = 0;
                label1.Text = "              Game Over";
            }
        }
        int CheckGameStatus()
        {
            // -
            if (iData[0] != 0 && iData[0] == iData[1] && iData[1] == iData[2] && iData[2] == iData[3])
            {
                return iData[0];
            }
            else if (iData[1] != 0 && iData[1] == iData[2] && iData[2] == iData[3] && iData[3] == iData[4])
            {
                return iData[1];
            }
            else if (iData[5] != 0 && iData[5] == iData[6] && iData[6] == iData[7] && iData[7] == iData[8])
            {

                return iData[5];
            }
            else if (iData[6] != 0 && iData[6] == iData[7] && iData[7] == iData[8] && iData[8] == iData[9])
            {

                return iData[6];
            }
            else if (iData[10] != 0 && iData[10] == iData[11] && iData[11] == iData[12] && iData[12] == iData[13])
            {

                return iData[10];
            }
            else if (iData[11] != 0 && iData[11] == iData[12] && iData[12] == iData[13] && iData[13] == iData[14])
            {

                return iData[11];
            }
            else if (iData[15] != 0 && iData[15] == iData[16] && iData[16] == iData[17] && iData[17] == iData[18])
            {

                return iData[15];
            }
            else if (iData[16] != 0 && iData[16] == iData[17] && iData[17] == iData[18] && iData[18] == iData[19])
            {

                return iData[16];
            }
            else if (iData[20] != 0 && iData[20] == iData[21] && iData[21] == iData[22] && iData[22] == iData[23])
            {

                return iData[20];
            }
            else if (iData[21] != 0 && iData[21] == iData[22] && iData[22] == iData[23] && iData[23] == iData[24])
            {

                return iData[21];
            }
            // |
            else if (iData[0] != 0 && iData[0] == iData[5] && iData[5] == iData[10] && iData[10] == iData[15])
            {

                return iData[0];
            }
            else if (iData[5] != 0 && iData[5] == iData[10] && iData[10] == iData[15] && iData[15] == iData[20])
            {

                return iData[5];
            }
            else if (iData[1] != 0 && iData[1] == iData[6] && iData[6] == iData[11] && iData[11] == iData[16])
            {

                return iData[1];
            }
            else if (iData[6] != 0 && iData[6] == iData[11] && iData[11] == iData[16] && iData[16] == iData[21])
            {

                return iData[6];
            }
            else if (iData[2] != 0 && iData[2] == iData[7] && iData[7] == iData[12] && iData[12] == iData[17])
            {

                return iData[2];
            }
            else if (iData[7] != 0 && iData[7] == iData[12] && iData[12] == iData[17] && iData[17] == iData[22])
            {

                return iData[7];
            }
            else if (iData[3] != 0 && iData[3] == iData[8] && iData[8] == iData[13] && iData[13] == iData[18])
            {

                return iData[3];
            }
            else if (iData[8] != 0 && iData[8] == iData[13] && iData[13] == iData[18] && iData[18] == iData[23])
            {

                return iData[8];
            }
            // \
            else if (iData[0] != 0 && iData[0] == iData[6] && iData[6] == iData[12] && iData[12] == iData[18])
            {
                return iData[0];
            }
            else if (iData[6] != 0 && iData[6] == iData[12] && iData[12] == iData[18] && iData[18] == iData[24])
            {
                return iData[6];
            }
            else if (iData[5] != 0 && iData[5] == iData[11] && iData[11] == iData[17] && iData[17] == iData[23])
            {
                return iData[5];
            }
            else if (iData[1] != 0 && iData[1] == iData[7] && iData[7] == iData[13] && iData[13] == iData[19])
            {
                return iData[1];
            }
            // /
            else if (iData[4] != 0 && iData[4] == iData[8] && iData[8] == iData[12] && iData[12] == iData[16])
            {
                return iData[4];
            }
            else if (iData[8] != 0 && iData[8] == iData[12] && iData[12] == iData[16] && iData[16] == iData[20])
            {
                return iData[8];
            }
            else if (iData[3] != 0 && iData[3] == iData[7] && iData[7] == iData[11] && iData[11] == iData[15])
            {
                return iData[3];
            }
            else if (iData[9] != 0 && iData[9] == iData[13] && iData[13] == iData[17] && iData[17] == iData[21])
            {
                return iData[9];
            }

            //End
            else if (iData[0] != 0 && iData[1] != 0 && iData[2] != 0 && iData[3] != 0 && iData[4] != 0 && iData[5] != 0 && iData[6] != 0 && iData[7] != 0 && iData[8] != 0 && iData[9] != 0 && iData[10] != 0 && iData[11] != 0 && iData[12] != 0 && iData[13] != 0 && iData[14] != 0 && iData[15] != 0 && iData[16] != 0 && iData[17] != 0 && iData[18] != 0 && iData[19] != 0 && iData[20] != 0 && iData[21] != 0 && iData[22] != 0 && iData[23] != 0 && iData[24] != 0)
            {
                return 0;
            }

            return 2;
        }
        void RunBot()
        {
            //3 = Play against a friend , 0 = Game over
            if (iType == 3 || iTurn == 0)
                return;

            bEnableBot = true;

            //0 = Easy, 1 = Medium, 2 = Impossible
            if (iType == 0)
            {
                RunEasyBot();
            }
            else if (iType == 1)
            {
                RunMediumBot();
            }
            else if (iType == 2)
            {
                RunImpossibleBot();
            }
        }
        void RunEasyBot()
        {
            iLastMove = RandomPosition();
            iData[iLastMove] = iTurn;
            ChangeButtonBackgroundImage(iLastMove);
            bEnableBot = false;
            SetNextTurn();
        }
        void RunMediumBot()
        {
            int iOpponent;
            if (iTurn == -1) iOpponent = 1;
            else iOpponent = -1;

            if (iLastMove == -1)
            {
                iLastMove = RandomPosition();
            }
            else
            {
                CheckWinAndDontLose(iOpponent); //Check dont lose
                CheckWinAndDontLose(iTurn); //Check win
                if (iData[iLastMove] != 0)
                    iLastMove = RandomPosition();
            }

            iData[iLastMove] = iTurn;
            ChangeButtonBackgroundImage(iLastMove);
            bEnableBot = false;
            SetNextTurn();
        }
        void RunImpossibleBot()
        {
            int iOpponent;
            if (iTurn == -1) iOpponent = 1;
            else iOpponent = -1;

            if (iLastMove == -1)
            {
                iLastMove = RandomPosition();
            }
            else
            {
                CheckWinAndDontLose(iOpponent); //Check dont lose
                CheckWinAndDontLose(iTurn); //Check win
                if (iData[iLastMove] != 0)
                    iLastMove = RandomPosition();
            }

            iData[iLastMove] = iTurn;
            ChangeButtonBackgroundImage(iLastMove);
            bEnableBot = false;
            SetNextTurn();
        }
        void CheckWinAndDontLose(int turn) //to change
        {
            if (iData[0] == 0 && ((iData[1] == turn && iData[2] == turn && iData[3] == turn) || (iData[5] == turn && iData[10] == turn && iData[15] == turn) || (iData[6] == turn && iData[12] == turn && iData[18] == turn)))
                iLastMove = 0;
            else if (iData[1] == 0 && ((iData[0] == turn && iData[2] == turn && iData[3] == turn) || (iData[2] == turn && iData[3] == turn && iData[4] == turn) || (iData[6] == turn && iData[11] == turn && iData[16] == turn) || (iData[7] == turn && iData[13] == turn && iData[19] == turn)))
                iLastMove = 1;
            else if (iData[2] == 0 && ((iData[1] == turn && iData[3] == turn && iData[4] == turn) || (iData[0] == turn && iData[1] == turn && iData[3] == turn) || (iData[7] == turn && iData[12] == turn && iData[17] == turn)))
                iLastMove = 2;
            else if (iData[3] == 0 && ((iData[0] == turn && iData[1] == turn && iData[2] == turn) || (iData[1] == turn && iData[2] == turn && iData[4] == turn) || (iData[7] == turn && iData[11] == turn && iData[15] == turn) || (iData[8] == turn && iData[13] == turn && iData[18] == turn)))
                iLastMove = 3;
            else if (iData[4] == 0 && ((iData[1] == turn && iData[2] == turn && iData[3] == turn) || (iData[8] == turn && iData[12] == turn && iData[16] == turn) || (iData[9] == turn && iData[14] == turn && iData[19] == turn)))
                iLastMove = 4;
            else if (iData[5] == 0 && ((iData[0] == turn && iData[10] == turn && iData[15] == turn) || (iData[10] == turn && iData[15] == turn && iData[20] == turn) || (iData[6] == turn && iData[7] == turn && iData[8] == turn) || (iData[11] == turn && iData[17] == turn && iData[23] == turn)))
                iLastMove = 5;
            else if (iData[6] == 0 && ((iData[5] == turn && iData[7] == turn && iData[8] == turn) || (iData[7] == turn && iData[8] == turn && iData[9] == turn) || (iData[1] == turn && iData[11] == turn && iData[16] == turn) || (iData[11] == turn && iData[16] == turn && iData[21] == turn) || (iData[0] == turn && iData[12] == turn && iData[18] == turn) || (iData[12] == turn && iData[18] == turn && iData[24] == turn)))
                iLastMove = 6;
            else if (iData[7] == 0 && ((iData[5] == turn && iData[6] == turn && iData[8] == turn) || (iData[6] == turn && iData[8] == turn && iData[9] == turn) || (iData[2] == turn && iData[12] == turn && iData[17] == turn) || (iData[12] == turn && iData[17] == turn && iData[22] == turn) || (iData[1] == turn && iData[13] == turn && iData[19] == turn) || (iData[3] == turn && iData[11] == turn && iData[15] == turn)))
                iLastMove = 7;
            else if (iData[8] == 0 && ((iData[5] == turn && iData[6] == turn && iData[7] == turn) || (iData[6] == turn && iData[7] == turn && iData[9] == turn) || (iData[3] == turn && iData[13] == turn && iData[18] == turn) || (iData[13] == turn && iData[18] == turn && iData[23] == turn) || (iData[4] == turn && iData[12] == turn && iData[16] == turn) || (iData[12] == turn && iData[16] == turn && iData[20] == turn)))
                iLastMove = 8;
            else if (iData[9] == 0 && ((iData[6] == turn && iData[7] == turn && iData[8] == turn) || (iData[4] == turn && iData[14] == turn && iData[19] == turn) || (iData[14] == turn && iData[19] == turn && iData[24] == turn) || (iData[13] == turn && iData[17] == turn && iData[21] == turn)))
                iLastMove = 9;
            else if (iData[10] == 0 && ((iData[0] == turn && iData[5] == turn && iData[15] == turn) || (iData[5] == turn && iData[15] == turn && iData[20] == turn) || (iData[11] == turn && iData[12] == turn && iData[13] == turn)))
                iLastMove = 10;
            else if (iData[11] == 0 && ((iData[10] == turn && iData[12] == turn && iData[13] == turn) || (iData[12] == turn && iData[13] == turn && iData[14] == turn) || (iData[1] == turn && iData[6] == turn && iData[16] == turn) || (iData[6] == turn && iData[16] == turn && iData[21] == turn) || (iData[5] == turn && iData[17] == turn && iData[23] == turn) || (iData[3] == turn && iData[7] == turn && iData[15] == turn)))
                iLastMove = 11;
            else if (iData[12] == 0 && ((iData[11] == turn && iData[12] == turn && iData[13] == turn) || (iData[11] == turn && iData[13] == turn && iData[14] == turn) || (iData[2] == turn && iData[7] == turn && iData[17] == turn) || (iData[7] == turn && iData[17] == turn && iData[22] == turn) || (iData[0] == turn && iData[6] == turn && iData[18] == turn) || (iData[6] == turn && iData[18] == turn && iData[24] == turn) || (iData[4] == turn && iData[8] == turn && iData[16] == turn) || (iData[8] == turn && iData[16] == turn && iData[20] == turn)))
                iLastMove = 12;
            else if (iData[13] == 0 && ((iData[10] == turn && iData[11] == turn && iData[12] == turn) || (iData[11] == turn && iData[12] == turn && iData[14] == turn) || (iData[3] == turn && iData[8] == turn && iData[18] == turn) || (iData[8] == turn && iData[18] == turn && iData[23] == turn) || (iData[1] == turn && iData[7] == turn && iData[19] == turn) || (iData[9] == turn && iData[17] == turn && iData[21] == turn)))
                iLastMove = 13;
            else if (iData[14] == 0 && ((iData[11] == turn && iData[12] == turn && iData[13] == turn) || (iData[4] == turn && iData[9] == turn && iData[19] == turn) || (iData[9] == turn && iData[19] == turn && iData[24] == turn)))
                iLastMove = 14;
            else if (iData[15] == 0 && ((iData[0] == turn && iData[5] == turn && iData[10] == turn) || (iData[5] == turn && iData[10] == turn && iData[20] == turn) || (iData[16] == turn && iData[17] == turn && iData[18] == turn) || (iData[3] == turn && iData[7] == turn && iData[11] == turn)))
                iLastMove = 15;
            else if (iData[16] == 0 && ((iData[1] == turn && iData[6] == turn && iData[11] == turn) || (iData[6] == turn && iData[11] == turn && iData[21] == turn) || (iData[15] == turn && iData[17] == turn && iData[18] == turn) || (iData[17] == turn && iData[18] == turn && iData[19] == turn) || (iData[4] == turn && iData[8] == turn && iData[12] == turn) || (iData[8] == turn && iData[12] == turn && iData[20] == turn)))
                iLastMove = 16;
            else if (iData[17] == 0 && ((iData[15] == turn && iData[16] == turn && iData[18] == turn) || (iData[16] == turn && iData[18] == turn && iData[19] == turn) || (iData[2] == turn && iData[7] == turn && iData[12] == turn) || (iData[7] == turn && iData[12] == turn && iData[22] == turn) || (iData[5] == turn && iData[11] == turn && iData[23] == turn) || (iData[9] == turn && iData[13] == turn && iData[21] == turn)))
                iLastMove = 17;
            else if (iData[18] == 0 && ((iData[15] == turn && iData[16] == turn && iData[17] == turn) || (iData[16] == turn && iData[17] == turn && iData[19] == turn) || (iData[3] == turn && iData[8] == turn && iData[13] == turn) || (iData[8] == turn && iData[13] == turn && iData[23] == turn) || (iData[0] == turn && iData[6] == turn && iData[12] == turn) || (iData[6] == turn && iData[12] == turn && iData[24] == turn)))
                iLastMove = 18;
            else if (iData[19] == 0 && ((iData[16] == turn && iData[17] == turn && iData[18] == turn) || (iData[4] == turn && iData[9] == turn && iData[14] == turn) || (iData[9] == turn && iData[14] == turn && iData[24] == turn) || (iData[1] == turn && iData[7] == turn && iData[13] == turn)))
                iLastMove = 19;
            else if (iData[20] == 0 && ((iData[5] == turn && iData[10] == turn && iData[15] == turn) || (iData[21] == turn && iData[22] == turn && iData[23] == turn) || (iData[8] == turn && iData[12] == turn && iData[16] == turn)))
                iLastMove = 20;
            else if (iData[21] == 0 && ((iData[6] == turn && iData[11] == turn && iData[16] == turn) || (iData[20] == turn && iData[22] == turn && iData[23] == turn) || (iData[22] == turn && iData[23] == turn && iData[24] == turn) || (iData[9] == turn && iData[13] == turn && iData[17] == turn)))
                iLastMove = 21;
            else if (iData[22] == 0 && ((iData[7] == turn && iData[12] == turn && iData[17] == turn) || (iData[20] == turn && iData[21] == turn && iData[23] == turn) || (iData[21] == turn && iData[23] == turn && iData[24] == turn)))
                iLastMove = 22;
            else if (iData[23] == 0 && ((iData[8] == turn && iData[13] == turn && iData[18] == turn) || (iData[20] == turn && iData[21] == turn && iData[22] == turn) || (iData[21] == turn && iData[22] == turn && iData[24] == turn) || (iData[5] == turn && iData[11] == turn && iData[17] == turn)))
                iLastMove = 23;
            else if (iData[24] == 0 && ((iData[9] == turn && iData[14] == turn && iData[19] == turn) || (iData[21] == turn && iData[22] == turn && iData[23] == turn) || (iData[6] == turn && iData[12] == turn && iData[18] == turn)))
                iLastMove = 24;
        }
        int RandomPosition()
        {
            int Count = 0;
            for (int i = 0; i <= 24; i++)
            {
                if (iData[i] == 0)
                {
                    Count++;
                }
            }
            Random rnd = new Random();
            int iRandom = rnd.Next(1, Count);

            Count = 0;
            for (int i = 0; i <= 24; i++)
            {
                if (iData[i] == 0)
                {
                    Count++;
                    if (Count == iRandom)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        void ChangeButtonBackgroundImage(int iPosition)
        {
            if (iData[iPosition] == -1)
            {
                switch (iPosition)
                {
                    case (0): button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (1): button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (2): button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (3): button4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (4): button5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (5): button6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (6): button7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (7): button8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (8): button9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (9): button10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (10): button11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (11): button12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (12): button13.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (13): button14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (14): button15.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (15): button16.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (16): button17.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (17): button18.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (18): button19.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (19): button20.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (20): button21.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (21): button22.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (22): button23.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (23): button24.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (24): button25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                }
            }
            else if (iData[iPosition] == 1)
            {
                switch (iPosition)
                {
                    case (0): button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (1): button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (2): button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (3): button4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (4): button5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (5): button6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (6): button7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (7): button8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (8): button9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (9): button10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (10): button11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (11): button12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (12): button13.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (13): button14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (14): button15.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (15): button16.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (16): button17.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (17): button18.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (18): button19.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (19): button20.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (20): button21.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (21): button22.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (22): button23.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (23): button24.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (24): button25.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                }
            }
            else
            {
                switch (iPosition)
                {
                    case (0): button1.BackgroundImage = null; break;
                    case (1): button2.BackgroundImage = null; break;
                    case (2): button3.BackgroundImage = null; break;
                    case (3): button4.BackgroundImage = null; break;
                    case (4): button5.BackgroundImage = null; break;
                    case (5): button6.BackgroundImage = null; break;
                    case (6): button7.BackgroundImage = null; break;
                    case (7): button8.BackgroundImage = null; break;
                    case (8): button9.BackgroundImage = null; break;
                    case (9): button10.BackgroundImage = null; break;
                    case (10): button11.BackgroundImage = null; break;
                    case (11): button12.BackgroundImage = null; break;
                    case (12): button13.BackgroundImage = null; break;
                    case (13): button14.BackgroundImage = null; break;
                    case (14): button15.BackgroundImage = null; break;
                    case (15): button16.BackgroundImage = null; break;
                    case (16): button17.BackgroundImage = null; break;
                    case (17): button18.BackgroundImage = null; break;
                    case (18): button19.BackgroundImage = null; break;
                    case (19): button20.BackgroundImage = null; break;
                    case (20): button21.BackgroundImage = null; break;
                    case (21): button22.BackgroundImage = null; break;
                    case (22): button23.BackgroundImage = null; break;
                    case (23): button24.BackgroundImage = null; break;
                    case (24): button25.BackgroundImage = null; break;
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        //save & exit
        private void button30_Click(object sender, EventArgs e)
        {
            string filePath = @"D://5x5.txt";

            ////to increase the count of records
            StreamReader sr = new StreamReader(@"D://5x5noOfRecords.txt");
            int noOfRecords;
            noOfRecords = int.Parse(sr.ReadLine());
            sr.Close();

            StreamWriter sw = new StreamWriter(@"D://5x5noOfRecords.txt");
            sw.Write(++noOfRecords);
            sw.Close();

            //write game records
            StreamWriter writer = new StreamWriter(filePath, true);
            for (int i = 0; i < 25; i++)
                writer.WriteLine(iData[i]);
            writer.WriteLine(iTurn);
            writer.WriteLine(iType);
            writer.WriteLine(iLastMove);
            writer.WriteLine(iXScores);
            writer.WriteLine(iOScores);
            //bool type
            writer.WriteLine(bEnableBot);
            writer.Close();
            this.Close();
            // 30 int type and 1 bool
        }
        //to fill the game board from file

        public void loadFromFile(int recordNo)
        {
            int var;
            bool b;
            StreamReader reader = new StreamReader(@"D://5x5.txt");
            //to read record & jump
            for (int i = 1; i < recordNo; i++)
            {
                for (int j = 0; j < 30; j++)
                    var = int.Parse(reader.ReadLine());
                b = bool.Parse(reader.ReadLine());
            }
            //now reading & changing accordingly
            for (int i = 0; i < 25; i++)
            {
                iData[i] = int.Parse(reader.ReadLine());
                ChangeButtonBackgroundImage(i);
            }
            iTurn = int.Parse(reader.ReadLine());
            iType = int.Parse(reader.ReadLine());
            iLastMove = int.Parse(reader.ReadLine());
            iXScores = int.Parse(reader.ReadLine());
            iOScores = int.Parse(reader.ReadLine());
            bEnableBot = bool.Parse(reader.ReadLine());
            reader.Close();
            SetNextTurn();
        }
        ////
    }
}
