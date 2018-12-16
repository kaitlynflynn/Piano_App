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

namespace Piano_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(200, 500);
            }

            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C);
                player.Load();
                player.PlaySync();
            }

            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(250, 500);
            }

            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D);
                player.Load();
                player.PlaySync();
            }

            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(350, 500);
            }

            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.E);
                player.Load();
                player.PlaySync();
            }

            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.E_Drum);
                player.Load();
                player.PlaySync();
            }
        }
    }
}
