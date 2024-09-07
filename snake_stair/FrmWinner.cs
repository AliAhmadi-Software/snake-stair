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
    public partial class FrmWinner : Form
    {
        public FrmWinner()
        {
            InitializeComponent();
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmWinner_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"Music\106.Joe-Satriani-Cataclysmic.wav");
            sound.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("با تشکر بسیار ویژه از آرمان سلحشور بابت ساخت اسلاید ها", "تشکر خاص", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
