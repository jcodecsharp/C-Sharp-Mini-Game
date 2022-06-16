using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProj
{
    public partial class Form1 : Form
    {
        
        TextBox[,] textBoxArray = new TextBox[5, 5];
        private static Random rnd;
        int testNum = 2;
        int prevNum = 1;
        int timerNumber = 0;
        int gameHistoryTimer = 0;
        List<string> gameHistory1 = new List<string>();
        
        public static int gameName = 0;
        public static string playerName = "Player 1";
        public static DateTime dateTime = DateTime.Now;
       



        public Form1()
        {
            InitializeComponent();
           
            textBoxArray[0, 0] = textBox1;
            textBoxArray[0, 1] = textBox2;
            textBoxArray[0, 2] = textBox3;
            textBoxArray[0, 3] = textBox4;
            textBoxArray[0, 4] = textBox5;
            textBoxArray[1, 0] = textBox6;
            textBoxArray[1, 1] = textBox7;
            textBoxArray[1, 2] = textBox8;
            textBoxArray[1, 3] = textBox9;
            textBoxArray[1, 4] = textBox10;
            textBoxArray[2, 0] = textBox11;
            textBoxArray[2, 1] = textBox12;
            textBoxArray[2, 2] = textBox13;
            textBoxArray[2, 3] = textBox14;
            textBoxArray[2, 4] = textBox15;
            textBoxArray[3, 0] = textBox16;
            textBoxArray[3, 1] = textBox17;
            textBoxArray[3, 2] = textBox18;
            textBoxArray[3, 3] = textBox19;
            textBoxArray[3, 4] = textBox20;
            textBoxArray[4, 0] = textBox21;
            textBoxArray[4, 1] = textBox22;
            textBoxArray[4, 2] = textBox23;
            textBoxArray[4, 3] = textBox24;
            textBoxArray[4, 4] = textBox25;
            
            
        }

        

        public void newGame_Click(object sender, EventArgs e)
        {
            testNum = 2;
            prevNum = 1;
            if(gameHistoryTimer != 0)
            {
                gameHistory1.Add(gameHistoryTimer.ToString() + " seconds");
                gameHistoryTimer = 0;
            }
            else if (gameHistoryTimer == 0 && gameName != 0)
                {
                    gameHistory1.Add(gameHistoryTimer.ToString() + " seconds");
                }
            dateTime = DateTime.Now;
            gameName++;
            gameHistory1.Add("Game Started " + dateTime.ToString());
            gameHistory1.Add(playerName);
            gameHistory1.Add("Game " + gameName.ToString());
            gameHistory1.Add("Total time game took: ");



            
            rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    textBoxArray[i, j].Text = "";
                    textBoxArray[i, j].ReadOnly = false;
                }
            }
            int randomNum = rnd.Next(0, 5);
            int randomNum2 = rnd.Next(0, 5);
            
            textBoxArray[randomNum, randomNum2].Text = "1";
            textBoxArray[randomNum, randomNum2].ReadOnly = true;
            timerNumber = 0;
            label1.Text = "0 seconds";
            timer1.Start();
            timer2.Start();
           
            
        }
        private void ifTextChanged (object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Contains(" "))
            {


                MessageBox.Show("Only Enter One Number, No Spaces Or Multiple Numbers");
                (sender as TextBox).Text = "";
                


            }
            // Check if surronding cells are empty
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // Catpure the selected textbox
                    if (textBoxArray[i, j].Focused)
                    {
                        if (!textBoxArray[i, j].Text.Equals("") && textBoxArray[i, j] == textBoxArray[0, 0]) 
                        {
                            if(textBoxArray[i,j+1].Text.Equals("") && textBoxArray[i + 1, j + 1].Text.Equals("") &&
                                textBoxArray[i + 1, j].Text.Equals("") || (!textBoxArray[i, j + 1].Text.Equals(prevNum.ToString()) && !textBoxArray[i + 1, j + 1].Text.Equals(prevNum.ToString()) &&
                                !textBoxArray[i + 1, j].Text.Equals(prevNum.ToString())))
                            {
                                textBoxArray[i, j].Text = "";
                                MessageBox.Show("All surrounding cells are empty, " +
                                  "choose a cell next to the previous number");
                                goto TxtChangedLoopEnd;
                            }
                            if (!textBoxArray[i, j + 1].Text.Equals("") && !textBoxArray[i + 1, j + 1].Text.Equals("") &&
                                !textBoxArray[i + 1, j].Text.Equals("") && prevNum != 24)
                            {
                                MessageBox.Show("Game Failed");
                                timer1.Stop();
                                timer2.Stop();
                                
                                for (int g = 0; g < 5; g++)
                                {
                                    for (int h = 0; h < 5; h++)
                                    {
                                        textBoxArray[g, h].ReadOnly = true;
                                    }
                                }
                            }


                        }
                        if (!textBoxArray[i, j].Text.Equals("") && textBoxArray[i, j] == textBoxArray[4, 0])
                        {
                            if (textBoxArray[i, j + 1].Text.Equals("") && textBoxArray[i - 1, j + 1].Text.Equals("") &&
                                textBoxArray[i - 1, j].Text.Equals("") || (!textBoxArray[i, j + 1].Text.Equals(prevNum.ToString()) && !textBoxArray[i - 1, j + 1].Text.Equals(prevNum.ToString()) &&
                               !textBoxArray[i - 1, j].Text.Equals(prevNum.ToString())))
                            {
                                textBoxArray[i, j].Text = "";
                                MessageBox.Show("All surrounding cells are empty, " +
                                  "choose a cell next to the previous number");
                                goto TxtChangedLoopEnd;
                               
                            }
                            if (!textBoxArray[i, j + 1].Text.Equals("") && !textBoxArray[i - 1, j + 1].Text.Equals("") &&
                               !textBoxArray[i - 1, j].Text.Equals("") && prevNum != 24)
                            {
                                MessageBox.Show("Game Failed");
                                timer1.Stop();
                                timer2.Stop();
                                
                                for (int g = 0; g < 5; g++)
                                {
                                    for (int h = 0; h < 5; h++)
                                    {
                                        textBoxArray[g, h].ReadOnly = true;
                                    }
                                }
                            }


                        }
                        if (!textBoxArray[i, j].Text.Equals("") && textBoxArray[i, j] == textBoxArray[0, 4])
                        {
                            if (textBoxArray[i, j - 1].Text.Equals("") && textBoxArray[i + 1, j - 1].Text.Equals("") &&
                                textBoxArray[i + 1, j].Text.Equals("") || (!textBoxArray[i, j - 1].Text.Equals(prevNum.ToString()) && !textBoxArray[i + 1, j - 1].Text.Equals(prevNum.ToString()) &&
                                !textBoxArray[i + 1, j].Text.Equals(prevNum.ToString())))
                            {
                                textBoxArray[i, j].Text = "";
                                MessageBox.Show("All surrounding cells are empty, " +
                                  "choose a cell next to the previous number");
                                goto TxtChangedLoopEnd;

                            }
                            if (!textBoxArray[i, j - 1].Text.Equals("") && !textBoxArray[i + 1, j - 1].Text.Equals("") &&
                                !textBoxArray[i + 1, j].Text.Equals("") && prevNum != 24)
                            {
                                MessageBox.Show("Game Failed");
                                timer1.Stop();
                                timer2.Stop();
                                for (int g = 0; g < 5; g++)
                                {
                                    for (int h = 0; h < 5; h++)
                                    {
                                        textBoxArray[g, h].ReadOnly = true;
                                    }
                                }
                            }


                        }
                        if (!textBoxArray[i, j].Text.Equals("") && textBoxArray[i, j] == textBoxArray[4, 4])
                        {
                            if (textBoxArray[i, j - 1].Text.Equals("") && textBoxArray[i - 1, j - 1].Text.Equals("") &&
                                textBoxArray[i - 1, j].Text.Equals("") || (!textBoxArray[i, j - 1].Text.Equals(prevNum.ToString()) && !textBoxArray[i - 1, j - 1].Text.Equals(prevNum.ToString()) &&
                               !textBoxArray[i - 1, j].Text.Equals(prevNum.ToString())))
                            {
                                textBoxArray[i, j].Text = "";
                                MessageBox.Show("All surrounding cells are empty, " +
                                  "choose a cell next to the previous number");
                                goto TxtChangedLoopEnd;

                            }
                            if (!textBoxArray[i, j - 1].Text.Equals("") && !textBoxArray[i - 1, j - 1].Text.Equals("") &&
                               !textBoxArray[i - 1, j].Text.Equals("") && prevNum != 24)
                            {
                                MessageBox.Show("Game Failed");
                                timer1.Stop();
                                timer2.Stop();
                                for (int g = 0; g < 5; g++)
                                {
                                    for (int h = 0; h < 5; h++)
                                    {
                                        textBoxArray[g, h].ReadOnly = true;
                                    }
                                }
                            }


                        }
                        if (!textBoxArray[i, j].Text.Equals("") && (textBoxArray[i, j] == textBoxArray[1, 0] || textBoxArray[i, j] == textBoxArray[2, 0]
                            || textBoxArray[i, j] == textBoxArray[3, 0]))
                        {
                            if (textBoxArray[i, j + 1].Text.Equals("") && textBoxArray[i + 1, j + 1].Text.Equals("") &&
                                textBoxArray[i + 1, j].Text.Equals("") && textBoxArray[i - 1, j ].Text.Equals("")
                                && textBoxArray[i - 1, j + 1].Text.Equals("") || (!textBoxArray[i, j + 1].Text.Equals(prevNum.ToString()) && !textBoxArray[i + 1, j + 1].Text.Equals(prevNum.ToString()) &&
                                !textBoxArray[i + 1, j].Text.Equals(prevNum.ToString()) && !textBoxArray[i - 1, j].Text.Equals(prevNum.ToString())
                                && !textBoxArray[i - 1, j + 1].Text.Equals(prevNum.ToString())))
                            {
                                textBoxArray[i, j].Text = "";
                                MessageBox.Show("All surrounding cells are empty, " +
                                  "choose a cell next to the previous number");
                                goto TxtChangedLoopEnd;

                            }
                            if (!textBoxArray[i, j + 1].Text.Equals("") && !textBoxArray[i + 1, j + 1].Text.Equals("") &&
                               !textBoxArray[i + 1, j].Text.Equals("") && !textBoxArray[i - 1, j].Text.Equals("")
                               && !textBoxArray[i - 1, j + 1].Text.Equals("") && prevNum != 24)
                            {
                                MessageBox.Show("Game Failed");
                                timer1.Stop();
                                timer2.Stop();
                                for (int g = 0; g < 5; g++)
                                {
                                    for (int h = 0; h < 5; h++)
                                    {
                                        textBoxArray[g, h].ReadOnly = true;
                                    }
                                }
                            }


                        }
                        if (!textBoxArray[i, j].Text.Equals("") && (textBoxArray[i, j] == textBoxArray[1, 4] || textBoxArray[i, j] == textBoxArray[2, 4]
                            || textBoxArray[i, j] == textBoxArray[3, 4]))
                        {
                            if (textBoxArray[i, j - 1].Text.Equals("") && textBoxArray[i - 1, j].Text.Equals("") &&
                                textBoxArray[i + 1, j].Text.Equals("") && textBoxArray[i - 1, j - 1].Text.Equals("")
                                && textBoxArray[i + 1, j - 1].Text.Equals("") || (!textBoxArray[i, j - 1].Text.Equals(prevNum.ToString()) && !textBoxArray[i - 1, j].Text.Equals(prevNum.ToString()) &&
                                !textBoxArray[i + 1, j].Text.Equals(prevNum.ToString()) && !textBoxArray[i - 1, j - 1].Text.Equals(prevNum.ToString())
                                && !textBoxArray[i + 1, j - 1].Text.Equals(prevNum.ToString())))
                            {
                                textBoxArray[i, j].Text = "";
                                MessageBox.Show("All surrounding cells are empty, " +
                                  "choose a cell next to the previous number");
                                goto TxtChangedLoopEnd;

                            }
                            if (!textBoxArray[i, j - 1].Text.Equals("") && !textBoxArray[i - 1, j].Text.Equals("") &&
                                !textBoxArray[i + 1, j].Text.Equals("") && !textBoxArray[i - 1, j - 1].Text.Equals("")
                                && !textBoxArray[i + 1, j - 1].Text.Equals("") && prevNum != 24)
                            {
                                MessageBox.Show("Game Failed");
                                timer1.Stop();
                                timer2.Stop();
                                for (int g = 0; g < 5; g++)
                                {
                                    for (int h = 0; h < 5; h++)
                                    {
                                        textBoxArray[g, h].ReadOnly = true;
                                    }
                                }
                            }


                        }

                             if (!textBoxArray[i,j].Text.Equals("") && (textBoxArray[i, j] == textBoxArray[1, 1] ||
                             textBoxArray[i, j] == textBoxArray[1, 2] || textBoxArray[i, j] == textBoxArray[1, 3] ||
                             textBoxArray[i, j] == textBoxArray[2, 1] || textBoxArray[i, j] == textBoxArray[2, 2] ||
                             textBoxArray[i, j] == textBoxArray[2, 3] || textBoxArray[i, j] == textBoxArray[3, 1] ||
                             textBoxArray[i, j] == textBoxArray[3, 2] || textBoxArray[i, j] == textBoxArray[3, 3]))
                             {
                                 if (textBoxArray[i + 1, j].Text.Equals("") && textBoxArray[i - 1 , j].Text.Equals("") &&
                                     textBoxArray[i, j - 1].Text.Equals("") && textBoxArray[i, j + 1].Text.Equals("")
                                     && textBoxArray[i - 1, j - 1].Text.Equals("") && textBoxArray[i - 1, j + 1].Text.Equals("")
                                     && textBoxArray[i + 1, j - 1].Text.Equals("") && textBoxArray[i + 1, j + 1].Text.Equals("") || (!textBoxArray[i + 1, j].Text.Equals(prevNum.ToString())
                                     && !textBoxArray[i - 1, j].Text.Equals(prevNum.ToString()) &&
                                    !textBoxArray[i, j - 1].Text.Equals(prevNum.ToString()) && !textBoxArray[i, j + 1].Text.Equals(prevNum.ToString())
                                     && !textBoxArray[i - 1, j - 1].Text.Equals(prevNum.ToString()) && !textBoxArray[i - 1, j + 1].Text.Equals(prevNum.ToString())
                                    && !textBoxArray[i + 1, j - 1].Text.Equals(prevNum.ToString()) && !textBoxArray[i + 1, j + 1].Text.Equals(prevNum.ToString())))
                                 {
                                      textBoxArray[i, j].Text = "";
                                       MessageBox.Show("All surrounding cells are empty, " +
                                       "choose a cell next to the previous number");
                                       goto TxtChangedLoopEnd;

                                 }
                                if (!textBoxArray[i + 1, j].Text.Equals("") && !textBoxArray[i - 1, j].Text.Equals("") &&
                                      !textBoxArray[i, j - 1].Text.Equals("") && !textBoxArray[i, j + 1].Text.Equals("")
                                      && !textBoxArray[i - 1, j - 1].Text.Equals("") && !textBoxArray[i - 1, j + 1].Text.Equals("")
                                      && !textBoxArray[i + 1, j - 1].Text.Equals("") && !textBoxArray[i + 1, j + 1].Text.Equals("") && prevNum != 24)
                                {
                                        MessageBox.Show("Game failed");
                                        timer1.Stop();
                                        timer2.Stop();
                                for (int g = 0; g < 5; g++)
                                        {
                                            for (int h = 0; h < 5; h++)
                                            {
                                        textBoxArray[g, h].ReadOnly = true;
                                            }
                                        }
                                            
                                }

                        }
                        if (!textBoxArray[i, j].Text.Equals("") && (textBoxArray[i, j] == textBoxArray[0, 1] || textBoxArray[i, j] == textBoxArray[0, 2]
                                || textBoxArray[i, j] == textBoxArray[0, 3]))
                        {
                            if (textBoxArray[i, j - 1].Text.Equals("") && textBoxArray[i, j + 1].Text.Equals("") &&
                                textBoxArray[i + 1, j].Text.Equals("") && textBoxArray[i + 1, j - 1].Text.Equals("")
                                && textBoxArray[i + 1, j + 1].Text.Equals("") || (!textBoxArray[i, j - 1].Text.Equals(prevNum.ToString()) && !textBoxArray[i, j + 1].Text.Equals(prevNum.ToString()) &&
                                !textBoxArray[i + 1, j].Text.Equals(prevNum.ToString()) && !textBoxArray[i + 1, j - 1].Text.Equals(prevNum.ToString())
                                && !textBoxArray[i + 1, j + 1].Text.Equals(prevNum.ToString())))
                            {
                                textBoxArray[i, j].Text = "";
                                MessageBox.Show("All surrounding cells are empty, " +
                                  "choose a cell next to the previous number");
                                goto TxtChangedLoopEnd;

                            }
                            if (!textBoxArray[i, j - 1].Text.Equals("") && !textBoxArray[i, j + 1].Text.Equals("") &&
                               !textBoxArray[i + 1, j].Text.Equals("") && !textBoxArray[i + 1, j - 1].Text.Equals("")
                               && !textBoxArray[i + 1, j + 1].Text.Equals("") && prevNum != 24)
                            {
                                MessageBox.Show("Game failed");
                                timer1.Stop();
                                timer2.Stop();
                                for (int g = 0; g < 5; g++)
                                {
                                    for (int h = 0; h < 5; h++)
                                    {
                                        textBoxArray[g, h].ReadOnly = true;
                                    }
                                }
                            }



                        }
                        if (!textBoxArray[i, j].Text.Equals("") && (textBoxArray[i, j] == textBoxArray[4, 1] || textBoxArray[i, j] == textBoxArray[4, 2]
                            || textBoxArray[i, j] == textBoxArray[4, 3]))
                        {
                            if (textBoxArray[i, j + 1].Text.Equals("") && textBoxArray[i, j - 1].Text.Equals("") &&
                                textBoxArray[i - 1, j].Text.Equals("") && textBoxArray[i - 1, j + 1].Text.Equals("")
                                && textBoxArray[i - 1, j - 1].Text.Equals("") || (!textBoxArray[i, j + 1].Text.Equals(prevNum.ToString()) && !textBoxArray[i, j - 1].Text.Equals(prevNum.ToString()) &&
                                !textBoxArray[i - 1, j].Text.Equals(prevNum.ToString()) && !textBoxArray[i - 1, j + 1].Text.Equals(prevNum.ToString())
                                && !textBoxArray[i - 1, j - 1].Text.Equals(prevNum.ToString())))
                            {
                                textBoxArray[i, j].Text = "";
                                MessageBox.Show("All surrounding cells are empty, " +
                                  "choose a cell next to the previous number");
                                goto TxtChangedLoopEnd;

                            }
                            if (!textBoxArray[i, j + 1].Text.Equals("") && !textBoxArray[i, j - 1].Text.Equals("") &&
                                !textBoxArray[i - 1, j].Text.Equals("") && !textBoxArray[i - 1, j + 1].Text.Equals("")
                                && !textBoxArray[i - 1, j - 1].Text.Equals("") && prevNum != 24)
                            {
                                MessageBox.Show("Game failed");
                                timer1.Stop();
                                timer2.Stop();
                                for (int g = 0; g < 5; g++)
                                {
                                    for (int h = 0; h < 5; h++)
                                    {
                                        textBoxArray[g, h].ReadOnly = true;
                                    }
                                }
                            }


                        }


                    }
                }
            }
        TxtChangedLoopEnd:;

        }

        private void LeaveTextBox (object sender, EventArgs e)
        {
               for (int y = 0; y < 5; y++)
               {
                   for (int z = 0; z < 5; z++)
                   {
                    
                    if (int.TryParse((sender as TextBox).Text, out testNum))
                    {
                        if (prevNum == testNum - 1)
                        {
                            
                            prevNum++;
                            if(testNum == 25)
                            {
                                timer1.Stop();
                                timer2.Stop();
                                for (int o = 0; o < 5; o++)
                                {
                                    for (int p = 0; p < 5; p++)
                                    {
                                        textBoxArray[o, p].ReadOnly = true;
                                    }
                                }
                                MessageBox.Show("WINNER!!!!!!!!!!!!");

                            }
                            goto LoopEnd;
                        }
                     
                        if(prevNum != testNum - 1)
                        {

                            MessageBox.Show("Enter Numbers In Order From 2 - 25. No duplicate values either.","ENTER " +
                                "NUMBERS IN ORDER, NO DUPLICATES");
                            (sender as TextBox).Text = "";
                            goto LoopEnd;
                        }
                       
                    }
                    else
                    {
                        if((sender as TextBox).Text.Equals(""))
                        { 
                            continue;
                        }
                        else 
                        {
                            MessageBox.Show("INVALID INPUT");
                            (sender as TextBox).Text = "";
                            (sender as TextBox).Focus();
                            break;
                        }
                        
                    }
                   }
                   
               }
        LoopEnd:;
        }

        private void abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void myTimer_Tick(object sender, EventArgs e)
        {
            timerNumber++;
            label1.Text = timerNumber.ToString() + " Seconds";
        }

        private void gameHistory_Click(object sender, EventArgs e)
        {
            var message = string.Join(Environment.NewLine, gameHistory1);
            MessageBox.Show(message);
        }
        private void myTimer_Tick2(object sender, EventArgs e)
        {
            gameHistoryTimer++;
            
        }

        private void showSolution_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            testNum = 2;
            prevNum = 1;
            for(int i = 0; i < 5; i++)
            {
                for(int j =0; j < 5; j++)
                {
                   
                    if (textBoxArray[0, 0].Text.Equals("1"))
                    {
                        textBoxArray[0, 1].Text = "2";
                        textBoxArray[0, 2].Text = "3";
                        textBoxArray[0, 3].Text = "4";
                        textBoxArray[0, 4].Text = "5";
                        textBoxArray[1, 4].Text = "6";
                        textBoxArray[1, 3].Text = "7";
                        textBoxArray[1, 2].Text = "8";
                        textBoxArray[1, 1].Text = "9";
                        textBoxArray[1, 0].Text = "10";
                        textBoxArray[2, 0].Text = "11";
                        textBoxArray[2, 1].Text = "12";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "14";
                        textBoxArray[2, 4].Text = "15";
                        textBoxArray[3, 4].Text = "16";
                        textBoxArray[3, 3].Text = "17";
                        textBoxArray[3, 2].Text = "18";
                        textBoxArray[3, 1].Text = "19";
                        textBoxArray[3, 0].Text = "20";
                        textBoxArray[4, 0].Text = "21";
                        textBoxArray[4, 1].Text = "22";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "24";
                        textBoxArray[4, 4].Text = "25";
                        for(int k = 0; k < 5; k++)
                        {
                            for(int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[1, 1].Text.Equals("1"))
                    {
                        textBoxArray[0, 1].Text = "4";
                        textBoxArray[0, 2].Text = "5";
                        textBoxArray[0, 3].Text = "6";
                        textBoxArray[0, 4].Text = "7";
                        textBoxArray[1, 4].Text = "8";
                        textBoxArray[1, 3].Text = "9";
                        textBoxArray[1, 2].Text = "10";
                        textBoxArray[0, 0].Text = "3";
                        textBoxArray[1, 0].Text = "2";
                        textBoxArray[2, 0].Text = "13";
                        textBoxArray[2, 1].Text = "12";
                        textBoxArray[2, 2].Text = "11";
                        textBoxArray[2, 3].Text = "17";
                        textBoxArray[2, 4].Text = "19";
                        textBoxArray[3, 4].Text = "20";
                        textBoxArray[3, 3].Text = "18";
                        textBoxArray[3, 2].Text = "16";
                        textBoxArray[3, 1].Text = "15";
                        textBoxArray[3, 0].Text = "14";
                        textBoxArray[4, 0].Text = "25";
                        textBoxArray[4, 1].Text = "24";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "22";
                        textBoxArray[4, 4].Text = "21";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[2, 2].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "5";
                        textBoxArray[0, 1].Text = "6";
                        textBoxArray[0, 2].Text = "8";
                        textBoxArray[0, 3].Text = "10";
                        textBoxArray[0, 4].Text = "12";
                        textBoxArray[1, 4].Text = "13";
                        textBoxArray[1, 3].Text = "11";
                        textBoxArray[1, 2].Text = "9";
                        textBoxArray[1, 1].Text = "7";
                        textBoxArray[1, 0].Text = "4";
                        textBoxArray[2, 0].Text = "3";
                        textBoxArray[2, 1].Text = "2";
                        textBoxArray[2, 3].Text = "15";
                        textBoxArray[2, 4].Text = "14";
                        textBoxArray[3, 4].Text = "16";
                        textBoxArray[3, 3].Text = "17";
                        textBoxArray[3, 2].Text = "18";
                        textBoxArray[3, 1].Text = "19";
                        textBoxArray[3, 0].Text = "20";
                        textBoxArray[4, 0].Text = "21";
                        textBoxArray[4, 1].Text = "22";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "24";
                        textBoxArray[4, 4].Text = "25";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[3, 3].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "21";
                        textBoxArray[0, 1].Text = "22";
                        textBoxArray[0, 2].Text = "23";
                        textBoxArray[0, 3].Text = "24";
                        textBoxArray[0, 4].Text = "25";
                        textBoxArray[1, 4].Text = "16";
                        textBoxArray[1, 3].Text = "17";
                        textBoxArray[1, 2].Text = "18";
                        textBoxArray[1, 1].Text = "19";
                        textBoxArray[1, 0].Text = "20";
                        textBoxArray[2, 0].Text = "11";
                        textBoxArray[2, 1].Text = "12";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "14";
                        textBoxArray[2, 4].Text = "15";
                        textBoxArray[3, 4].Text = "2";
                        textBoxArray[3, 2].Text = "6";
                        textBoxArray[3, 1].Text = "8";
                        textBoxArray[3, 0].Text = "10";
                        textBoxArray[4, 0].Text = "9";
                        textBoxArray[4, 1].Text = "7";
                        textBoxArray[4, 2].Text = "5";
                        textBoxArray[4, 3].Text = "4";
                        textBoxArray[4, 4].Text = "3";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[4, 4].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "25";
                        textBoxArray[0, 1].Text = "24";
                        textBoxArray[0, 2].Text = "23";
                        textBoxArray[0, 3].Text = "22";
                        textBoxArray[0, 4].Text = "21";
                        textBoxArray[1, 4].Text = "20";
                        textBoxArray[1, 3].Text = "19";
                        textBoxArray[1, 2].Text = "18";
                        textBoxArray[1, 1].Text = "17";
                        textBoxArray[1, 0].Text = "16";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[2, 4].Text = "11";
                        textBoxArray[3, 4].Text = "10";
                        textBoxArray[3, 3].Text = "9";
                        textBoxArray[3, 2].Text = "8";
                        textBoxArray[3, 1].Text = "7";
                        textBoxArray[3, 0].Text = "6";
                        textBoxArray[4, 0].Text = "5";
                        textBoxArray[4, 1].Text = "4";
                        textBoxArray[4, 2].Text = "3";
                        textBoxArray[4, 3].Text = "2";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[0, 1].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "2";
                        textBoxArray[0, 2].Text = "5";
                        textBoxArray[0, 3].Text = "7";
                        textBoxArray[0, 4].Text = "9";
                        textBoxArray[1, 4].Text = "10";
                        textBoxArray[1, 3].Text = "8";
                        textBoxArray[1, 2].Text = "6";
                        textBoxArray[1, 1].Text = "4";
                        textBoxArray[1, 0].Text = "3";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[2, 4].Text = "11";
                        textBoxArray[3, 4].Text = "20";
                        textBoxArray[3, 3].Text = "19";
                        textBoxArray[3, 2].Text = "18";
                        textBoxArray[3, 1].Text = "17";
                        textBoxArray[3, 0].Text = "16";
                        textBoxArray[4, 0].Text = "25";
                        textBoxArray[4, 1].Text = "24";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "22";
                        textBoxArray[4, 4].Text = "21";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[0, 2].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "3";
                        textBoxArray[0, 1].Text = "2";
                        textBoxArray[0, 3].Text = "8";
                        textBoxArray[0, 4].Text = "9";
                        textBoxArray[1, 4].Text = "10";
                        textBoxArray[1, 3].Text = "7";
                        textBoxArray[1, 2].Text = "6";
                        textBoxArray[1, 1].Text = "5";
                        textBoxArray[1, 0].Text = "4";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[2, 4].Text = "11";
                        textBoxArray[3, 4].Text = "20";
                        textBoxArray[3, 3].Text = "19";
                        textBoxArray[3, 2].Text = "18";
                        textBoxArray[3, 1].Text = "17";
                        textBoxArray[3, 0].Text = "16";
                        textBoxArray[4, 0].Text = "25";
                        textBoxArray[4, 1].Text = "24";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "22";
                        textBoxArray[4, 4].Text = "21";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[0, 3].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "9";
                        textBoxArray[0, 1].Text = "7";
                        textBoxArray[0, 2].Text = "5";
                        textBoxArray[0, 4].Text = "2";
                        textBoxArray[1, 4].Text = "3";
                        textBoxArray[1, 3].Text = "4";
                        textBoxArray[1, 2].Text = "6";
                        textBoxArray[1, 1].Text = "8";
                        textBoxArray[1, 0].Text = "10";
                        textBoxArray[2, 0].Text = "11";
                        textBoxArray[2, 1].Text = "12";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "14";
                        textBoxArray[2, 4].Text = "15";
                        textBoxArray[3, 4].Text = "16";
                        textBoxArray[3, 3].Text = "17";
                        textBoxArray[3, 2].Text = "18";
                        textBoxArray[3, 1].Text = "19";
                        textBoxArray[3, 0].Text = "20";
                        textBoxArray[4, 0].Text = "21";
                        textBoxArray[4, 1].Text = "22";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "24";
                        textBoxArray[4, 4].Text = "25";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[0, 4].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "5";
                        textBoxArray[0, 1].Text = "4";
                        textBoxArray[0, 2].Text = "3";
                        textBoxArray[0, 3].Text = "2";
                        textBoxArray[1, 4].Text = "10";
                        textBoxArray[1, 3].Text = "9";
                        textBoxArray[1, 2].Text = "8";
                        textBoxArray[1, 1].Text = "7";
                        textBoxArray[1, 0].Text = "6";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[2, 4].Text = "11";
                        textBoxArray[3, 4].Text = "20";
                        textBoxArray[3, 3].Text = "19";
                        textBoxArray[3, 2].Text = "18";
                        textBoxArray[3, 1].Text = "17";
                        textBoxArray[3, 0].Text = "16";
                        textBoxArray[4, 0].Text = "25";
                        textBoxArray[4, 1].Text = "24";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "22";
                        textBoxArray[4, 4].Text = "21";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[1, 0].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "2";
                        textBoxArray[0, 1].Text = "4";
                        textBoxArray[0, 2].Text = "6";
                        textBoxArray[0, 3].Text = "8";
                        textBoxArray[0, 4].Text = "9";
                        textBoxArray[1, 4].Text = "10";
                        textBoxArray[1, 3].Text = "7";
                        textBoxArray[1, 2].Text = "5";
                        textBoxArray[1, 1].Text = "3";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[2, 4].Text = "11";
                        textBoxArray[3, 4].Text = "20";
                        textBoxArray[3, 3].Text = "19";
                        textBoxArray[3, 2].Text = "18";
                        textBoxArray[3, 1].Text = "17";
                        textBoxArray[3, 0].Text = "16";
                        textBoxArray[4, 0].Text = "25";
                        textBoxArray[4, 1].Text = "24";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "22";
                        textBoxArray[4, 4].Text = "21";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[1, 2].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "4";
                        textBoxArray[0, 1].Text = "5";
                        textBoxArray[0, 2].Text = "6";
                        textBoxArray[0, 3].Text = "7";
                        textBoxArray[0, 4].Text = "9";
                        textBoxArray[1, 4].Text = "10";
                        textBoxArray[1, 3].Text = "8";                        
                        textBoxArray[1, 1].Text = "2";
                        textBoxArray[1, 0].Text = "3";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[2, 4].Text = "11";
                        textBoxArray[3, 4].Text = "20";
                        textBoxArray[3, 3].Text = "19";
                        textBoxArray[3, 2].Text = "18";
                        textBoxArray[3, 1].Text = "17";
                        textBoxArray[3, 0].Text = "16";
                        textBoxArray[4, 0].Text = "25";
                        textBoxArray[4, 1].Text = "24";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "22";
                        textBoxArray[4, 4].Text = "21";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[1, 3].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "5";
                        textBoxArray[0, 1].Text = "6";
                        textBoxArray[0, 2].Text = "7";
                        textBoxArray[0, 3].Text = "8";
                        textBoxArray[0, 4].Text = "9";
                        textBoxArray[1, 4].Text = "10";
                        textBoxArray[1, 2].Text = "2";
                        textBoxArray[1, 1].Text = "3";
                        textBoxArray[1, 0].Text = "4";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[2, 4].Text = "11";
                        textBoxArray[3, 4].Text = "20";
                        textBoxArray[3, 3].Text = "19";
                        textBoxArray[3, 2].Text = "18";
                        textBoxArray[3, 1].Text = "17";
                        textBoxArray[3, 0].Text = "16";
                        textBoxArray[4, 0].Text = "25";
                        textBoxArray[4, 1].Text = "24";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "22";
                        textBoxArray[4, 4].Text = "21";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[1, 4].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "6";
                        textBoxArray[0, 1].Text = "5";
                        textBoxArray[0, 2].Text = "4";
                        textBoxArray[0, 3].Text = "3";
                        textBoxArray[0, 4].Text = "2";
                        textBoxArray[1, 3].Text = "10";
                        textBoxArray[1, 2].Text = "9";
                        textBoxArray[1, 1].Text = "8";
                        textBoxArray[1, 0].Text = "7";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[2, 4].Text = "11";
                        textBoxArray[3, 4].Text = "20";
                        textBoxArray[3, 3].Text = "19";
                        textBoxArray[3, 2].Text = "18";
                        textBoxArray[3, 1].Text = "17";
                        textBoxArray[3, 0].Text = "16";
                        textBoxArray[4, 0].Text = "25";
                        textBoxArray[4, 1].Text = "24";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "22";
                        textBoxArray[4, 4].Text = "21";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[2, 0].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "3";
                        textBoxArray[0, 1].Text = "4";
                        textBoxArray[0, 2].Text = "5";
                        textBoxArray[0, 3].Text = "6";
                        textBoxArray[0, 4].Text = "7";
                        textBoxArray[1, 4].Text = "8";
                        textBoxArray[1, 3].Text = "9";
                        textBoxArray[1, 2].Text = "10";
                        textBoxArray[1, 1].Text = "11";
                        textBoxArray[1, 0].Text = "2";
                        textBoxArray[2, 1].Text = "12";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "14";
                        textBoxArray[2, 4].Text = "15";
                        textBoxArray[3, 4].Text = "16";
                        textBoxArray[3, 3].Text = "17";
                        textBoxArray[3, 2].Text = "18";
                        textBoxArray[3, 1].Text = "19";
                        textBoxArray[3, 0].Text = "20";
                        textBoxArray[4, 0].Text = "21";
                        textBoxArray[4, 1].Text = "22";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "24";
                        textBoxArray[4, 4].Text = "25";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[2, 1].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "4";
                        textBoxArray[0, 1].Text = "5";
                        textBoxArray[0, 2].Text = "6";
                        textBoxArray[0, 3].Text = "7";
                        textBoxArray[0, 4].Text = "8";
                        textBoxArray[1, 4].Text = "9";
                        textBoxArray[1, 3].Text = "10";
                        textBoxArray[1, 2].Text = "11";
                        textBoxArray[1, 1].Text = "12";
                        textBoxArray[1, 0].Text = "3";
                        textBoxArray[2, 0].Text = "2";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "14";
                        textBoxArray[2, 4].Text = "15";
                        textBoxArray[3, 4].Text = "16";
                        textBoxArray[3, 3].Text = "17";
                        textBoxArray[3, 2].Text = "18";
                        textBoxArray[3, 1].Text = "19";
                        textBoxArray[3, 0].Text = "20";
                        textBoxArray[4, 0].Text = "21";
                        textBoxArray[4, 1].Text = "22";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "24";
                        textBoxArray[4, 4].Text = "25";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[2, 3].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "8";
                        textBoxArray[0, 1].Text = "7";
                        textBoxArray[0, 2].Text = "6";
                        textBoxArray[0, 3].Text = "5";
                        textBoxArray[0, 4].Text = "4";
                        textBoxArray[1, 4].Text = "3";
                        textBoxArray[1, 3].Text = "12";
                        textBoxArray[1, 2].Text = "11";
                        textBoxArray[1, 1].Text = "10";
                        textBoxArray[1, 0].Text = "9";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 4].Text = "2";
                        textBoxArray[3, 4].Text = "20";
                        textBoxArray[3, 3].Text = "19";
                        textBoxArray[3, 2].Text = "18";
                        textBoxArray[3, 1].Text = "17";
                        textBoxArray[3, 0].Text = "16";
                        textBoxArray[4, 0].Text = "25";
                        textBoxArray[4, 1].Text = "24";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "22";
                        textBoxArray[4, 4].Text = "21";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[2, 4].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "7";
                        textBoxArray[0, 1].Text = "6";
                        textBoxArray[0, 2].Text = "5";
                        textBoxArray[0, 3].Text = "4";
                        textBoxArray[0, 4].Text = "3";
                        textBoxArray[1, 4].Text = "2";
                        textBoxArray[1, 3].Text = "11";
                        textBoxArray[1, 2].Text = "10";
                        textBoxArray[1, 1].Text = "9";
                        textBoxArray[1, 0].Text = "8";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[3, 4].Text = "20";
                        textBoxArray[3, 3].Text = "19";
                        textBoxArray[3, 2].Text = "18";
                        textBoxArray[3, 1].Text = "17";
                        textBoxArray[3, 0].Text = "16";
                        textBoxArray[4, 0].Text = "25";
                        textBoxArray[4, 1].Text = "24";
                        textBoxArray[4, 2].Text = "23";
                        textBoxArray[4, 3].Text = "22";
                        textBoxArray[4, 4].Text = "21";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[3, 0].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "21";
                        textBoxArray[0, 1].Text = "22";
                        textBoxArray[0, 2].Text = "23";
                        textBoxArray[0, 3].Text = "24";
                        textBoxArray[0, 4].Text = "25";
                        textBoxArray[1, 4].Text = "16";
                        textBoxArray[1, 3].Text = "17";
                        textBoxArray[1, 2].Text = "18";
                        textBoxArray[1, 1].Text = "19";
                        textBoxArray[1, 0].Text = "20";
                        textBoxArray[2, 0].Text = "11";
                        textBoxArray[2, 1].Text = "12";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "14";
                        textBoxArray[2, 4].Text = "15";
                        textBoxArray[3, 4].Text = "7";
                        textBoxArray[3, 3].Text = "8";
                        textBoxArray[3, 2].Text = "9";
                        textBoxArray[3, 1].Text = "10";                      
                        textBoxArray[4, 0].Text = "2";
                        textBoxArray[4, 1].Text = "3";
                        textBoxArray[4, 2].Text = "4";
                        textBoxArray[4, 3].Text = "5";
                        textBoxArray[4, 4].Text = "6";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[3, 1].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "21";
                        textBoxArray[0, 1].Text = "22";
                        textBoxArray[0, 2].Text = "23";
                        textBoxArray[0, 3].Text = "24";
                        textBoxArray[0, 4].Text = "25";
                        textBoxArray[1, 4].Text = "16";
                        textBoxArray[1, 3].Text = "17";
                        textBoxArray[1, 2].Text = "18";
                        textBoxArray[1, 1].Text = "19";
                        textBoxArray[1, 0].Text = "20";
                        textBoxArray[2, 0].Text = "11";
                        textBoxArray[2, 1].Text = "12";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "14";
                        textBoxArray[2, 4].Text = "15";
                        textBoxArray[3, 4].Text = "4";
                        textBoxArray[3, 3].Text = "3";
                        textBoxArray[3, 2].Text = "2";
                        textBoxArray[3, 0].Text = "10";
                        textBoxArray[4, 0].Text = "9";
                        textBoxArray[4, 1].Text = "8";
                        textBoxArray[4, 2].Text = "7";
                        textBoxArray[4, 3].Text = "6";
                        textBoxArray[4, 4].Text = "5";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[3, 2].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "25";
                        textBoxArray[0, 1].Text = "24";
                        textBoxArray[0, 2].Text = "23";
                        textBoxArray[0, 3].Text = "22";
                        textBoxArray[0, 4].Text = "21";
                        textBoxArray[1, 4].Text = "20";
                        textBoxArray[1, 3].Text = "19";
                        textBoxArray[1, 2].Text = "18";
                        textBoxArray[1, 1].Text = "17";
                        textBoxArray[1, 0].Text = "16";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[2, 4].Text = "11";
                        textBoxArray[3, 4].Text = "9";
                        textBoxArray[3, 3].Text = "10";
                        textBoxArray[3, 1].Text = "2";
                        textBoxArray[3, 0].Text = "3";
                        textBoxArray[4, 0].Text = "4";
                        textBoxArray[4, 1].Text = "5";
                        textBoxArray[4, 2].Text = "6";
                        textBoxArray[4, 3].Text = "7";
                        textBoxArray[4, 4].Text = "8";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[3, 4].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "25";
                        textBoxArray[0, 1].Text = "24";
                        textBoxArray[0, 2].Text = "23";
                        textBoxArray[0, 3].Text = "22";
                        textBoxArray[0, 4].Text = "21";
                        textBoxArray[1, 4].Text = "20";
                        textBoxArray[1, 3].Text = "19";
                        textBoxArray[1, 2].Text = "18";
                        textBoxArray[1, 1].Text = "17";
                        textBoxArray[1, 0].Text = "16";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[2, 4].Text = "11";               
                        textBoxArray[3, 3].Text = "10";
                        textBoxArray[3, 2].Text = "9";
                        textBoxArray[3, 1].Text = "8";
                        textBoxArray[3, 0].Text = "7";
                        textBoxArray[4, 0].Text = "6";
                        textBoxArray[4, 1].Text = "5";
                        textBoxArray[4, 2].Text = "4";
                        textBoxArray[4, 3].Text = "3";
                        textBoxArray[4, 4].Text = "2";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[4, 0].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "25";
                        textBoxArray[0, 1].Text = "24";
                        textBoxArray[0, 2].Text = "23";
                        textBoxArray[0, 3].Text = "22";
                        textBoxArray[0, 4].Text = "21";
                        textBoxArray[1, 4].Text = "20";
                        textBoxArray[1, 3].Text = "19";
                        textBoxArray[1, 2].Text = "18";
                        textBoxArray[1, 1].Text = "17";
                        textBoxArray[1, 0].Text = "16";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[2, 4].Text = "11";
                        textBoxArray[3, 4].Text = "6";
                        textBoxArray[3, 3].Text = "7";
                        textBoxArray[3, 2].Text = "8";
                        textBoxArray[3, 1].Text = "9";
                        textBoxArray[3, 0].Text = "10";      
                        textBoxArray[4, 1].Text = "2";
                        textBoxArray[4, 2].Text = "3";
                        textBoxArray[4, 3].Text = "4";
                        textBoxArray[4, 4].Text = "5";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[4, 1].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "25";
                        textBoxArray[0, 1].Text = "24";
                        textBoxArray[0, 2].Text = "23";
                        textBoxArray[0, 3].Text = "22";
                        textBoxArray[0, 4].Text = "21";
                        textBoxArray[1, 4].Text = "20";
                        textBoxArray[1, 3].Text = "19";
                        textBoxArray[1, 2].Text = "18";
                        textBoxArray[1, 1].Text = "17";
                        textBoxArray[1, 0].Text = "16";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[2, 4].Text = "11";
                        textBoxArray[3, 4].Text = "10";
                        textBoxArray[3, 3].Text = "7";
                        textBoxArray[3, 2].Text = "5";
                        textBoxArray[3, 1].Text = "4";
                        textBoxArray[3, 0].Text = "3";
                        textBoxArray[4, 0].Text = "2";
                        textBoxArray[4, 2].Text = "6";
                        textBoxArray[4, 3].Text = "8";
                        textBoxArray[4, 4].Text = "9";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[4, 2].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "25";
                        textBoxArray[0, 1].Text = "24";
                        textBoxArray[0, 2].Text = "23";
                        textBoxArray[0, 3].Text = "22";
                        textBoxArray[0, 4].Text = "21";
                        textBoxArray[1, 4].Text = "20";
                        textBoxArray[1, 3].Text = "19";
                        textBoxArray[1, 2].Text = "18";
                        textBoxArray[1, 1].Text = "17";
                        textBoxArray[1, 0].Text = "16";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[2, 4].Text = "11";
                        textBoxArray[3, 4].Text = "10";
                        textBoxArray[3, 3].Text = "7";
                        textBoxArray[3, 2].Text = "6";
                        textBoxArray[3, 1].Text = "5";
                        textBoxArray[3, 0].Text = "4";
                        textBoxArray[4, 0].Text = "3";
                        textBoxArray[4, 1].Text = "2";
                        textBoxArray[4, 3].Text = "8";
                        textBoxArray[4, 4].Text = "9";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                    if (textBoxArray[4, 3].Text.Equals("1"))
                    {
                        textBoxArray[0, 0].Text = "25";
                        textBoxArray[0, 1].Text = "24";
                        textBoxArray[0, 2].Text = "23";
                        textBoxArray[0, 3].Text = "22";
                        textBoxArray[0, 4].Text = "21";
                        textBoxArray[1, 4].Text = "20";
                        textBoxArray[1, 3].Text = "19";
                        textBoxArray[1, 2].Text = "18";
                        textBoxArray[1, 1].Text = "17";
                        textBoxArray[1, 0].Text = "16";
                        textBoxArray[2, 0].Text = "15";
                        textBoxArray[2, 1].Text = "14";
                        textBoxArray[2, 2].Text = "13";
                        textBoxArray[2, 3].Text = "12";
                        textBoxArray[2, 4].Text = "11";
                        textBoxArray[3, 4].Text = "10";
                        textBoxArray[3, 3].Text = "8";
                        textBoxArray[3, 2].Text = "7";
                        textBoxArray[3, 1].Text = "6";
                        textBoxArray[3, 0].Text = "5";
                        textBoxArray[4, 0].Text = "4";
                        textBoxArray[4, 1].Text = "3";
                        textBoxArray[4, 2].Text = "2";
                        textBoxArray[4, 4].Text = "9";
                        for (int k = 0; k < 5; k++)
                        {
                            for (int z = 0; z < 5; z++)
                            {
                                textBoxArray[k, z].ReadOnly = true;
                            }
                        }
                    }
                }
            }
        }

        private void resumeTimer_pause(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
