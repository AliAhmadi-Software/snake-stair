using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace snake_stair
{
    public partial class FrmGame : Form
    {
        int numofdice = 0;
        int turn = 1;
        //public int winner = 0;
        bool start1 = false;
        bool start2 = false;
        bool start3 = false;
        bool start4 = false;
        bool start5 = false;
        int cell1 = 0;
        int cell2 = 0;
        int cell3 = 0;
        int cell4 = 0;
        int cell5 = 0;
        public FrmGame()
        {
            InitializeComponent();
        }
        private List<PictureBox> MarbleTable = new List<PictureBox>();
        private void Dice_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"Music\dice.wav");
            sound.Play();
            numofdice = GameCls.Dice();
            switch (numofdice)
            {
                case 1:
                    Pic_Dice_1.Visible = true;
                    Pic_Dice_2.Visible = false;
                    Pic_Dice_3.Visible = false;
                    Pic_Dice_4.Visible = false;
                    Pic_Dice_5.Visible = false;
                    Pic_Dice_6.Visible = false;
                    break;
                case 2:
                    Pic_Dice_2.Visible = true;
                    Pic_Dice_1.Visible = false;
                    Pic_Dice_3.Visible = false;
                    Pic_Dice_4.Visible = false;
                    Pic_Dice_5.Visible = false;
                    Pic_Dice_6.Visible = false;
                    break;
                case 3:
                    Pic_Dice_3.Visible = true;
                    Pic_Dice_1.Visible = false;
                    Pic_Dice_2.Visible = false;
                    Pic_Dice_4.Visible = false;
                    Pic_Dice_5.Visible = false;
                    Pic_Dice_6.Visible = false;
                    break;
                case 4:
                    Pic_Dice_4.Visible = true;
                    Pic_Dice_1.Visible = false;
                    Pic_Dice_2.Visible = false;
                    Pic_Dice_3.Visible = false;
                    Pic_Dice_5.Visible = false;
                    Pic_Dice_6.Visible = false;
                    break;
                case 5:
                    Pic_Dice_5.Visible = true;
                    Pic_Dice_1.Visible = false;
                    Pic_Dice_2.Visible = false;
                    Pic_Dice_3.Visible = false;
                    Pic_Dice_4.Visible = false;
                    Pic_Dice_6.Visible = false;
                    break;
                case 6:
                    Pic_Dice_6.Visible = true;
                    Pic_Dice_1.Visible = false;
                    Pic_Dice_2.Visible = false;
                    Pic_Dice_3.Visible = false;
                    Pic_Dice_4.Visible = false;
                    Pic_Dice_5.Visible = false;
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
            //////////////////////////////////////////
            if (turn == 1)//****************player 1
            {
                if (start1 != true)//game hasnt started
                {
                    CheckStart(numofdice,turn);
                }
                else//game has start
                {
                    Moves(numofdice, 1);
                }

            }
            else if (turn == 2)//********************player 2
            {
                if (start2 != true)//game hasnt started
                {
                    CheckStart(numofdice, turn);
                }
                else//game has start
                {
                    Moves(numofdice, 2);
                    
                }
            }
            else if (turn == 3)//********************player 3
            {
                if (start3 != true)//game hasnt started
                {
                    CheckStart(numofdice, turn);
                }
                else//game has start
                {
                    Moves(numofdice, 3);
                   
                }
            }
            else if (turn == 4)//********************player 4
            {
                if (start4 != true)//game hasnt started
                {
                    CheckStart(numofdice, turn);
                }
                else//game has start
                {
                    Moves(numofdice, 4);
                    
                }
            }
            else if (turn == 5)//********************player 5
            {
                if (start5 != true)//game hasnt started
                {
                    CheckStart(numofdice, turn);
                }
                else//game has start
                {
                    Moves(numofdice, 5);
                }
            }

            CheckWin();
            turn = GameCls.Turn(int.Parse(lblUseNum.Text));//Set Whose Turn Is It
            if (turn == 1)
                lblTurnUser.Text = "User[1] " + " " + lblnameuser1.Text + " " + " Your Turn!";
            else if(turn == 2)
                lblTurnUser.Text = "User[2] " + " " + lblnameuser2.Text + " " + " Your Turn!";
            else if (turn == 3)
                lblTurnUser.Text = "User[3] " + " " + lblnameuser3.Text + " " + " Your Turn!";
            else if (turn == 4)
                lblTurnUser.Text = "User[4] " + " " + lblnameuser4.Text + " " + " Your Turn!";
            else
                lblTurnUser.Text = "User[5] " + " " + lblnameuser5.Text + " " + " Your Turn!";
                
            
        }
        public void CheckStart(int dicenumber, int Turn)
        {
            if (dicenumber == 6)
            {
                if (Turn == 1)
                {
                    start1 = true;
                    MessageBox.Show("User[1]" + lblnameuser1.Text + "Login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pic1.ImageLocation = @"png-prj-snacke-ladders\Red_Marble.jpg";
                    cell1 = 1;
                }
                else if (Turn == 2)
                {
                    start2 = true;
                    MessageBox.Show("User[2]" + lblnameuser2.Text + "Login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pic1.ImageLocation = @"png-prj-snacke-ladders\Blue_Marble.jpg";
                    cell2 = 1;
                }

                else if (Turn == 3)
                {
                    start3 = true;
                    MessageBox.Show("User[3]" + lblnameuser3.Text + "Login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pic1.ImageLocation = @"png-prj-snacke-ladders\Orange_Marble.jpg";
                    cell3 = 1;
                }
                else if (Turn == 4)
                {
                    start4 = true;
                    MessageBox.Show("User[4]" + lblnameuser4.Text + "Login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pic1.ImageLocation = @"png-prj-snacke-ladders\Yellow_Marble.jpg";
                    cell4 = 1;
                }

                else
                {
                    start5 = true;
                    MessageBox.Show("User[5]" + lblnameuser5.Text + "Login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pic1.ImageLocation = @"png-prj-snacke-ladders\Green_Marble.jpg";
                    cell5 = 1;
                }
                //**************//
            }
            else
            {
                if (Turn == 1)
                    MessageBox.Show("User[1]" + lblnameuser1.Text + ", You need 6 to login!", "Dice Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (Turn == 2)
                    MessageBox.Show("User[2]" + lblnameuser2.Text + ", You need 6 to login!", "Dice Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (Turn == 3)
                    MessageBox.Show("User[3]" + lblnameuser3.Text + ", You need 6 to login!", "Dice Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (Turn == 4)
                    MessageBox.Show("User[4]" + lblnameuser4.Text + ", You need 6 to login!", "Dice Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("User[5]" + lblnameuser5.Text + ", You need 6 to login!", "Dice Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Moves(int dice, int player)
        {
            if (player == 1)
            {
                if (cell1 - 1 >= 0 && cell1 + dice - 1 < 100)
                {
                    if (cell1 + dice == cell2)//check if the cell is empty//Table[cell1 + dice ].Image == Image.FromFile(@"player\pl2.jpg")
                    {
                        MessageBox.Show("There Was Player"+ " " + lblnameuser2.Text + " " +"In This Home Which you Kick Him Out From Game!","Kick Out",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        start2 = false;
                        cell2 = 0;
                    }
                    else if (cell1 + dice == cell3)
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser3.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start3 = false;
                        cell3 = 0;
                    }
                    else if (cell1 + dice == cell4)
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser4.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start4 = false;
                        cell4 = 0;
                    }
                    else if(cell1 + dice == cell5)
                    {
                        MessageBox.Show("There Was Player"+ " " + lblnameuser5.Text + " " +"In This Home Which you Kick Him Out From Game!","Kick Out",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        start5 = false;
                        cell5 = 0;
                    }
                    if (cell1 + dice <= 100)
                        MarbleTable[cell1 - 1].Image = null;
                }

                cell1 += dice;
                SetPlace(cell1, 1,lbllevel.Text);

                if (cell1 <= 100)
                    MarbleTable[cell1 - 1].Image = Image.FromFile(@"png-prj-snacke-ladders\Red_Marble.jpg");
                else
                {
                    MessageBox.Show("You are not allow to move now !!","Not Allow",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cell1 -= dice;
                }
                //if (dice == 6)
                //{
                //    //MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Have Price!", "Price :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    //lblTurnUser.Text = "User[1] " + " " + lblnameuser1.Text + " " + " Your Turn!";
                //    //Moves(6 , 1);
                //}

            }
            else if (player == 2)
            {
                if (cell2 - 1 >= 0 && cell2 + dice - 1 < 100)
                {
                    if (cell2 + dice == cell1)//check if the cell is empty//Table[cell1 + dice ].Image == Image.FromFile(@"player\pl2.jpg")
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser1.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start1 = false;
                        cell1 = 0;
                    }
                    else if (cell2 + dice == cell3)
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser3.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start3 = false;
                        cell3 = 0;
                    }
                    else if (cell2 + dice == cell4)
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser4.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start4 = false;
                        cell4 = 0;
                    }
                    else if (cell2 + dice == cell5)
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser5.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start5 = false;
                        cell5 = 0;
                    }
                    if (cell2 + dice <= 100)
                        MarbleTable[cell2 - 1].Image = null;
                }

                cell2 += dice;
                SetPlace(cell2, 2,lbllevel.Text);

                if (cell2 <= 100)
                    MarbleTable[cell2 - 1].Image = Image.FromFile(@"png-prj-snacke-ladders\Blue_Marble.jpg");
                else
                {
                    MessageBox.Show("You are not allow to move now !!", "Not Allow", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cell2 -= dice;
                }
                //if (dice == 6)
                //{
                //    //MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Have Price!", "Price :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    //lblTurnUser.Text = "User[2] " + " " + lblnameuser2.Text + " " + " Your Turn!";
                //    //Moves(6 , 2);
                //}
            }
            else if (player == 3)
            {
                if (cell3 - 1 >= 0 && cell3 + dice - 1 < 100)
                {
                    if (cell3 + dice == cell1)//check if the cell is empty//Table[cell1 + dice ].Image == Image.FromFile(@"player\pl2.jpg")
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser1.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start1 = false;
                        cell1 = 0;
                    }
                    else if (cell3 + dice == cell2)
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser2.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start2 = false;
                        cell2 = 0;
                    }
                    else if (cell3 + dice == cell4)
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser4.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start4 = false;
                        cell4 = 0;
                    }
                    else if (cell3 + dice == cell5)
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser5.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start5 = false;
                        cell5 = 0;
                    }
                    if (cell3 + dice <= 100)
                        MarbleTable[cell3 - 1].Image = null;
                }

                cell3 += dice;
                SetPlace(cell3, 3, lbllevel.Text);

                if (cell3 <= 100)
                    MarbleTable[cell3 - 1].Image = Image.FromFile(@"png-prj-snacke-ladders\Orange_Marble.jpg");
                else
                {
                    MessageBox.Show("You are not allow to move now !!", "Not Allow", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cell3 -= dice;
                }
                //if (dice == 6)
                //{
                //    //MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Have Price!", "Price :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    //lblTurnUser.Text = "User[3] " + " " + lblnameuser3.Text + " " + " Your Turn!";
                //    //Moves(6 , 3);
                //}
            }
            else if (player == 4)
            {
                if (cell4 - 1 >= 0 && cell4 + dice - 1 < 100)
                {
                    if (cell4 + dice == cell1)//check if the cell is empty//Table[cell1 + dice ].Image == Image.FromFile(@"player\pl2.jpg")
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser1.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start1 = false;
                        cell1 = 0;
                    }
                    else if (cell4 + dice == cell2)
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser2.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start2 = false;
                        cell2 = 0;
                    }
                    else if (cell4 + dice == cell3)
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser3.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start3 = false;
                        cell3 = 0;
                    }
                    else if (cell4 + dice == cell5)
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser5.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start5 = false;
                        cell5 = 0;
                    }
                    if (cell4 + dice <= 100)
                        MarbleTable[cell4 - 1].Image = null;
                }

                cell4 += dice;
                SetPlace(cell4, 4, lbllevel.Text);

                if (cell4 <= 100)
                    MarbleTable[cell4 - 1].Image = Image.FromFile(@"png-prj-snacke-ladders\Yellow_Marble.jpg");
                else
                {
                    MessageBox.Show("You are not allow to move now !!", "Not Allow", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cell4 -= dice;
                }
                //if (dice == 6)
                //{
                //    //MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Have Price!", "Price :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    //lblTurnUser.Text = "User[4] " + " " + lblnameuser4.Text + " " + " Your Turn!";
                //    //Moves(6 , 3);
                //}
            }
            else if (player == 5)
            {
                if (cell5 - 1 >= 0 && cell5 + dice - 1 < 100)
                {
                    if (cell5 + dice == cell1)//check if the cell is empty//Table[cell1 + dice ].Image == Image.FromFile(@"player\pl2.jpg")
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser1.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start1 = false;
                        cell1 = 0;
                    }
                    else if (cell5 + dice == cell2)
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser2.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start2 = false;
                        cell2 = 0;
                    }
                    else if (cell5 + dice == cell3)
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser3.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start3 = false;
                        cell3 = 0;
                    }
                    else if (cell5 + dice == cell4)
                    {
                        MessageBox.Show("There Was Player" + " " + lblnameuser4.Text + " " + "In This Home Which you Kick Him Out From Game!", "Kick Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        start4 = false;
                        cell4 = 0;
                    }
                    if (cell5 + dice <= 100)
                        MarbleTable[cell5 - 1].Image = null;
                }

                cell5 += dice;
                SetPlace(cell5, 5, lbllevel.Text);

                if (cell5 <= 100)
                    MarbleTable[cell5 - 1].Image = Image.FromFile(@"png-prj-snacke-ladders\Green_Marble.jpg");
                else
                {
                    MessageBox.Show("You are not allow to move now !!", "Not Allow", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cell5 -= dice;
                }
                //if (dice == 6)
                //{
                //    //MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Have Price!", "Price :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    //lblTurnUser.Text = "User[5] " + " " + lblnameuser5.Text + " " + " Your Turn!";
                //    ////Moves(6 , 5);
                //}
            }
        }
        public void SetPlace(int cell, int Pl, string level)
        {
            if (level == "Easy")
            {
                switch (cell)
                {
                    case 2:
                        if (Pl == 1)
                        {
                            cell1 = 23;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 23!","Moved up :)",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else if(Pl == 2)
                        {
                            cell2 = 23;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 23!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 23;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 23!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 23;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 23!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 23;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 23!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 23"
                        break;
                    case 6:
                        if (Pl == 1)
                        {
                            cell1 = 25;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 25!","Moved up :)",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else if(Pl == 2)
                        {
                            cell2 = 25;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 25!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 25;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 25!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 25;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 25!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 25;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 25!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 25"
                        break;
                    case 30:
                        if (Pl == 1)
                        {
                            cell1 = 34;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 34!","Moved up :)",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else if(Pl == 2)
                        {
                            cell2 = 34;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 34!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 34;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 34!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 34;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 34!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 34;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 34!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 34"
                        break;
                    case 43:
                        if (Pl == 1)
                        {
                            cell1 = 62;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if(Pl == 2)
                        {
                            cell2 = 62;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 62;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 62;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 62;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 62"
                        break;
                    case 49:
                        if (Pl == 1)
                        {
                            cell1 = 66;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if(Pl == 2)
                        {
                            cell2 = 66;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 66;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 66;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 66;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 66"
                        break;
                    case 54:
                        if (Pl == 1)
                        {
                            cell1 = 72;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 72!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if(Pl == 2)
                        {
                            cell2 = 72;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 72!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 72;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 72!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 72;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 72!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 72;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 72!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 72"
                        break;
                    case 77:
                        if (Pl == 1)
                        {
                            cell1 = 98;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 98!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 98;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 98!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 98;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 98!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 98;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 98!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 98;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 98!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 98"
                        break;
                    case 45:
                        if (Pl == 1)
                        {
                            cell1 = 13;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 13;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 13;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 13;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 13;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 13"
                        break;
                    case 86:
                        if (Pl == 1)
                        {
                            cell1 = 57;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 57;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 57;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 57;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 57;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 57"
                        break;
                    case 60:
                        if (Pl == 1)
                        {
                            cell1 = 38;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 38;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 38;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 38;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 38;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 38"
                        break;
                    default:
                        break;
                }
            }
            if (level == "Medium")
            {
                switch (cell)
                {
                    case 2:
                        if (Pl == 1)
                        {
                            cell1 = 23;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 23!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 23;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 23!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 23;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 23!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 23;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 23!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 23;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 23!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 23"
                        break;
                    case 30:
                        if (Pl == 1)
                        {
                            cell1 = 34;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 34!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 34;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 34!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 34;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 34!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 34;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 34!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 34;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 34!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 34"
                        break;
                    case 43:
                        if (Pl == 1)
                        {
                            cell1 = 62;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 62;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 62;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 62;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 62;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 62"
                        break;
                    case 49:
                        if (Pl == 1)
                        {
                            cell1 = 66;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 66;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 66;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 66;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 66;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 66"
                        break;
                    case 77:
                        if (Pl == 1)
                        {
                            cell1 = 98;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 98!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 98;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 98!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 98;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 98!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 98;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 98!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 98;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 98!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 98"
                        break;
                    case 72:
                        if (Pl == 1)
                        {
                            cell1 = 54;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 54!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 54;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 54!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 54;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 54!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 54;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 54!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 54;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 54!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 54"
                        break;
                    case 36:
                        if (Pl == 1)
                        {
                            cell1 = 17;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 17!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 17;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 17!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 17;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 17!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 17;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 17!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 17;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 17!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 17"
                        break;
                    case 45:
                        if (Pl == 1)
                        {
                            cell1 = 13;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 13;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 13;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 13;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 13;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 13"
                        break;
                    case 86:
                        if (Pl == 1)
                        {
                            cell1 = 57;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 57;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 57;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 57;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 57;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 57"
                        break;
                    case 60:
                        if (Pl == 1)
                        {
                            cell1 = 38;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 38;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 38;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 38;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 38;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 38"
                        break;
                    default:
                        break;
                }
            }
            if (level == "Hard")
            {
                switch (cell)
                {
                    case 30:
                        if (Pl == 1)
                        {
                            cell1 = 34;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 34!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 34;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 34!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 34;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 34!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 34;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 34!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 34;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 34!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 34"
                        break;
                    case 43:
                        if (Pl == 1)
                        {
                            cell1 = 62;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 62;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 62;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 62;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 62;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 62!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 62"
                        break;
                    case 49:
                        if (Pl == 1)
                        {
                            cell1 = 66;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 66;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 66;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 66;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 66;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved up to 66!", "Moved up :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved up to 66"
                        break;
                    case 23:
                        if (Pl == 1)
                        {
                            cell1 = 2;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 2!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 2;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 2!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 2;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 2!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 2;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 2!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 2;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 2!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 2"
                        break;
                    case 98:
                        if (Pl == 1)
                        {
                            cell1 = 77;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 77!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 77;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 77!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 77;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 77!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 77;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 77!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 77;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 77!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 77"
                        break;
                    case 72:
                        if (Pl == 1)
                        {
                            cell1 = 54;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 54!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 54;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 54!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 54;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 54!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 54;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 54!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 54;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 54!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 54"
                        break;
                    case 36:
                        if (Pl == 1)
                        {
                            cell1 = 17;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 17!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 17;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 17!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 17;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 17!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 17;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 17!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 17;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 17!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 17"
                        break;
                    case 45:
                        if (Pl == 1)
                        {
                            cell1 = 13;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 13;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 13;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 13;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 13;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 13!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 13"
                        break;
                    case 86:
                        if (Pl == 1)
                        {
                            cell1 = 57;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 57;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 57;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 57;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 57;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 57!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 57"
                        break;
                    case 60:
                        if (Pl == 1)
                        {
                            cell1 = 38;
                            MessageBox.Show("User[1]" + " " + lblnameuser1.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 2)
                        {
                            cell2 = 38;
                            MessageBox.Show("User[2]" + " " + lblnameuser2.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 3)
                        {
                            cell3 = 38;
                            MessageBox.Show("User[3]" + " " + lblnameuser3.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Pl == 4)
                        {
                            cell4 = 38;
                            MessageBox.Show("User[4]" + " " + lblnameuser4.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cell5 = 38;
                            MessageBox.Show("User[5]" + " " + lblnameuser5.Text + " " + "You Moved down to 38!", "Moved down :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //linfo = > "You moved down to 38"
                        break;
                    default:
                        break;
                }
            }
        }
        public void CheckWin()
        {
            FrmWinner fwin = new FrmWinner();
            if (cell1 == 100)
            {
                //winner = 1;
                fwin.LblWinnerUSer.Text = "User[1]" + " " + lblnameuser1.Text + " " + "Win The Game!";
                fwin.ShowDialog();
            }
            else if (cell2 == 100)
            {
                //winner = 2;
                fwin.LblWinnerUSer.Text = "User[2]" + " " + lblnameuser1.Text + " " + "Win The Game!";
                fwin.ShowDialog();
            }
            else if (cell3 == 100)
            {
                //winner = 3;
                fwin.LblWinnerUSer.Text = "User[3]" + " " + lblnameuser1.Text + " " + "Win The Game!";
                fwin.ShowDialog();
            }
            else if (cell4 == 100)
            {
                //winner = 4;
                fwin.LblWinnerUSer.Text = "User[4]" + " " + lblnameuser1.Text + " " + "Win The Game!";
                fwin.ShowDialog();
            }
            else if (cell5 == 100)
            {
                //winner = 5;
                fwin.LblWinnerUSer.Text = "User[5]" + " " + lblnameuser1.Text + " " + "Win The Game!";
                fwin.ShowDialog();
            }
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            lblTurnUser.Text = "User[1]" + lblnameuser1.Text + "Your Turn!";
            int levelnum = GameCls.SetLevel(lbllevel.Text);
            if (levelnum == 1)
            {
                Pic_Ladder_2.Visible = true;
                Pic_Ladder_6.Visible = true;
                Pic_Ladder_30.Visible = true;
                Pic_Ladder_43.Visible = true;
                Pic_Ladder_49.Visible = true;
                Pic_Ladder_54.Visible = true;
                Pic_Ladder_77.Visible = true;
                //******************************//
                H45.BackColor = Color.Teal;
                H60.BackColor = Color.Teal;
                H86.BackColor = Color.Teal;
            }
            else if (levelnum == 2)
            {
                Pic_Ladder_2.Visible = true;
                Pic_Ladder_30.Visible = true;
                Pic_Ladder_43.Visible = true;
                Pic_Ladder_49.Visible = true;
                Pic_Ladder_77.Visible = true;
                //******************************//
                H36.BackColor = Color.Teal;
                H45.BackColor = Color.Teal;
                H60.BackColor = Color.Teal;
                H72.BackColor = Color.Teal;
                H86.BackColor = Color.Teal;
            }
            else if (levelnum == 3)
            {
                Pic_Ladder_30.Visible = true;
                Pic_Ladder_43.Visible = true;
                Pic_Ladder_49.Visible = true;
                //******************************//
                H23.BackColor = Color.Teal;
                H36.BackColor = Color.Teal;
                H45.BackColor = Color.Teal;
                H60.BackColor = Color.Teal;
                H72.BackColor = Color.Teal;
                H86.BackColor = Color.Teal;
                H98.BackColor = Color.Teal;
            }
            else
            {
                MessageBox.Show("There is something Wrong in Level Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (lblUseNum.Text=="2")
            {
                Pic_Marble_1.Visible = true;
                Pic_Marble_2.Visible = true;
            }
            else if (lblUseNum.Text=="3")
            {
                Pic_Marble_1.Visible = true;
                Pic_Marble_2.Visible = true;
                Pic_Marble_3.Visible = true;
            }
            else if (lblUseNum.Text == "4")
            {
                Pic_Marble_1.Visible = true;
                Pic_Marble_2.Visible = true;
                Pic_Marble_3.Visible = true;
                Pic_Marble_4.Visible = true;
            }
            else if (lblUseNum.Text == "5")
            {
                Pic_Marble_1.Visible = true;
                Pic_Marble_2.Visible = true;
                Pic_Marble_3.Visible = true;
                Pic_Marble_4.Visible = true;
                Pic_Marble_5.Visible = true;
            }
            else
            {
                MessageBox.Show("There is something Wrong in User Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MarbleTable.Add(pic1);
            MarbleTable.Add(pic2);
            MarbleTable.Add(pic3);
            MarbleTable.Add(pic4);
            MarbleTable.Add(pic5);
            MarbleTable.Add(pic6);
            MarbleTable.Add(pic7);
            MarbleTable.Add(pic8);
            MarbleTable.Add(pic9);
            MarbleTable.Add(pic10);
            MarbleTable.Add(pic11);
            MarbleTable.Add(pic12);
            MarbleTable.Add(pic13);
            MarbleTable.Add(pic14);
            MarbleTable.Add(pic15);
            MarbleTable.Add(pic16);
            MarbleTable.Add(pic17);
            MarbleTable.Add(pic18);
            MarbleTable.Add(pic19);
            MarbleTable.Add(pic20);
            MarbleTable.Add(pic21);
            MarbleTable.Add(pic22);
            MarbleTable.Add(pic23);
            MarbleTable.Add(pic24);
            MarbleTable.Add(pic25);
            MarbleTable.Add(pic26);
            MarbleTable.Add(pic27);
            MarbleTable.Add(pic28);
            MarbleTable.Add(pic29);
            MarbleTable.Add(pic30);
            MarbleTable.Add(pic31);
            MarbleTable.Add(pic32);
            MarbleTable.Add(pic33);
            MarbleTable.Add(pic34);
            MarbleTable.Add(pic35);
            MarbleTable.Add(pic36);
            MarbleTable.Add(pic37);
            MarbleTable.Add(pic38);
            MarbleTable.Add(pic39);
            MarbleTable.Add(pic40);
            MarbleTable.Add(pic41);
            MarbleTable.Add(pic42);
            MarbleTable.Add(pic43);
            MarbleTable.Add(pic44);
            MarbleTable.Add(pic45);
            MarbleTable.Add(pic46);
            MarbleTable.Add(pic47);
            MarbleTable.Add(pic48);
            MarbleTable.Add(pic49);
            MarbleTable.Add(pic50);
            MarbleTable.Add(pic51);
            MarbleTable.Add(pic52);
            MarbleTable.Add(pic53);
            MarbleTable.Add(pic54);
            MarbleTable.Add(pic55);
            MarbleTable.Add(pic56);
            MarbleTable.Add(pic57);
            MarbleTable.Add(pic58);
            MarbleTable.Add(pic59);
            MarbleTable.Add(pic60);
            MarbleTable.Add(pic61);
            MarbleTable.Add(pic62);
            MarbleTable.Add(pic63);
            MarbleTable.Add(pic64);
            MarbleTable.Add(pic65);
            MarbleTable.Add(pic66);
            MarbleTable.Add(pic67);
            MarbleTable.Add(pic68);
            MarbleTable.Add(pic69);
            MarbleTable.Add(pic70);
            MarbleTable.Add(pic71);
            MarbleTable.Add(pic72);
            MarbleTable.Add(pic73);
            MarbleTable.Add(pic74);
            MarbleTable.Add(pic75);
            MarbleTable.Add(pic76);
            MarbleTable.Add(pic77);
            MarbleTable.Add(pic78);
            MarbleTable.Add(pic79);
            MarbleTable.Add(pic80);
            MarbleTable.Add(pic81);
            MarbleTable.Add(pic82);
            MarbleTable.Add(pic83);
            MarbleTable.Add(pic84);
            MarbleTable.Add(pic85);
            MarbleTable.Add(pic86);
            MarbleTable.Add(pic87);
            MarbleTable.Add(pic88);
            MarbleTable.Add(pic89);
            MarbleTable.Add(pic90);
            MarbleTable.Add(pic91);
            MarbleTable.Add(pic92);
            MarbleTable.Add(pic93);
            MarbleTable.Add(pic94);
            MarbleTable.Add(pic95);
            MarbleTable.Add(pic96);
            MarbleTable.Add(pic97);
            MarbleTable.Add(pic98);
            MarbleTable.Add(pic99);
            MarbleTable.Add(pic100);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
