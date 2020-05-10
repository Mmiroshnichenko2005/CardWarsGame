using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardWars
{
     class GraphicCard : Card
    {
        public PictureBox Pb { get; set; }

        public GraphicCard(CardCharacter character, CardLandscape landscape) : base(character, landscape)
        {
            Pb = new PictureBox();
        }

        public GraphicCard(CardCharacter character, CardLandscape landscape, PictureBox pb) : base(character, landscape)
        {
            Pb = pb;
        }

        public override void Show()
        {
             var exePath = AppDomain.CurrentDomain.BaseDirectory;//path to exe file
             var path1 = Path.Combine(exePath, @"Cards/"+ Landscape.ToString() + " " + Character.ToString() + ".png");
             
        }
    }
}
