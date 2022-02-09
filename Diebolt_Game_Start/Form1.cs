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


namespace Diebolt_Game_Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gameStart_Click(object sender, EventArgs e)
        {
           



        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Balls
            
            //Giving new sound inputs
            SoundPlayer Beep = new SoundPlayer(Properties.Resources.Beep);
            SoundPlayer Error = new SoundPlayer(Properties.Resources.Error);

            Thread.Sleep(10);

            //Make button disappear
            startButton.Visible = false;

            //Game start countdown
            gameStarting.Text = "GAME STARTING: 5";
            Beep.Play();
            Refresh();
            Thread.Sleep(1000);
            
            gameStarting.Text = "GAME STARTING: 4";
            Beep.Play();
            Refresh();
            Thread.Sleep(1000);

            gameStarting.Text = "GAME STARTING: 3";
            Beep.Play();
            Refresh();
            Thread.Sleep(1000);

            gameStarting.Text = "GAME STARTING: 2";
            Beep.Play();
            Refresh();
            Thread.Sleep(50);

            gameStarting.Visible = false;

            //Error Screen
            Thread.Sleep(100);
            Error.PlayLooping();
            BackColor = Color.Blue;
            errorMessage.BackColor = Color.Blue;
            errorMessage.ForeColor = Color.White;


        }
    }
}
