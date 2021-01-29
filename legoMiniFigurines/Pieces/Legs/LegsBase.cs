using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigurines.Pieces.Legs
{
    class LegsBase
    {
        public string Covering { get; set; }
        public Size Size { get; set; }
        public int Speed { get; protected set; }
        public string Shoes { get; set; }
        public int NumberOfLegs { get; set; }

        //field
        protected string _musicGenre;

        public LegsBase()
        {
            NumberOfLegs = 2;
            Size = Size.Adult;
            Covering = "Pants";
            Speed = 1;
            _musicGenre = "Waltz";
        }

        //can change
        public virtual void Dance()
        {
            var danceSpeed = Speed > 5 ? "Fast" : "Slow";

            Console.WriteLine($"The {GetType().Name} {Size} legs danced {danceSpeed} to {_musicGenre} wearing {Covering} and {Shoes}.");
        }

        //can't change
        public void Walk()
        {
            Console.WriteLine($"The {GetType().Name} {Size} legs walked {Speed} steps forward.");
        }


    }
}
