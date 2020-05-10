using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWars
{
    public enum CardCharacter
    {
        low,
        medium,
        high
    }

    public enum CardLandscape
    {
        Naboo
    }
    class Card
    {
        public CardCharacter Character { get; set; }
        public CardLandscape Landscape { get; set; }

        public Card(CardCharacter character, CardLandscape landscape)
        {
            Character = character;
            Landscape = landscape;
        }

        public virtual void Show()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", Character, Landscape);
        }
       
        }
    }
