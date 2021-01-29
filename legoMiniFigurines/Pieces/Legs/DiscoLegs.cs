using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigurines.Pieces.Legs
{
    class DiscoLegs : LegsBase
    {
        public DiscoLegs()
        {
            _musicGenre = "Disco";
            Speed = 20;
            Covering = "Bell Bottoms";
            Shoes = "Platform";
            Size = Size.Baby;
        }
    }
}
