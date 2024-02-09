using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; 

namespace PlayGameCounter;
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameStartIn.Hide();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            SoundPlayer GameSound = new SoundPlayer(Properties.Resources.notifications_sound_127856);
            GameSound.Play();
            GameStartIn.Show();
            Play.Hide();
            GameStartIn.Text = "GameStartIn: 3";

            Refresh();
            Thread.Sleep(1000);
            GameSound.Stop();
            GameSound.Play();
            GameStartIn.Text = "GameStartIn: 2";

            Refresh();
            Thread.Sleep(1000);
            GameSound.Stop();
            GameSound.Play();
            GameStartIn.Text = "GameStartIn: 1";
            
            
            Refresh();
            Thread.Sleep(1000);
            GameSound.Stop();
            GameStartIn.Text = "Go";

            this.BackColor = Color.Green;
            GameStartIn.ForeColor = Color.Blue;



        }
    }
}
