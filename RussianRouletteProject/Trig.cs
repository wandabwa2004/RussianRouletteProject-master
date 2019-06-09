using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRouletteProject
{
    public class Trig
    {
        // Random Number for spinchamber Set
        public int RNDNumber { get; set; }
        // Win Message Set
        public string Win { get; set; }
        // Lose Message Set
        public string Lose { get; set; }
        // Number of Shots Set
        public int Shots { get; set; }
        // How many times you can fire away set
        public int FireAwayNum { get; set; } = 2;
        // Error Messagebox set
        public string MsgBox { get; set; }
        // How many wins you have set
        public int WinScore { get; set; } = 0;
        // How many losses you have set
        public int LoseScore { get; set; } = 0;


        public int RNDNumberGenerate()
        {
            Random myRandom = new Random();
            // Sets the random number between 1 and 6 for the Spin Chamber

            return myRandom.Next(1, 7);
        }

        public string WinMsgSanta()
        {
            // Displays a win message for the santa screen
            Win = "Well done you didn't shoot Santa. You might just get presents this year.";

            return Win;
        }

        public string LoseMsgSanta()
        {
            // Displays a loose message for the santa screen
            Lose = "You killed Santa. Nice.";

            return Lose;
        }
        public string WinMsgBatman()
        {
            // Displays a win message for the batman screen
            Win = "Batman Lives! He can continue to protect Gotham.";

            return Win;
        }

        public string LoseMsgBatman()
        {
            // Displays a loose message for the batman screen
            Lose = "You killed Batman. The Joker has enslaved all of Gotham, nice work.";

            return Lose;
        }

        public string MsgBoxBatman()
        {
            // Displays a error messagebox for batman screen
            MessageBox.Show("You can't fire away anymore... You killed Batman! Click 'Play Again'.");
            return MsgBox;
        }

        public string MsgBoxSanta()
        {
            // Displays a error messagebox for santa screen
            MessageBox.Show("You can't fire away anymore... You killed Santa! Click 'Play Again'.");
            return MsgBox;
        }

        public int ShotsFired()
        {
            // Increments the number of shots by one everytime you click the FIRE button
            Shots++;
            if (Shots > 6)
            {
                MessageBox.Show("You have no bullets left, Try Again");
                Shots = 0;
            }

            return Shots;
        }

    }

}


