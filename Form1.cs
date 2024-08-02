using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
namespace tictactoe
{
    public partial class Form1 : Form
    {
        public int C = 0;
        public int Z = 0;
        public int r = 0;
        public int frow = -1;
        public int fcol = -1;
        public char[,] vboard = new char[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
        }
        public int XO()
        {
            int c = -1;
            if (C < 10)
            {
                C++;
                c = C % 2;
                if (c == 0)
                {
                    Head.Text = "O to move";
                }
                else { Head.Text = "X to move"; }
                return c;
            }
            return c;
        }
        public int BotControl()
        {
            ++Z;
            int z = Z % 2;
            if (z == 0)
            {
                label1.Text = "PVP Mode";
                return z;
            }
            else
            {
                label1.Text = "PvC Mode";
                return z;
            }
        }
        public void Reset()
        {
            C = 0;
            frow = -1;
            fcol = -1;
            l11.Text = "-";
            l11.Text = "-";
            l12.Text = "-";
            l13.Text = "-";
            l21.Text = "-";
            l22.Text = "-";
            l23.Text = "-";
            l31.Text = "-";
            l32.Text = "-";
            l33.Text = "-";
            Head.Text = "LETS PLAY AGAIN!";
        }
        public async void Draw()
        {
            if ((l11.Text != l12.Text) || (l11.Text != l13.Text))
            {
                if ((l21.Text != l22.Text) || (l21.Text != l23.Text))
                {
                    if ((l31.Text != l32.Text) || (l31.Text != l33.Text))
                    {
                        if ((l11.Text != l22.Text) || (l11.Text != l33.Text))
                        {
                            if ((l11.Text != l21.Text) || (l11.Text != l31.Text))
                            {
                                if ((l12.Text != l22.Text) || (l12.Text != l32.Text))
                                {
                                    if ((l13.Text != l23.Text) || (l13.Text != l33.Text))
                                    {
                                        if((l31.Text != l22.Text)||(l31.Text != l11.Text))
                                        {
                                            Head.Text = "ITS A DRAW!";
                                            await Task.Delay(3000);
                                            Reset();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public async void Horch()
        {
            if((l11.Text == "X")&&(l11.Text==l12.Text)&&(l11.Text == l13.Text))
            {
                Head.Text = "X WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else if ((l21.Text == "X") && (l21.Text == l22.Text) && (l21.Text == l23.Text))
            {
                Head.Text = "X WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else if ((l31.Text == "X") && (l31.Text == l32.Text) && (l31.Text == l33.Text))
            {
                Head.Text = "X WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else if ((l11.Text == "O") && (l11.Text == l22.Text) && (l11.Text == l23.Text))
            {
                Head.Text = "O WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else if ((l21.Text == "O") && (l21.Text == l22.Text) && (l21.Text == l23.Text))
            {
                Head.Text = "O WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else if ((l31.Text == "O") && (l31.Text == l32.Text) && (l31.Text == l33.Text))
            {
                Head.Text = "O WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else
            {
                return;
            }
        }
        public async void Verch()
        {
            if ((l11.Text == "X") && (l11.Text == l21.Text) && (l11.Text == l31.Text))
            {
                Head.Text = "X WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else if ((l12.Text == "X") && (l12.Text == l22.Text) && (l12.Text == l32.Text))
            {
                Head.Text = "X WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else if ((l13.Text == "X") && (l13.Text == l23.Text) && (l13.Text == l33.Text))
            {
                Head.Text = "X WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else if ((l11.Text == "O") && (l11.Text == l21.Text) && (l11.Text == l31.Text))
            {
                Head.Text = "O WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else if ((l12.Text == "O") && (l12.Text == l22.Text) && (l12.Text == l32.Text))
            {
                Head.Text = "O WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else if ((l13.Text == "O") && (l13.Text == l23.Text) && (l13.Text == l33.Text))
            {
                Head.Text = "O WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else
            {
                return;
            }
        }
        public async void DiCheck()
        {
            if ((l11.Text == "X") && (l11.Text == l22.Text) && (l11.Text == l33.Text))
            {
                Head.Text = "X WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else if ((l11.Text == "O") && (l11.Text == l22.Text) && (l11.Text == l33.Text))
            {
                Head.Text = "O WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else if ((l31.Text == "X") && (l31.Text == l22.Text) && (l31.Text == l13.Text))
            {
                Head.Text = "X WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else if ((l31.Text == "O") && (l31.Text == l22.Text) && (l31.Text == l13.Text))
            {
                Head.Text = "O WON! CONGRATULATIONS";
                await Task.Delay(2000);
                Reset();
            }
            else
            {
                return;
            }
        }
        public void Convert(string symbol, int row, int col)
        {
            if (row == 0 && col == 0)
                l11.Text = symbol;
            else if(row == 0 && col == 1)
                l12.Text = symbol;
            else if (row == 0 &&col == 2)
                l13.Text = symbol;
            else if (row == 1 && col == 0)
                l21.Text = symbol;
            else if(row == 1 &&col == 1)
                l22.Text = symbol;
            else if(row == 1 && col == 2)
                l13.Text= symbol;
            else if(row == 2 && col == 0)
                l31.Text = symbol;
            else if(row ==2 && col == 1)
                l32.Text = symbol;
            else if(row == 2 && col ==2)
                l32.Text = symbol;
        } 
        public bool CheckWin(char player, out int row, out int col)
        { 
            for(int i = 0; i<3; i++)
            {
                int count = 0;
                int emp = 0;
                for(int j = 0; j<3; j++)
                {
                    if (vboard[i,j] == player)
                    {
                        count++;
                    }
                    else if(vboard[i,j] == ' ')
                    {
                        emp = j;
                    }
                }
                if(count == 2 && emp != -1)
                {
                    row = i;
                    col = emp;
                    return true;
                }
            }
            for (int j = 0; j < 3; j++)
            {
                int count = 0;
                int emp = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (vboard[i, j] == player)
                    {
                        count++;
                    }
                    else if (vboard[i, j] == ' ')
                    {
                        emp = i;
                    }
                }
                if (count == 2 && emp != -1)
                {
                    row = emp;
                    col = j;
                    return true;
                }
            }
            {
                int count = 0;
                int emp = -1;
                for (int i = 0; i < 3; i++)
                {
                    if (vboard[i, i] == player)
                    {
                        count++;
                    }
                    else if (vboard[i, i] == ' ')
                    {
                        emp = i;
                    }
                }
                if (count == 2 && emp != -1)
                {
                    row = emp;
                    col = emp;
                    return true;
                }
            }

            {
                int count = 0;
                int emp = -1;
                for (int i = 0; i < 3; i++)
                {
                    if (vboard[i, 2 - i] == player)
                    {
                        count++;
                    }
                    else if (vboard[i, 2 - i] == ' ')
                    {
                        emp = i;
                    }
                }
                if (count == 2 && emp != -1)
                {
                    row = emp;
                    col = 2 - emp;
                    return true;
                }
            }
            row = -1;
            col = -1;
            return false;
        }
        public void Bot()
        {
            C++;
            Random random = new Random();
            int row, col;
            if (r == 0)
            {
                do
                {
                    row = random.Next(3);
                    col = random.Next(3);
                } while (vboard[row, col] != ' ');
                frow = row;
                fcol = col;
                vboard[row,col] = 'O';
                Convert("O",row, col);
            }
            else if (r == 1)
            {   
                List<int> adj = new List<int>();
                for(int i = frow - 1; i <= frow+1; i++)
                {
                    for(int j = fcol - 1; j <= fcol+1; j++)
                    {
                        if (i >= 0 && i < 3 && j >= 0 && j < 3 && vboard[i, j] == ' ')
                        {
                            adj.Add(i*3+j);
                        }
                    }
                }
                if (adj.Count > 0)
                {
                    int ran = random.Next(adj.Count);
                    int next = adj[ran];
                    row = next / 3;
                    col = next % 3;
                    vboard[row, col] = 'O';
                    Convert("O",row, col);
                }
            }
            else
            {
                char player = ' ';
                if (CheckWin('O', out row, out col))
                {
                    vboard[row, col] = 'O';
                    Convert("O", row, col);
                    return;
                }
                if(CheckWin('X', out row, out col))
                {
                    vboard[row, col] = 'O';
                    Convert("O", row, col);
                    return;
                }

                do
                {
                    row = random.Next(3);
                    col = random.Next(3);
                } while (vboard[row, col] != ' ');
                vboard[row, col] = 'O';
                Convert("O", row, col);
            }
            r++;

        }
        public void I_I_Click(object sender, EventArgs e)
        {
            int m = XO();
            int b = BotControl();
            if (b == 0)
            {
                if (m == 1)
                {
                    l11.Text = "O";
                }
                else if (m == 0)
                {
                    l11.Text = "X";
                }
                else
                {
                    l11.Text = "-";
                }
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
            else
            {
                int row = 0;
                int col = 0;
                l11.Text = "X";
                vboard[row, col] = 'X';
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
                Bot();
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
        }

        private void I_II_Click(object sender, EventArgs e)
        {
            int m = XO();
            int b = BotControl();
            if (b == 0)
            {
                if (m == 1)
                {
                    l12.Text = "O";
                }
                else if (m == 0)
                {
                    l12.Text = "X";
                }
                else
                {
                    l12.Text = "-";
                }
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
            else
            {
                int row = 0;
                int col = 1;
                l12.Text = "X";
                vboard[row, col] = 'X';
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
                Bot();
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
        }

        private void I_III_Click(object sender, EventArgs e)
        {
            int b = BotControl();
            int m = XO();
            if (b == 0)
            {
                if (m == 1)
                {
                    l13.Text = "O";
                }
                else if (m == 0)
                {
                    l13.Text = "X";
                }
                else
                {
                    l13.Text = "-";
                }
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
            else
            {
                int row = 0;
                int col = 2;
                l13.Text = "X";
                vboard[row, col] = 'X';
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
                Bot();
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
        }

        private void II_I_Click(object sender, EventArgs e)
        {
            int b = BotControl();
            int m = XO();
            if (b == 0)
            {
                if (m == 1)
                {
                    l21.Text = "O";
                }
                else if (m == 0)
                {
                    l21.Text = "X";
                }
                else
                {
                    l21.Text = "-";
                }
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
            else
            {
                int row = 1;
                int col = 0;
                l21.Text = "X";
                vboard[row, col] = 'X';
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
                Bot();
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
        }

        private void II_II_Click(object sender, EventArgs e)
        {
            int m = XO();
            int b = BotControl();
            if (b == 0)
            {
                if (m == 1)
                {
                    l22.Text = "O";
                }
                else if (m == 0)
                {
                    l22.Text = "X";
                }
                else
                {
                    l22.Text = "-";
                }
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
            else
            {
                int row = 1;
                int col = 1;
                l22.Text = "X";
                vboard[row, col] = 'X';
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
                Bot();
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
        }

        private void II_III_Click(object sender, EventArgs e)
        {
            int b = BotControl();
            int m = XO();
            if (b == 0)
            {
                if (m == 1)
                {
                    l23.Text = "O";
                }
                else if (m == 0)
                {
                    l23.Text = "X";
                }
                else
                {
                    l23.Text = "-";
                }
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
            else
            {
                int row = 1;
                int col = 2;
                l23.Text = "X";
                vboard[row, col] = 'X';
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
                Bot();
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
        }

        private void III_I_Click(object sender, EventArgs e)
        {
            int b = BotControl();
            int m = XO();
            if (b == 0)
            {
                if (m == 1)
                {
                    l31.Text = "O";
                }
                else if (m == 0)
                {
                    l31.Text = "X";
                }
                else
                {
                    l31.Text = "-";
                }
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
            else
            {
                int row = 0;
                int col = 1;
                l12.Text = "X";
                vboard[row, col] = 'X';
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
                Bot();
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
        }

        private void III_II_Click(object sender, EventArgs e)
        {
            int b = BotControl();
            int m = XO();
            if (b == 0)
            {
                if (m == 1)
                {
                    l32.Text = "O";
                }
                else if (m == 0)
                {
                    l32.Text = "X";
                }
                else
                {
                    l32.Text = "-";
                }
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
            else
            {
                int row = 2;
                int col = 1;
                l32.Text = "X";
                vboard[row, col] = 'X';
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
                Bot();
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
        }

        private void III_III_Click(object sender, EventArgs e)
        {
            int b = BotControl();
            int m = XO();
            if (b == 0)
            {
                if (m == 1)
                {
                    l33.Text = "O";
                }
                else if (m == 0)
                {
                    l33.Text = "X";
                }
                else
                {
                    l33.Text = "-";
                }
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
            else
            {
                int row = 2;
                int col = 2;
                l33.Text = "X";
                vboard[row, col] = 'X';
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
                Bot();
                if (C > 4)
                {
                    Verch();
                    Horch();
                    DiCheck();
                }
                if (C == 9)
                {
                    Draw();
                }
            }
        }

        private void Head_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            BotControl();
        }
    }
}