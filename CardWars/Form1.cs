using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CardWars
{
    public partial class Form1 : Form
    {
        int i = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image flipImage = P1Land.Image;
            Image flipImage1 = P2Land.Image;
            flipImage1.RotateFlip(RotateFlipType.Rotate90FlipXY);
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            P2Land.Image = flipImage1;
            P1Land.Image = flipImage;
        }

        

        private void LandscapeSet_Click(object sender, EventArgs e)
        {
          /*  var exePath = AppDomain.CurrentDomain.BaseDirectory;//path to exe file
            string[] lands = new string[2];
            lands[0] = @"Lands\Naboo.png";
            lands[1] = @"Lands\Jakku.png";
            Random rnd = new Random();
            int rndLand = rnd.Next(0, 2);
            var path1= Path.Combine(exePath, @""); 
            if(rndLand == 0)
            {
                path1 = Path.Combine(exePath, lands[0]);
            }
            if (rndLand == 1)
            {
                path1 = Path.Combine(exePath, lands[1]);
            }
            LandscapePlayer.ImageLocation = path1;
        */}

        private void CharacterSet_Click(object sender, EventArgs e)
        {
          /*  var exePath = AppDomain.CurrentDomain.BaseDirectory;//path to exe file
            string[] characters = new string[3];
            characters[0] = @"Cards\Naboo high.png";
            characters[1] = @"Cards\Naboo low.png";
            characters[2] = @"Cards\Naboo medium.png";
            Random rnd = new Random();
            int rndLand = rnd.Next(0, 3);
            var path1 = Path.Combine(exePath, @"");
            PictureBox[] pbCards = new PictureBox[4];
            pbCards[0] = Card1;
            pbCards[1] = Card2;
            pbCards[2] = Card3;
            pbCards[3] = Card4;
            if (rndLand == 0)
            {
                path1 = Path.Combine(exePath, characters[0]);
                i++;
            }
            if (rndLand == 1)
            {
                path1 = Path.Combine(exePath, characters[1]);
                i++;
            }
            if (rndLand == 2)
            {
                path1 = Path.Combine(exePath, characters[2]);
                i++;
            }
            if (i > 3)
            {
                MessageBox.Show("Ваше количество кард - максимальное");
                return;
            }
            pbCards[i].ImageLocation = path1;*/
        }

        private void LandscapePlayer_Click(object sender, EventArgs e)
        {

        }

        private void PlayerHP_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
    }
}
