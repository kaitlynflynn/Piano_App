﻿using System;
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

        /* Functionality for C note */ 
        private void button1_Click(object sender, EventArgs e)
        {   /* Console Note Sound */
            if (radioButton1.Checked)
            {
                Console.Beep(200, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for G note */
        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {   /* Console Note Sound */
                Console.Beep(450, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.G);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.G_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for A note */
        private void button6_Click(object sender, EventArgs e)
        {   /* Console Note Sound */
            if (radioButton1.Checked)
            {
                Console.Beep(500, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.A);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.A_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for Upper C note */
        private void button8_Click(object sender, EventArgs e)
        {   /* Console Note Sound */
            if (radioButton1.Checked)
            {
                Console.Beep(600, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C1);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for Upper D note */
        private void button9_Click(object sender, EventArgs e)
        {   /* Console Note Sound */
            if (radioButton1.Checked)
            {
                Console.Beep(650, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D1);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for Upper E note */
        private void button10_Click(object sender, EventArgs e)
        {   /* Console Note Sound */
            if (radioButton1.Checked)
            {
                Console.Beep(700, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.E1);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.E1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for D note */
        private void button2_Click(object sender, EventArgs e)
        {   /* Console Note Sound */
            if (radioButton1.Checked)
            {
                Console.Beep(250, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for E note */
        private void button3_Click(object sender, EventArgs e)
        {   /* Console Note Sound */
            if (radioButton1.Checked)
            {
                Console.Beep(350, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.E);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.E_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for F note */
        private void button4_Click(object sender, EventArgs e)
        {   /* Console Note Sound */
            if (radioButton1.Checked)
            {
                Console.Beep(400, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for B note */
        private void button7_Click(object sender, EventArgs e)
        {   /* Console Note Sound */
            if (radioButton1.Checked)
            {
                Console.Beep(550, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.B);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.B_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for Upper F note */
        private void button11_Click(object sender, EventArgs e)
        {   /* Console Note Sound */
            if (radioButton1.Checked)
            {
                Console.Beep(750, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F1);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for C# note */
        private void button1_Click_1(object sender, EventArgs e)
        {   /* Console Note Sound */
            if (radioButton1.Checked)
            {
                Console.Beep(800, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C_s);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Cq_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for D# note */
        private void button12_Click(object sender, EventArgs e)
        {   /* Console Note Sound */
            if (radioButton1.Checked)
            {
                Console.Beep(850, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D_s);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Dq_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for F# note */
        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(900, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F_s);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Fq_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for G# note */
        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(950, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.G_s);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Gq_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for Bb note */
        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(1000, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Bb);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Bb_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for C#1 note */
        private void button16_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(1050, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C_s1);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Cq1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        /* Functionality for D#1 note */
        private void button17_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(2000, 500);
            }
            /* Music Note Sound */
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D_s1);
                player.Load();
                player.PlaySync();
            }
            /* Steel Drum Sound */
            if (radioButton4.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Dq1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
