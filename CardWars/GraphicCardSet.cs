using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardWars
{
    class GraphicCardSet : CardSet
    {
        public Panel Panel { get; set; }

        public GraphicCardSet(Panel panel) : base()
        {
            Panel = panel;
        }

        public GraphicCardSet(Panel panel, int count) : this(panel)
        {
            foreach (var character in Enum.GetValues(typeof(CardCharacter)))
            {
                foreach (var landscape in Enum.GetValues(typeof(CardLandscape)))
                {
                    Cards.Add(new GraphicCard((CardCharacter)character, (CardLandscape)landscape));
                }
            }
            if (count < Count)
                Cards.RemoveRange(0, Count - count);
        }

        public override void Show()
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                GraphicCard graphicCard = (GraphicCard)Cards[i];
                PictureBox pb = graphicCard.Pb;
                Panel.Controls.Add(pb);
                pb.BringToFront();
                pb.Location = new Point(i * 30, 0);
                pb.Size = new Size(Panel.Width / Cards.Count, Panel.Height);
                pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pb.TabIndex = i;
                pb.TabStop = false;

                graphicCard.Show();
            }

        }

    }

}
