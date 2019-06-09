using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRouletteProject
{
    public partial class Form3 : Form
    {
        Trig myTrig = new Trig();

        public Form3()
        {
            // Run on startup
            InitializeComponent();
            BeforeStart();
            // Takes away the close and minimise buttons on the Santa and Batman forms so the "Back to Menu" must be used
            this.ControlBox = false;
        }

        public void BeforeStart()
        {
            //Makes sure everything is reset and you can only load the bullet first and also the checkbox for fire on you is checked by default
            btnFire.Enabled = false;
            btnSpin.Enabled = false;
            btnPlayAgain.Enabled = false;
            checkFireYou.Checked = true;
            lblLives.Text = "2";
            lblShots.Text = "0";
            lblWinLoose.Text = "";
            lblWins.Text = "0";
            lblLosses.Text = "0";
        }

        public void btnFire_Click(object sender, EventArgs e)
        {
            // Play this when the FIRE button is pressed
            
            SoundPlayer sound = new SoundPlayer(Resource1.GunSound);
            sound.Play();

            // Record the number of shots and display
            myTrig.Shots = myTrig.ShotsFired();
            lblShots.Text = myTrig.Shots.ToString();

            // Won't let you select none of or all of the checkboxes, only one at a time
            CheckBoxes();

            // When the fire button is clicked with the Fire Away checkbox, it counts down, if you hit 0 you loose
            FireAttempts();

            // 'Fire At You' Checkbox - You Loose if you get shot
            EndGameCheck();

            // 'Fire Away' Checkbox - Can fire away from you only twice
            NearMiss();
        }

        public void btnSpin_Click(object sender, EventArgs e)
        {
            // So you must spin the chamber for using the Fire Button
            btnFire.Enabled = true;
            btnSpin.Enabled = true;

            // Random number generator for the spin chamber
            myTrig.RNDNumber = myTrig.RNDNumberGenerate();

            // TAKE THIS OUT WHEN GAME READY - Records the random spin number
            //lblSpinNum.Text = myTrig.RNDNumber.ToString();
        }

        public void CheckBoxes()
        {
            // If neither checkbox is checked, display error message and reset
            if (!checkFireAway.Checked && !checkFireYou.Checked)
            {
                MessageBox.Show("You can't shoot at nothing! Please select only one and try again.");
                checkFireYou.Enabled = true;
                checkFireAway.Enabled = true;
                Reset();
            }

            // If both checkboxes are checked, display error message and reset
            if (checkFireYou.Checked && checkFireAway.Checked)
            {
                MessageBox.Show("You can't fire in two places at once! Please select only one and try again.");
                checkFireYou.Enabled = true;
                checkFireAway.Enabled = true;
                Reset();
                myTrig.FireAwayNum++;
            }
        }

        public void FireAttempts()
        {
            // When the fire button is clicked with the Fire Away checkbox, it counts down, if you hit 0 you loose and record score
            if (checkFireAway.Checked)
            {
                myTrig.FireAwayNum--;
            }
            if (checkFireYou.Checked && lblShots.Text == myTrig.RNDNumber.ToString())
            {
                myTrig.LoseScore--;
                EndGameCheck();
            }
            if (myTrig.FireAwayNum == -1)
            {
                btnFire.Enabled = false;
                btnLoad.Enabled = false;
                btnSpin.Enabled = false;
                btnPlayAgain.Enabled = true;
                myTrig.MsgBoxBatman();
                myTrig.FireAwayNum = 0;
                myTrig.LoseScore++;
                lblLosses.Text = myTrig.LoseScore.ToString();
                Reset();
            }

            // Sets the number of lives/firing away to 2
            lblLives.Text = myTrig.FireAwayNum.ToString();
        }

        public void EndGameCheck()
        {
            // Fire At You Checkbox - You Loose if you get shot and will reset the game
            if (checkFireYou.Checked && lblShots.Text == myTrig.RNDNumber.ToString())
            {
                myTrig.Lose = myTrig.LoseMsgBatman();
                lblWinLoose.Text = myTrig.Lose;
                btnFire.Enabled = false;
                btnLoad.Enabled = false;
                btnSpin.Enabled = false;
                btnPlayAgain.Enabled = true;
                // Increments the Lose counter by one each time you loose
                myTrig.LoseScore++;
                lblLosses.Text = myTrig.LoseScore.ToString();
            }

        }

        public void NearMiss()
        {
            // Fire Away Checkbox - Can fire away from you only twice and will reset the game
            if (checkFireAway.Checked && lblShots.Text == myTrig.RNDNumber.ToString())
            {
                myTrig.Win = myTrig.WinMsgBatman();
                lblWinLoose.Text = myTrig.Win;
                btnFire.Enabled = false;
                btnLoad.Enabled = false;
                btnSpin.Enabled = false;
                btnPlayAgain.Enabled = true;
                // Increments the Win counter by one each time you win
                myTrig.WinScore++;
                lblWins.Text = myTrig.WinScore.ToString();
            }
        }

        public void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // Reset everything and start again
            Reset();
            PlayAgain();
        }

        public void btnLoad_Click(object sender, EventArgs e)
        {
            // Start the game from scratch
            LoadGame();
        }

        public void Reset()
        {
            myTrig.Shots = 0;
            myTrig.FireAwayNum = 2;
            lblLives.Text = "2";
            lblShots.Text = "0";
            lblWinLoose.Text = "";
            btnLoad.Enabled = false;
        }

        public void PlayAgain()
        {
            btnLoad.Enabled = true;
        }

        public void LoadGame()
        {
            btnFire.Enabled = false;
            btnLoad.Enabled = true;
            btnSpin.Enabled = true;
            btnPlayAgain.Enabled = false;
        }

        public void btnMenu_Click(object sender, EventArgs e)
        {
            // Back to main menu and reset while keeping scores
            this.Hide();
            this.Reset();
            PlayAgain();
        }
    }
}

