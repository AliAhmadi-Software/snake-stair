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
    public partial class FrmStrat : Form
    {
        public FrmStrat()
        {
            InitializeComponent();
        }

        private void SetName_Click(object sender, EventArgs e)
        {
                if (PlayerNum.Value.ToString() == "2")
                {
                    BtnStart.Enabled = true;
                    txtNameP1.Enabled = true;
                    txtNameP2.Enabled = true;
                    PlayerNum.Enabled = false;
                }
                else if (PlayerNum.Value.ToString() == "3")
                {
                    BtnStart.Enabled = true;
                    txtNameP1.Enabled = true;
                    txtNameP2.Enabled = true;
                    txtNameP3.Enabled = true;
                    PlayerNum.Enabled = false;
                }
                else if (PlayerNum.Value.ToString() == "4")
                {
                    BtnStart.Enabled = true;
                    txtNameP1.Enabled = true;
                    txtNameP2.Enabled = true;
                    txtNameP3.Enabled = true;
                    txtNameP4.Enabled = true;
                    PlayerNum.Enabled = false;
                }
                else
                {
                    BtnStart.Enabled = true;
                    txtNameP1.Enabled = true;
                    txtNameP2.Enabled = true;
                    txtNameP3.Enabled = true;
                    txtNameP4.Enabled = true;
                    txtNameP5.Enabled = true;
                    PlayerNum.Enabled = false;
                }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (PlayerNum.Value.ToString() == "2" && txtNameP1.Text == "" && txtNameP2.Text == "")
            {
                MessageBox.Show("Please Set the Name of Player One & Two!","NameError",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (PlayerNum.Value.ToString() == "3" && txtNameP1.Text == "" && txtNameP2.Text == "" && txtNameP3.Text == "")
            {
                MessageBox.Show("Please Set the Name of Player One & Two & Three!", "NameError", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PlayerNum.Value.ToString() == "4" && txtNameP1.Text == "" && txtNameP2.Text == "" && txtNameP3.Text == "" && txtNameP4.Text == "")
            {
                MessageBox.Show("Please Set the Name of Player One & Two & Three!", "NameError", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PlayerNum.Value.ToString() == "5" && txtNameP1.Text == "" && txtNameP2.Text == "" && txtNameP3.Text == "" && txtNameP4.Text == "" && txtNameP5.Text == "")
            {
                MessageBox.Show("Please Set the Name of Player One & Two & Three!", "NameError", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmGame frmgame = new FrmGame();
                if (R_Easy.Checked==true)
                {
                    frmgame.lbllevel.Text = "Easy";
                }
                else if (R_Meduim.Checked == true)
                {
                    frmgame.lbllevel.Text = "Meduim";
                }
                else
                {
                    frmgame.lbllevel.Text = "Hard";
                }
                switch (PlayerNum.Value.ToString())
                {
                    case "2":
                        frmgame.lblUseNum.Text = "2";
                        break;
                    case "3":
                        frmgame.lblUseNum.Text = "3";
                        break;
                    case "4":
                        frmgame.lblUseNum.Text = "4";
                        break;
                    case "5":
                        frmgame.lblUseNum.Text = "5";
                        break;
                    default:
                        break;
                }
                frmgame.lblnameuser1.Text = txtNameP1.Text;
                frmgame.lblnameuser2.Text = txtNameP2.Text;
                if (txtNameP3.Text != "" && txtNameP4.Text == "" && txtNameP5.Text == "")
                {
                    frmgame.lblnameuser3.Visible = true;
                    frmgame.lblnameuser3.Text = txtNameP3.Text;
                }
                else if (txtNameP3.Text != "" && txtNameP4.Text != "" && txtNameP5.Text == "")
                {
                    frmgame.lblnameuser3.Visible = true;
                    frmgame.lblnameuser3.Text = txtNameP3.Text;
                    frmgame.lblnameuser4.Visible = true;
                    frmgame.lblnameuser4.Text = txtNameP4.Text;
                }
                else
                {
                    frmgame.lblnameuser3.Visible = true;
                    frmgame.lblnameuser3.Text = txtNameP3.Text;
                    frmgame.lblnameuser4.Visible = true;
                    frmgame.lblnameuser4.Text = txtNameP4.Text;
                    frmgame.lblnameuser5.Visible = true;
                    frmgame.lblnameuser5.Text = txtNameP5.Text;
                }
                frmgame.ShowDialog();
                this.Close();
            }
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSetAgain_Click(object sender, EventArgs e)
        {
            PlayerNum.Value = 2;
            PlayerNum.Enabled = true;
            SetName.Enabled = true;
            R_Easy.Checked = true;
            R_Meduim.Checked = true;
            R_Hard.Checked = true;
            txtNameP1.ResetText();
            txtNameP1.Enabled = false;
            txtNameP2.ResetText();
            txtNameP2.Enabled = false;
            txtNameP3.ResetText();
            txtNameP3.Enabled = false;
            txtNameP4.ResetText();
            txtNameP4.Enabled = false;
            txtNameP5.ResetText();
            txtNameP5.Enabled = false;
        }

        private void FrmStrat_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"Music\18Energy.wav");
            sound.Play();
        }
    }
}
