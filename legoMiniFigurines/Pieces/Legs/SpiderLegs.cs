using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigurines.Pieces.Legs
{
    class SpiderLegs : LegsBase
    {
        public SpiderLegs()
        {
            Shoes = "Rollerskates";
            NumberOfLegs = 8;
            Speed = 100;
            _musicGenre = "Shoegaze";
            Size = Size.Spider;
            Covering = "Hair";

        }

        public override void Dance()
        {
            Console.Write($"Spider dancing");
        }

    }
}
